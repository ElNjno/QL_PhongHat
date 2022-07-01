using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QL_Karaoke
{
    public partial class Frm_ThanhToan : Form
    {
        XyLyDatabase db = new XyLyDatabase();
        DataTable dtLayDuLieuDatPhong, dtLayDuLieuNhanPhong, dtLayDuLieuPhongHat, dtchitietdichvu, dtHoaDon;
        DataTable dtTongTienDV,dtSL,dtPhongHat,dtSetHoaDon, dtMaHHoaDon;
        string MaTP,MaPH;
        DateTime TGHienTai = DateTime.Now;
        string giovao, giora;
        String MaNV;
        SqlCommand lenh = new SqlCommand();
        DataAdapter da;
        SqlDataAdapter adapter = new SqlDataAdapter();



        public double TinhTienTheoGio(string giovao, string giora, string tenph)
        {
            string gioThucTeVao = giovao;
            string gioThucTeRa = giora;
            double TongTien = 0;
            try
            {
                string sql = string.Format(@"select *  from PHONGHAT where TenPH = N'{0}'", tenph);
                dtPhongHat = db.LayDuLieu(sql);

                DataRow getPH = dtPhongHat.Rows[0];
                double caodiem = Convert.ToDouble(getPH["GiaCaoDiem"].ToString());
                double bthuong = Convert.ToDouble(getPH["GiaBinhThuong"].ToString());

                string phutvao = gioThucTeVao.Substring(3, 2);
                string phutra = gioThucTeRa.Substring(3, 2);

                giovao = giovao.Substring(0, 2);
                giora = giora.Substring(0, 2);

                DateTime datetime = new DateTime();
                datetime = datetime.Date.AddHours(12).AddMinutes(20).AddSeconds(10);

                // neu gio ra < 18 => tinh tien theo gia bth
                if (Int32.Parse(giora) < 18)
                {
                    string tghat = tinhGioHat(gioThucTeRa, gioThucTeVao);

                    double phut = Convert.ToDouble(tghat.Substring(3, 2));
                    double gio = Convert.ToDouble(tghat.Substring(0, 2));
                    TongTien = bthuong / 60 * (gio * 60 + phut);
                }
                // xu ly hat gio cao diem
                else if (Int32.Parse(giovao) >= 18)
                {
                    string tghat = tinhGioHat(gioThucTeRa, gioThucTeVao);

                    double phut = Convert.ToDouble(tghat.Substring(3, 2));
                    double gio = Convert.ToDouble(tghat.Substring(0, 2));
                    TongTien = caodiem / 60 * (gio * 60 + phut);
                }
                // xu ly  tu binh thuong qua cao diem
                else
                {
                    // tim so phut hat gio bth
                    string sogiobth = tinhGioHat("18:00", gioThucTeVao);
                    int sophutbth = chuyenGioThanhPhut(sogiobth);
                    // tim so phut hat gio cai diem
                    string sogiocaodiem = tinhGioHat(gioThucTeRa, "18:00");
                    int sophutcaodiem = chuyenGioThanhPhut(sogiocaodiem);
                    TongTien = (sophutcaodiem * caodiem / 60) + (sophutbth * bthuong / 60);
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Et' O Et' Loi~ Gio Hat");
            }


            return TongTien;
        }

        int chuyenGioThanhPhut(string sogiohat)
        {
            int phut = Convert.ToInt16(sogiohat.Substring(3, 2));
            int gio = Convert.ToInt16(sogiohat.Substring(0, 2));
            return gio*60+phut;
        }

        void setHoaDon(string maThuePhong)
        {
            LayMaPH();
            string sqlHoaDon = "select COUNT(*)+1 as MAHD from HOADON";
            dtMaHHoaDon = db.LayDuLieu(sqlHoaDon);
            DataRow getma = dtMaHHoaDon.Rows[0];
            string mahoadonnew ="HD_"+ getma["MaHD"].ToString();
            //float tong = 1;
            //string sql = string.Format(@"INSERT INTO HOADON VALUES ('{0}','{1}',N'Đã Thanh Toán','{2}','{3}');",mahoadonnew,maThuePhong,TGHienTai,tong);
            //db.ThemXoaSua(sql);
            dtSetHoaDon = db.LayDuLieu("select * from HOADON");
            DataRow newrow = dtSetHoaDon.NewRow();
            newrow[0] = mahoadonnew;
            newrow[1] = maThuePhong;
            // ma phong hat
            newrow[2] = MaPH;
            newrow[3] = "Đã Thanh Toán";
            newrow[6] = TGHienTai;
            newrow[4] = float.Parse(lbl_TongTienPhong.Text);
            newrow[5] = MaNV;
            dtSetHoaDon.Rows.Add(newrow);
            try
            {
                // set lai SqlDataAdapter
                string sql = "select * from HOADON";
                db.UpdateData(sql, dtSetHoaDon);
                // MessageBox.Show("Them khach hang thanh cong");
            }
            catch (Exception)
            {
                MessageBox.Show("Loi~ them hoa don");
            }
        }
        
        public Frm_ThanhToan(string Ma,String MaNhanVien)
        {
            MaTP = Ma;
            MaNV = MaNhanVien;
            InitializeComponent();
            //MessageBox.Show("MaTP:"+ MaTP);
        }
        private void Frm_ThanhToan_Load(object sender, EventArgs e)
        {
            showTheoMa(MaTP);
            ThanhToan_Databiding(MaTP);
            double tiendv = TongTienDV(MaTP);
            loadTGRa(MaTP);
            loadGioHat();
            double tiengiohat = loadTongTienGioHat();
            TinhTongTien(tiengiohat, tiendv);
            btn_HoaDon.Enabled = false;
        }
        public double loadTongTienGioHat()
        {
            double tongtien = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                string tenphong = dataGridView2.Rows[i].Cells[1].Value.ToString();
                string giovao1 = dataGridView2.Rows[i].Cells[2].Value.ToString();
                string giora1 = dataGridView2.Rows[i].Cells[3].Value.ToString();
               tongtien += TinhTienTheoGio(giovao1, giora1, tenphong);
            }         
            lbl_TienGioHat.Text = ""+ String.Format("{0:0}", tongtien);
            return tongtien;
        }
        public double TinhTongTien(double tiengiohat,double tien)
        {
            double tong = tiengiohat + tien;
            lbl_TongTienPhong.Text = ""+ String.Format("{0:0}", tong);
            return tiengiohat+ tien;
        }
        public void showTheoMa(string matp)
        {
            dataGridView2.AutoGenerateColumns = false;
            dtHoaDon = db.LayDuLieu("select TenPH,GioRa,GioVao,ROW_NUMBER() OVER (ORDER BY TenPH) as STT from PHONGHAT,THUEPHONG where PHONGHAT.MaPH=THUEPHONG.MaPH and MaTP='"+ matp+ "'");
            dataGridView2.DataSource = dtHoaDon;
            dataGridView2.Columns[0].DataPropertyName = "STT";
            dataGridView2.Columns[1].DataPropertyName = "TenPH";
            dataGridView2.Columns[2].DataPropertyName = "GioVao";
            dataGridView2.Columns[3].DataPropertyName = "GioRa";


            dataGridView1.AutoGenerateColumns = false;
            dtchitietdichvu = db.LayDuLieu("select ROW_NUMBER() OVER (ORDER BY DICHVU.MaDV) AS STT,TenDV,SoLuong,CHITIETDICHVU.DonGia,ThanhTien from CHITIETDICHVU,DICHVU where DICHVU.MaDV=CHITIETDICHVU.MaDV and MaTP ='" + matp + "'");
            dataGridView1.DataSource = dtchitietdichvu;
            dataGridView1.Columns[0].DataPropertyName = "STT";
            dataGridView1.Columns[1].DataPropertyName = "TenDV";
            dataGridView1.Columns[2].DataPropertyName = "SoLuong";
            dataGridView1.Columns[3].DataPropertyName = "DonGia";
            dataGridView1.Columns[4].DataPropertyName = "ThanhTien";
        }

        void ThanhToan_Databiding(string matp)
        {
            dtHoaDon = db.LayDuLieu("select DISTINCT  NgayVao,TenKH,KHACHHANG.SDT_KH  from THUEPHONG,KHACHHANG  where  KHACHHANG.SDT_KH = THUEPHONG.SDT_KH  and THUEPHONG.MaTP ='" + matp + "'");
            lblKH.DataBindings.Add("Text", dtHoaDon, "TenKH");
            lblDT.DataBindings.Add("Text", dtHoaDon, "SDT_KH");
            lbl_ngayVao.DataBindings.Add("Text", dtHoaDon, "NgayVao", true, DataSourceUpdateMode.OnValidation, "", "dd/MM/yyyy");
        }

        public double TongTienDV(string matp)
        {
            double tong = 0;
            string sql = string.Format("select SUM(ThanhTien) as TongTienDichVu from CHITIETDICHVU where MaTP = '{0}'", matp);
            dtTongTienDV = db.LayDuLieu(sql);
            DataRow data = dtTongTienDV.Rows[0];
            string tongtien = data["TongTienDichVu"].ToString();
            if (tongtien == "")
                tongtien = "0";
            lbl_TongTienDV.Text = String.Format("{0:0}", tongtien);
            tong = Convert.ToDouble(tongtien);
            return tong;
        }

        public void duyetdataGridView()
        {
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                string giora1 = dataGridView2.Rows[i].Cells[3].Value.ToString();
                string giovao1 = dataGridView2.Rows[i].Cells[2].Value.ToString();
                //MessageBox.Show(""+giora1);
                MessageBox.Show(tinhGioHat(giora1, giovao1));
            }
            
        }

        int demSLPhong(string MaTP)
        {
            string sql = string.Format(@"select COUNT(*) as SL from THUEPHONG,PHONGHAT where PHONGHAT.MaPH=THUEPHONG.MaPH and MaTP = '{0}'",MaTP);
            dtSL = db.LayDuLieu(sql);
            DataRow data = dtSL.Rows[0];
            int num = Convert.ToInt16(data["SL"].ToString());
            
            return num-1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {

            
        }
        public void loadTGRa(string matp)
        {
            //int sl = demSLPhong(matp);
            //DataGridViewRow row = this.dataGridView2.Rows[sl];
            //string test = row.Cells[3].Value.ToString();
            //dataGridView2.Rows[sl].Cells[3].Value = TGHienTai.ToString("HH:mm");

            // set null 
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                string giora1 = dataGridView2.Rows[i].Cells[3].Value.ToString();
                if (giora1=="")
                {                
                    dataGridView2.Rows[i].Cells[3].Value = TGHienTai.ToString("HH:mm");

                   // MessageBox.Show("NULL");
                }
            }


        }

        private void bnt_Thoat_Click(object sender, EventArgs e)
        {         
            this.Close();
        }

        public void loadGioHat()
        {
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                string giora1 = dataGridView2.Rows[i].Cells[3].Value.ToString();
                string giovao1 = dataGridView2.Rows[i].Cells[2].Value.ToString();
                //MessageBox.Show(""+giora1);
             //   MessageBox.Show(tinhGioHat(giora1, giovao1));
                dataGridView2.Rows[i].Cells[4].Value = tinhGioHat(giora1, giovao1);
            }

        }

        public void setGioRaThuePhong(string giora, string matp)
        {
            string sql = string.Format(@"update THUEPHONG  set GioRa = '{0}' where MaTP = '{1}' and GioRa is NULL",giora,matp);
            try
            {
                db.ThemXoaSua(sql);
            }
            catch (Exception)
            {
                MessageBox.Show("Loi~ setGioRaThuePhong");
            }
        }

        public string getmaph(string matp)
        {
            string sql = string.Format(@"select MaPH from THUEPHONG where TinhTrang = N'Đã Nhận Phòng' and MaTP='{0}'",matp);
            
            dtLayDuLieuPhongHat = db.LayDuLieu(sql);
            DataRow data = dtLayDuLieuPhongHat.Rows[0];
            string maphonghat = data["MaPH"].ToString();
            return maphonghat;
        }
        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Xác Nhận Thanh Toán", "Thanh Toan'", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                LayMaPH();
                // set lai tinh trang phong hat
                // get ma ph
                string getma = getmaph(MaTP);

                string settinhtrang = "UPDATE PHONGHAT  SET TinhTrang = N'Phòng Trống' WHERE MaPH='" + getma + "'";
                SetTinhTrangPhongHat(settinhtrang);

                // set lai gio ra cho khách hàng
                string giora = TGHienTai.ToString("HH:mm");
                string matp = MaTP;
                string maphonghat = MaPH;
                setGioRaThuePhong(giora, matp);

                // set lai tinh trang trong table thue phong cho khach
                string setTT_Table_ThuePhong = string.Format(@"UPDATE THUEPHONG SET TinhTrang = N'Đã Thanh Toán' WHERE MaTP = '{0}'",MaTP);
                db.ThemXoaSua(setTT_Table_ThuePhong);
                // hoa don cho khach 
                string slMaHD = "select count(*) SLMa from HOADON ";
                string thuphonghoadon = "HD_" + demSoLuong(slMaHD, "SLMa", 1, dtHoaDon);

                // them vao hoa don
                //setHoaDon(maphonghat);
                setHoaDon(matp);


                MessageBox.Show("Thanh Toan Thanh Cong ");
                btn_HoaDon.Enabled = true;


                //thanh toan roi moi in hoa don


                Main formmain = new Main(MaNV);
                Frm_NhanDatPhong FrmDP = new Frm_NhanDatPhong(MaNV);
                formmain.Visible = true;
                FrmDP.MdiParent = Main.ActiveForm;
                FrmDP.Show();

            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Huy~ Thanh Toan");
            }
            // create vao` hoa don


        }

        public int demSoLuong(string sql, string table, int SoTang, DataTable dtSQL)
        {
            dtSQL = db.LayDuLieu(sql);
            DataRow sl = dtSQL.Rows[0];
            int num = Convert.ToInt16(sl[table].ToString());
            return num + SoTang;
        }
        public void LayMaPH()
        {
            string laydulieu = "select PHONGHAT.MaPH from PHONGHAT,THUEPHONG where PHONGHAT.MaPH=THUEPHONG.MaPH and MaTP='" + MaTP + "'";
            dtLayDuLieuPhongHat = db.LayDuLieu(laydulieu);
            DataRow data = dtLayDuLieuPhongHat.Rows[0];
            MaPH = data["MaPH"].ToString();
            //  MessageBox.Show("data: " + MaPH);

        }

        public void SetTinhTrangPhongHat(string sql)
        {
            try
            {
                db.ThemXoaSua(sql);
            }
            catch (Exception)
            {
                MessageBox.Show("Loi~ SetTinhTrangPhongHat");
            }
        }

        public string tinhGioHat(string giora1 , string giovao1)
        {
            string GioHat = "";
            string sgio = "", sphut = "", schuoi = "";
            if (giovao1 != "" && giora1 != "")
            {
                TimeSpan diff = DateTime.Parse(giora1) - DateTime.Parse(giovao1);
                String sMsg = diff.Days.ToString() + "-" + diff.Hours + "-" + diff.Minutes + "-" + diff.Seconds;
                string[] smanggio = sMsg.Split('-');
                if (smanggio.Length > 2)
                {
                    if (smanggio[1].ToString().Length <= 1)
                        sgio = "0" + smanggio[1].ToString();
                    else
                        sgio = smanggio[1].ToString();

                    if (smanggio[2].ToString().Length <= 1)
                        sphut = "0" + smanggio[2].ToString();
                    else
                        sphut = smanggio[2].ToString();
                }
                schuoi = sgio + ":" + sphut;
            }
           // MessageBox.Show(schuoi);
            return schuoi;
        }

        // làm hóa đơn cho khách hàng 
        // tình trạng hóa đơn cho khách hàng
    }
}
