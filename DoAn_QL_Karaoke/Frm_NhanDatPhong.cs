using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QL_Karaoke
{

    public partial class Frm_NhanDatPhong : Form
    {
        SqlCommand da = new SqlCommand();
        
        string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        XyLyDatabase db = new XyLyDatabase();
        DataTable dtLayDuLieuDatPhong, dtLayDuLieuNhanPhong,dtLayDuLieuPhongHat;
        DataTable dtKhachHang, dtThuePhong, dtPhongHat,dtphongdatonline;
        DataTable dtSQL,dtcheck;
        DataColumn[] keyKhachHang = new DataColumn[1];
        DateTime TGHienTai = DateTime.Now;
        ListViewItem lsv_Item;
        string MaNV;

        int checkNhanPhong = 0;
        public Frm_NhanDatPhong(String Ma)
        {
            MaNV = Ma;
            InitializeComponent();
        }

        public void DatPhong()
        {
            // dat phong
            dataGridView1.AutoGenerateColumns = false;
            dtLayDuLieuDatPhong = db.LayDuLieu("select KHACHHANG.SDT_KH,TenKH,TenPH,THUEPHONG.MaTP, THUEPHONG.NgayVao,THUEPHONG.GioVao,GiaCaoDiem,GiaBinhThuong from KHACHHANG,THUEPHONG,PHONGHAT where KHACHHANG.SDT_KH = THUEPHONG.SDT_KH AND PHONGHAT.MaPH = THUEPHONG.MaPH AND THUEPHONG.TinhTrang = N'Chưa Nhận Phòng'");
            dataGridView1.DataSource = dtLayDuLieuDatPhong;
            dataGridView1.Columns[0].DataPropertyName = "TenPH";
            dataGridView1.Columns[1].DataPropertyName = "TENKH";
            dataGridView1.Columns[2].DataPropertyName = "SDT_KH";
            dataGridView1.Columns[3].DataPropertyName = "NgayVao";
            dataGridView1.Columns[4].DataPropertyName = "GioVao";
        }

        public void NhanPhong()
        {
            // nhan phong
            //dataGridView2.
            dataGridView2.AutoGenerateColumns = false;
            dtLayDuLieuNhanPhong = db.LayDuLieu("select KHACHHANG.SDT_KH,TenKH,TenPH,THUEPHONG.MaTP, THUEPHONG.NgayVao,THUEPHONG.GioVao,GiaCaoDiem,GiaBinhThuong from KHACHHANG,THUEPHONG,PHONGHAT where KHACHHANG.SDT_KH = THUEPHONG.SDT_KH AND PHONGHAT.MaPH = THUEPHONG.MaPH AND THUEPHONG.TinhTrang = N'Đã Nhận Phòng'; ");
            dataGridView2.DataSource = dtLayDuLieuNhanPhong;
            dataGridView2.Columns[0].DataPropertyName = "TenPH";
            dataGridView2.Columns[1].DataPropertyName = "TENKH";
            dataGridView2.Columns[2].DataPropertyName = "SDT_KH";
            dataGridView2.Columns[3].DataPropertyName = "NgayVao";
            dataGridView2.Columns[4].DataPropertyName = "GioVao";
            Xoa_DataBindings();            
        }

        private void Frnm_NhanDatPhong_Load(object sender, EventArgs e)
        {
            btn_chuyenphong.Enabled = false;
            btn_ThanhToan.Enabled = false;
            btn_NPhongDT.Enabled = false;

            txt_SDT.Enabled = false;
            txt_KhachHang.Enabled = false;

            dtKhachHang = db.LayDuLieu("select * from KHACHHANG");
            dtThuePhong = db.LayDuLieu("select * from THUEPHONG");

            keyKhachHang[0] = dtKhachHang.Columns[0];
            dtKhachHang.PrimaryKey = keyKhachHang;

            DatPhong();
            NhanPhong();
            rad_Tatca.Checked = true;
            ShowListViewPhong();
        }

        public bool checkNhapKhachHang()
        {
            if (txt_KhachHang.Text == "" || txt_SDT.Text == "") return false;
            return true;
        }

        public bool demSQL(string sql,string table)
        {
            dtSQL = db.LayDuLieu(sql);
            DataRow sl = dtSQL.Rows[0];
            int num = Convert.ToInt16(sl[table].ToString());
            if (num==1)            
                return true;
            return false;        
        }
        public int demSoLuong(string sql, string table)
        {
            dtSQL = db.LayDuLieu(sql);
            DataRow sl = dtSQL.Rows[0];
            int num = Convert.ToInt16(sl[table].ToString());
            return num;
        }
        public int demSoLuong(string sql, string table,int SoTang)
        {
            dtSQL = db.LayDuLieu(sql);
            DataRow sl = dtSQL.Rows[0];
            int num = Convert.ToInt16(sl[table].ToString());
            return num+SoTang;
        }

        private void btn_NPhongTQ_Click(object sender, EventArgs e)
        {
          //  MessageBox.Show("" + TGHienTai.ToString("yyy/MM/dd"));
            //   xoadulieu();
            try
            {
                showPhongTrong();
                if (checkNhanPhong == 0)
                {
                    Xoa_DuLieuForm();
                    btn_NPhongTQ.Text = "Xác Nhận Đặt Phòng";
                    // an button
                    btn_chuyenphong.Enabled = false;
                    btn_ThanhToan.Enabled = false;
                    btn_NPhongDT.Enabled = false;

                    txt_SDT.Enabled = true;
                    txt_KhachHang.Enabled = true;
                    checkNhanPhong = 1;
                }
                else
                {
                    btn_chuyenphong.Enabled = true;
                    btn_ThanhToan.Enabled = true;
                    btn_NPhongDT.Enabled = true;
                    txt_SDT.Enabled = false;
                    txt_KhachHang.Enabled = false;
                    if (checkThuePhong(txt_SDT.Text))
                    {
                        DialogResult dialogResult = MessageBox.Show("Khách Đang Thuê 1 Phòng Khác, xác nhận thuê phòng này cho khách", "Thanh Toan'", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            if (checkNhapKhachHang())
                            {
                                string Check_SDT = "SELECT COUNT(*) SDT FROM KHACHHANG WHERE SDT_KH = " + txt_SDT.Text;
                                // them moi khach hang
                                if (demSQL(Check_SDT, "SDT") == false)
                                {
                                    Xoa_DataBindings();
                                    DataRow newrow = dtKhachHang.NewRow();
                                    newrow[0] = txt_SDT.Text;
                                    newrow[1] = txt_KhachHang.Text;
                                    newrow[2] = 0;
                                    dtKhachHang.Rows.Add(newrow);
                                    try
                                    {
                                        // set lai SqlDataAdapter
                                        string sql = "select * from KHACHHANG";
                                        db.UpdateData(sql, dtKhachHang);
                                        //   MessageBox.Show("Them khach hang thanh cong");
                                    }
                                    catch (Exception)
                                    {
                                        MessageBox.Show("Loi~ them khach hang");
                                    }
                                }

                                // xu ly thue phong
                                string slMaTP = "select   count(distinct MaTP)  SLMa from THUEPHONG";
                                string MaTP = "TP_" + demSoLuong(slMaTP, "SLMa", 1);
                                Xoa_DataBindings();

                                DataRow thuephong = dtThuePhong.NewRow();
                                thuephong[0] = MaTP;
                                // set ma ph

                                //
                                string laymaph = "select MaPH from PHONGHAT where TenPH = N'" + lbl_TenPhong.Text + "'";
                                dtSQL = db.LayDuLieu(laymaph);

                                DataRow data = dtSQL.Rows[0];
                                string matphong = data["MaPH"].ToString();
                                thuephong[1] = matphong;
                                thuephong[2] = MaNV;
                                thuephong[3] = txt_SDT.Text;
                                thuephong[4] = TGHienTai.ToString("HH:mm"); // gio vao                                                                       //thuephong[6] = null;
                                thuephong[6] = "Đã Nhận Phòng";
                                thuephong[7] = TGHienTai.ToString("yyy/MM/dd"); // ngay vao
                                dtThuePhong.Rows.Add(thuephong);
                                try
                                {
                                    // set lai SqlDataAdapter
                                    string sql = "select * from THUEPHONG";
                                    db.UpdateData(sql, dtThuePhong);
                                    MessageBox.Show("Thue Phong thanh cong");

                                    string updatephong = "UPDATE PHONGHAT SET TinhTrang = N'Phòng Có Khách'WHERE TenPH=N'" + lbl_TenPhong.Text + "'";
                                    try
                                    {
                                        db.ThemXoaSua(updatephong);
                                        // MessageBox.Show("Set Phong Thanh Cong");
                                    }
                                    catch (Exception)
                                    {
                                        MessageBox.Show("Loi~");
                                    }
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("Loi~ thue phong");
                                }

                            }
                            else
                                MessageBox.Show("Nhap Du Lieu Khach Hang", "Thong Bao");
                            //Xoa_DuLieu();
                            NhanPhong();
                        }
                        else
                        {
                            MessageBox.Show("Huy Thue Phong", "Thong Bao");
                        }
                    }
                    else
                    {
                        if (checkNhapKhachHang())
                        {
                            string Check_SDT = "SELECT COUNT(*) SDT FROM KHACHHANG WHERE SDT_KH = " + txt_SDT.Text;
                            // them moi khach hang
                            if (demSQL(Check_SDT, "SDT") == false)
                            {
                                Xoa_DataBindings();
                                DataRow newrow = dtKhachHang.NewRow();
                                newrow[0] = txt_SDT.Text;
                                newrow[1] = txt_KhachHang.Text;
                                newrow[2] = 0;
                                dtKhachHang.Rows.Add(newrow);
                                try
                                {
                                    // set lai SqlDataAdapter
                                    string sql = "select * from KHACHHANG";
                                    db.UpdateData(sql, dtKhachHang);
                                    //   MessageBox.Show("Them khach hang thanh cong");
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("Loi~ them khach hang");
                                }
                            }
                            // xu ly thue phong
                            string slMaTP = "select   count(distinct MaTP)  SLMa from THUEPHONG";
                            string MaTP = "TP_" + demSoLuong(slMaTP, "SLMa", 1);
                            Xoa_DataBindings();
                            DataRow thuephong = dtThuePhong.NewRow();
                            thuephong[0] = MaTP;
                            // set ma ph
                            //

                            string laymaph = "select MaPH from PHONGHAT where TenPH = N'" + lbl_TenPhong.Text + "'";
                            dtSQL = db.LayDuLieu(laymaph);
                            DataRow data = dtSQL.Rows[0];
                            string matphong = data["MaPH"].ToString();

                            thuephong[1] = matphong;
                            thuephong[2] = MaNV;
                            thuephong[3] = txt_SDT.Text;
                            thuephong[4] = TGHienTai.ToString("HH:mm"); // gio vao                                                                       //thuephong[6] = null;
                            thuephong[6] = "Đã Nhận Phòng";
                            thuephong[7] = TGHienTai.ToString("yyy/MM/dd"); // ngay vao

                            dtThuePhong.Rows.Add(thuephong);
                            try
                            {
                                // set lai SqlDataAdapter
                                string sql = "select * from THUEPHONG";
                                db.UpdateData(sql, dtThuePhong);
                                MessageBox.Show("Thue Phong thanh cong");

                                string updatephong = "UPDATE PHONGHAT SET TinhTrang = N'Phòng Có Khách'WHERE TenPH=N'" + lbl_TenPhong.Text + "'";
                                try
                                {
                                    db.ThemXoaSua(updatephong);
                                    // MessageBox.Show("Set Phong Thanh Cong");
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("Loi~");
                                }
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Loi~ thue phong");
                            }

                        }
                        else
                            MessageBox.Show("Nhap Du Lieu Khach Hang", "Thong Bao");
                        //Xoa_DuLieu();
                        NhanPhong();
                    }

                    btn_NPhongTQ.Text = "Đặt Phòng Tại Quầy";
                    checkNhanPhong = 0;
                    ShowListViewPhong();
                    rad_Tatca.Checked = true;
                    btn_chuyenphong.Enabled = false;
                    btn_ThanhToan.Enabled = false;
                    btn_NPhongDT.Enabled = false;
                    txt_SDT.Enabled = false;
                    txt_KhachHang.Enabled = false;
                }
                // check  du lieu khach hang            
                Xoa_DuLieuForm();
            }
            catch (Exception)
            {
                MessageBox.Show("Phong Khach Da Tung Thue");
            }
           

        }

        // dang thue thi` check = false
        public bool checkThuePhong(string sdt)
        {
            string sql = string.Format(@"select COUNT(*) sl from THUEPHONG where TinhTrang=N'Đã Nhận Phòng' and SDT_KH= {0}", sdt);
            dtcheck = db.LayDuLieu(sql);

            DataRow sl = dtcheck.Rows[0];
            int num = Convert.ToInt16(sl["sl"].ToString());
            if (num == 0)
                return false;
            return true;
        }
        public void Xoa_DataBindings()
        {
            txt_KhachHang.DataBindings.Clear();
            lbl_TenPhong.DataBindings.Clear();
            lbl_GioCD.DataBindings.Clear();
            lbl_GioBT.DataBindings.Clear();
            txt_SDT.DataBindings.Clear();
            lbl_Giovao.DataBindings.Clear();
            //lbl_Giora.DataBindings.Clear();
            //lbl_TGHat.DataBindings.Clear();
            //lbl_ThanhTien.DataBindings.Clear();
            //lbl_TongTien.DataBindings.Clear();
            lbl_ngay.DataBindings.Clear();
            lbl_NgayCS.DataBindings.Clear();
            lbl_GioCS.DataBindings.Clear();
            lbl_MaTP.DataBindings.Clear();

        }
        public void Xoa_DuLieu()
        {
            lbl_MaTP.Text = "";
            lbl_TenPhong.Text = "";
            lbl_GioCD.Text = "";
            lbl_GioBT.Text = "";
            txt_KhachHang.Clear();
            txt_SDT.Clear();
            lbl_Giovao.Text = "";
            //lbl_Giora.Text = "";
            //lbl_TGHat.Text = "";
            //lbl_ThanhTien.Text = "";
            //lbl_TongTien.Text = "";
            lbl_ngay.Text = "";
            lbl_NgayCS.Text = "";
            lbl_GioCS.Text = "";
            Xoa_DataBindings();
        }

        public void Xoa_DuLieuForm()
        {
            lbl_MaTP.Text = "";
            lbl_TenPhong.Text = "";
            lbl_GioCD.Text = "";
            lbl_GioBT.Text = "";
            txt_KhachHang.Clear();
            txt_SDT.Clear();
            lbl_Giovao.Text = "";
            //lbl_Giora.Text = "";
            //lbl_TGHat.Text = "";
            //lbl_ThanhTien.Text = "";
            //lbl_TongTien.Text = "";
            lbl_ngay.Text = "";
            lbl_NgayCS.Text = "";
            lbl_GioCS.Text = "";
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Xoa_DuLieu();
            DSPhongDat_Databiding();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Xoa_DuLieu();
            DSNhanPhong_Databiding();
        }


        private void btn_NPhongDT_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Xác Nhận Nhan Phòng", "Tnong Bao'", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string sql = "UPDATE THUEPHONG SET TinhTrang = N'Đã Nhận Phòng' WHERE MaTP = '" + lbl_MaTP.Text + "'";
                //MessageBox.Show("sql: "+sql);
                try
                {
                    db.ThemXoaSua(sql);
                    MessageBox.Show("Nhan Phong Thanh Cong");
                }
                catch (Exception)
                {
                    MessageBox.Show("Loi~");
                }
                // xu ly gio dat
                string updatephong = "UPDATE PHONGHAT SET TinhTrang = N'Phòng Có Khách'WHERE TenPH=N'" + lbl_TenPhong.Text + "'";
                try
                {
                    db.ThemXoaSua(updatephong);
                    //MessageBox.Show("Set Phong Thanh Cong");
                }
                catch (Exception)
                {
                    MessageBox.Show("Loi~");
                }
                Xoa_DuLieuForm();
                DatPhong();
                NhanPhong();
                ShowListViewPhong();
            }
        }

        private void btn_chuyenphong_Click(object sender, EventArgs e)
        {

            if (lbl_MaTP.Text.Length==0 || lbl_TenPhong.Text.Length == 0)
            {
                MessageBox.Show("Phong Trống");
            }
            else
            {
                Frm_ChuyenPhong FrmDP = new Frm_ChuyenPhong(lbl_MaTP.Text, lbl_TenPhong.Text,MaNV);
                //FrmDP.MdiParent = Main.ActiveForm;
                //this.Close();
                FrmDP.ShowDialog();
                
            }

        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            Frm_ThanhToan FrmDP = new Frm_ThanhToan(lbl_MaTP.Text,MaNV);
        // FrmDP.MdiParent = this;
            FrmDP.Show();
        }

        public void showPhongTrong()
        {
            rad_PhongTrong.Checked = true;

            lst_Phong.Items.Clear();
            dtPhongHat = db.LayDuLieu("select TenPH,TinhTrang from PHONGHAT where TinhTrang = N'Phòng Trống'");
            for (int i = 0; i < dtPhongHat.Rows.Count; i++)
            {
               // MessageBox.Show("a");
                lsv_Item = lst_Phong.Items.Add(dtPhongHat.Rows[i]["TenPH"].ToString());
                lsv_Item.ImageIndex = 0;
            }

        }

        public void showPhongTheoRadio()
        {
            lst_Phong.Items.Clear();
            dtPhongHat = db.LayDuLieu("select TenPH,TinhTrang from PHONGHAT");
            for (int i = 0; i < dtPhongHat.Rows.Count; i++)
            {
                if (rad_PhongTrong.Checked == true && dtPhongHat.Rows[i]["TinhTrang"].ToString() == "Phòng Trống")
                {
                    // MessageBox.Show("0");
                    xoadulieu();
                    lsv_Item = lst_Phong.Items.Add(dtPhongHat.Rows[i]["TenPH"].ToString());
                    lsv_Item.ImageIndex = 0;
                }
                if (rad_PhongCoKhach.Checked == true && dtPhongHat.Rows[i]["TinhTrang"].ToString() == "Phòng Có Khách")
                {
                    lsv_Item = lst_Phong.Items.Add(dtPhongHat.Rows[i]["TenPH"].ToString());
                    lsv_Item.ImageIndex = 1;
                }
                if (rad_PhongDaDat.Checked == true && dtPhongHat.Rows[i]["TinhTrang"].ToString() == "Phòng Đã Đặt")
                {
                    lsv_Item = lst_Phong.Items.Add(dtPhongHat.Rows[i]["TenPH"].ToString());
                    lsv_Item.ImageIndex = 2;
                }
            }
            Xoa_DataBindings();
        }
        void xoadulieu()
        {
            lbl_MaTP.Text= txt_KhachHang.Text = txt_SDT.Text = lbl_TenPhong.Text = lbl_GioBT.Text = lbl_GioCD.Text = lbl_ngay.Text = lbl_Giovao.Text = "";
        }
        private void lst_Phong_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_TenPhong.Text = lst_Phong.SelectedItems[0].SubItems[0].Text;
                xulyViewData(lbl_TenPhong.Text);
            }
            catch (Exception)
            {

            }
            //xoadulieu();

        }

        public void xulyViewData(string TenPhongHat)
        {

            try
            {
                // view len thong tin phong co khach
                string laydulieu = string.Format(@"select MaTP,TenKH, KHACHHANG.SDT_KH ,NgayVao, GiaBinhThuong,GiaCaoDiem,GioVao,TenPH,PHONGHAT.TinhTrang,THUEPHONG.TinhTrang as sosanh from PHONGHAT,THUEPHONG,KHACHHANG   where PHONGHAT.MaPH = THUEPHONG.MaPH and KHACHHANG.SDT_KH = THUEPHONG.SDT_KH and PHONGHAT.TenPH = N'{0}' and THUEPHONG.TinhTrang = N'Đã Nhận Phòng'", TenPhongHat);
                dtLayDuLieuPhongHat = db.LayDuLieu(laydulieu);

                DataRow data = dtLayDuLieuPhongHat.Rows[0];
                if (data["TinhTrang"].ToString() != "Phòng Trống")
                {
                    txt_KhachHang.Text = data["TenKH"].ToString();
                    lbl_MaTP.Text = data["MaTP"].ToString();
                    lbl_GioCD.Text = data["GiaCaoDiem"].ToString();
                    lbl_GioBT.Text = data["GiaBinhThuong"].ToString();
                    lbl_Giovao.Text = data["GioVao"].ToString();
                    lbl_ngay.Text = data["NgayVao"].ToString().Substring(0,10);
                    txt_SDT.Text = data["SDT_KH"].ToString();

                    btn_NPhongTQ.Enabled = false;
                    btn_chuyenphong.Enabled = true;
                    btn_ThanhToan.Enabled = true;
                    btn_NPhongDT.Enabled = true;
                    txt_SDT.Enabled = false;
                    txt_KhachHang.Enabled = false;                   
                }
            }
            catch (Exception)
            {
                // phong trong
                string laydulieu = string.Format(@"select * from PHONGHAT where TenPH = N'{0}'",TenPhongHat);
                dtLayDuLieuPhongHat = db.LayDuLieu(laydulieu);

                DataRow data = dtLayDuLieuPhongHat.Rows[0];
             //   lbl_MaTP.Text = data["MaTP"].ToString();
                lbl_GioCD.Text = data["GiaCaoDiem"].ToString();
                lbl_GioBT.Text = data["GiaBinhThuong"].ToString();

                txt_KhachHang.Text = "";
                lbl_MaTP.Text = "";
                lbl_Giovao.Text = "";
                lbl_ngay.Text = "";
                txt_SDT.Text = "";

                if (checkNhanPhong==0)
                {
                    btn_NPhongTQ.Enabled = true;

                    btn_chuyenphong.Enabled = false;
                    btn_ThanhToan.Enabled = false;
                    btn_NPhongDT.Enabled = false;
                    txt_SDT.Enabled = false;
                    txt_KhachHang.Enabled = false;
                }

                laydulieu = string.Format(@"select MaTP,TenKH, KHACHHANG.SDT_KH ,NgayVao, GiaBinhThuong,GiaCaoDiem,GioVao,TenPH,PHONGHAT.TinhTrang,THUEPHONG.TinhTrang as sosanh from PHONGHAT,THUEPHONG,KHACHHANG   where PHONGHAT.MaPH = THUEPHONG.MaPH and KHACHHANG.SDT_KH = THUEPHONG.SDT_KH and PHONGHAT.TenPH = N'{0}' and THUEPHONG.TinhTrang = N'Chưa Nhận Phòng'", TenPhongHat);
                dtphongdatonline = db.LayDuLieu(laydulieu);
                data = dtphongdatonline.Rows[0];
                if (data["TinhTrang"].ToString() == "Phòng Đã Đặt")
                {
                    txt_KhachHang.Text = data["TenKH"].ToString();
                    lbl_MaTP.Text = data["MaTP"].ToString();
                    lbl_GioCD.Text = data["GiaCaoDiem"].ToString();
                    lbl_GioBT.Text = data["GiaBinhThuong"].ToString();
                    lbl_Giovao.Text = data["GioVao"].ToString();
                    lbl_ngay.Text = data["NgayVao"].ToString().Substring(0, 10);
                    txt_SDT.Text = data["SDT_KH"].ToString();

                    btn_NPhongTQ.Enabled = false;
                    btn_chuyenphong.Enabled = false;
                    btn_ThanhToan.Enabled = false;
                    btn_NPhongDT.Enabled = true;
                    txt_SDT.Enabled = false;
                    txt_KhachHang.Enabled = false;
                }


            }

        }

        private void rad_Tatca_CheckedChanged(object sender, EventArgs e)
        {
            ShowListViewPhong();
        }

        private void rad_PhongTrong_CheckedChanged(object sender, EventArgs e)
        {
            showPhongTheoRadio();
        }

        private void rad_PhongCoKhach_CheckedChanged(object sender, EventArgs e)
        {
            showPhongTheoRadio();

        }

        private void lst_Phong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_TraPhong_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ma NV: " + MaNV);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DataTable dataaaa;
            //string matp = "TP_1";
            string sql = "SELECT  * FROM DICHVU";
            dataaaa = db.LayDuLieu(sql);
            Frm_XuatHoaDon a = new Frm_XuatHoaDon(dataaaa);
            a.Show();

        }

        private void lbl_GioCS_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Giovao_Click(object sender, EventArgs e)
        {

        }

        private void rad_PhongDaDat_CheckedChanged(object sender, EventArgs e)
        {
            showPhongTheoRadio();
        }


        public void ShowListViewPhong()
        {
            lst_Phong.Items.Clear();
            dtPhongHat = db.LayDuLieu("select TenPH,TinhTrang from PHONGHAT");
            for (int i = 0; i < dtPhongHat.Rows.Count; i++)
            {
                lsv_Item = lst_Phong.Items.Add(dtPhongHat.Rows[i]["TenPH"].ToString());
                if (dtPhongHat.Rows[i]["TinhTrang"].ToString() == "Phòng Trống")
                {
                    lsv_Item.ImageIndex = 0;
                }
                else if (dtPhongHat.Rows[i]["TinhTrang"].ToString() == "Phòng Có Khách")
                {
                    lsv_Item.ImageIndex = 1;
                }
                else
                    lsv_Item.ImageIndex = 2;
            }
            Xoa_DataBindings();
        }

        void DSPhongDat_Databiding()
        {
            txt_KhachHang.DataBindings.Add("Text", dtLayDuLieuDatPhong, "TenKH");
            txt_SDT.DataBindings.Add("Text", dtLayDuLieuDatPhong, "SDT_KH");
            lbl_TenPhong.DataBindings.Add("Text", dtLayDuLieuDatPhong, "TenPH");
            lbl_MaTP.DataBindings.Add("Text", dtLayDuLieuDatPhong, "MaTP");
            lbl_GioBT.DataBindings.Add("Text", dtLayDuLieuDatPhong, "GiaBinhThuong");
            lbl_GioCD.DataBindings.Add("Text", dtLayDuLieuDatPhong, "GiaCaoDiem");
            lbl_ngay.DataBindings.Add("Text", dtLayDuLieuDatPhong, "NgayVao", true, DataSourceUpdateMode.OnValidation, "", "dd/MM/yyyy");
            lbl_Giovao.DataBindings.Add("Text", dtLayDuLieuDatPhong, "GioVao");
            lbl_NgayCS.Text = "Ngày Đặt";
            lbl_GioCS.Text = "Giờ Đặt";
        }
        void DSNhanPhong_Databiding()
        {
            txt_KhachHang.DataBindings.Add("Text", dtLayDuLieuNhanPhong, "TenKH");
            txt_SDT.DataBindings.Add("Text", dtLayDuLieuNhanPhong, "SDT_KH");
            lbl_TenPhong.DataBindings.Add("Text", dtLayDuLieuNhanPhong, "TenPH");
            lbl_MaTP.DataBindings.Add("Text", dtLayDuLieuNhanPhong, "MaTP");
            lbl_GioBT.DataBindings.Add("Text", dtLayDuLieuNhanPhong, "GiaBinhThuong");
            lbl_GioCD.DataBindings.Add("Text", dtLayDuLieuNhanPhong, "GiaCaoDiem");
            lbl_ngay.DataBindings.Add("Text", dtLayDuLieuNhanPhong, "NgayVao", true, DataSourceUpdateMode.OnValidation, "", "dd/MM/yyyy");
            lbl_Giovao.DataBindings.Add("Text", dtLayDuLieuNhanPhong, "GioVao");
            lbl_NgayCS.Text = "Ngày Vào";
            lbl_GioCS.Text = "Giờ Vào";
        }
    }
}


