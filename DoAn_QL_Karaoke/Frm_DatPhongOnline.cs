using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QL_Karaoke
{
    public partial class Frm_DatPhongOnline : Form
    {
        string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

        XyLyDatabase db = new XyLyDatabase();
        DataTable dtKhachHang, dtPhongHat, dtLayDuLieuPhongHat;
        DataTable dtSoLuongKH, dtThuePhong;
        DateTime TGHienTai = DateTime.Now;
        ListViewItem lsv_Item;
        String MaNV;
        public Frm_DatPhongOnline(string ma)
        {
            MaNV = ma;
            InitializeComponent();
        }

        private void Frm_DatPhongOnline_Load(object sender, EventArgs e)
        {
            showPhongTrong();
        }

        private void lst_Phong_Click(object sender, EventArgs e)
        {
            lbl_TenPhong.Text = lst_Phong.SelectedItems[0].SubItems[0].Text;
            xulyViewData(lbl_TenPhong.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatPhongOnline(txt_SDT.Text);
            MessageBox.Show("Dat Phong Thanh Cong");
            Main formmain = new Main(MaNV);
            Frm_NhanDatPhong FrmDP = new Frm_NhanDatPhong(MaNV);
            formmain.Visible = true;
            FrmDP.MdiParent = Main.ActiveForm;
            FrmDP.Show();
        }

        public void DatPhongOnline(string SDT_KhachHang)
        {
            // check du lieu dau vao
            if (checkKhachHang(SDT_KhachHang))
            {
               // MessageBox.Show("Co Khach Hang");
            }
            else
            {
                ThemKhachHangMoi( txt_SDT.Text, txt_KhachHang.Text);
            }
            try
            {
                string matpmoi = XuLyTuDongGetMaThuePhong();
                Xoa_DataBindings();

                dtThuePhong = db.LayDuLieu("select * from THUEPHONG");
                DataRow thuephong = dtThuePhong.NewRow();
                thuephong[0] = matpmoi;
                thuephong[1] = lbl_MaPH.Text;
                thuephong[2] = MaNV;
                thuephong[3] = txt_SDT.Text;
                thuephong[4] = TGHienTai.ToString("HH:mm"); // gio vao
                thuephong[6] = "Chưa Nhận Phòng";
                thuephong[7] = TGHienTai.ToString("yyyy/MM/dd"); // ngay vao

                dtThuePhong.Rows.Add(thuephong);
                try
                {
                    string sql = "select * from THUEPHONG";
                    db.UpdateData(sql, dtThuePhong);
                    MessageBox.Show("Thue Phong thanh cong");
                    string updatephong = "UPDATE PHONGHAT SET TinhTrang = N'Phòng Đã Đặt'WHERE TenPH=N'" + lbl_TenPhong.Text + "'";
                    try
                    {
                        db.ThemXoaSua(updatephong);
                     //   MessageBox.Show("Set Phong Thanh Cong");
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
            catch (Exception)
            {
                MessageBox.Show("loi~ 403+1");
            }

        }

        public string XuLyTuDongGetMaThuePhong()
        {
            string sql = "SELECT COUNT(DISTINCT MaTP)  as matp FROM THUEPHONG";
            string MATP = "TP_" + demSoLuong(sql, "matp", 1);
           // MessageBox.Show("data:" + MATP);
            return MATP;
        }

        public int demSoLuong(string sql, string table, int SoTang)
        {
            dtSoLuongKH = db.LayDuLieu(sql);
            DataRow sl = dtSoLuongKH.Rows[0];
            int num = Convert.ToInt16(sl[table].ToString());
            return num + SoTang;
        }
        public void Xoa_DataBindings()
        {
            txt_KhachHang.DataBindings.Clear();
            lbl_TenPhong.DataBindings.Clear();
            lbl_MaPH.DataBindings.Clear();
            lbl_GioCD.DataBindings.Clear();
            lbl_GioBT.DataBindings.Clear();
            txt_SDT.DataBindings.Clear();
            txt_giodat.DataBindings.Clear();
            dpk_ngaydat.DataBindings.Clear();

        }
        public void showPhongTrong()
        {
            lst_Phong.Items.Clear();
            dtPhongHat = db.LayDuLieu("select TenPH,TinhTrang from PHONGHAT where TinhTrang = N'Phòng Trống'");
            for (int i = 0; i < dtPhongHat.Rows.Count; i++)
            {
                lsv_Item = lst_Phong.Items.Add(dtPhongHat.Rows[i]["TenPH"].ToString());
                lsv_Item.ImageIndex = 0;
            }
        }
        public void xulyViewData(string TenPhongHat)
        {
            try
            {
                // sua lai cai nay`
                string laydulieu = "select * from PHONGHAT where TinhTrang = N'Phòng Trống' and TenPH = N'" + TenPhongHat + "'";
                dtLayDuLieuPhongHat = db.LayDuLieu(laydulieu);

                DataRow data = dtLayDuLieuPhongHat.Rows[0];

                lbl_TenPhong.Text = data["TenPH"].ToString();
                lbl_GioCD.Text = data["GiaCaoDiem"].ToString();
                lbl_GioBT.Text = data["GiaBinhThuong"].ToString();
                lbl_MaPH.Text = data["MaPH"].ToString();

            }
            catch (Exception)
            {
                // MessageBox.Show("yes");
            }

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Xác Nhận thoat", "thong bao'", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        public bool checkKhachHang(string SDT) // false : chua co khach hang
        {
            string Check_SDT = "SELECT COUNT(*) SDT FROM KHACHHANG WHERE SDT_KH = " + SDT;
            dtSoLuongKH = db.LayDuLieu(Check_SDT);
            DataRow sl = dtSoLuongKH.Rows[0];
            int num = Convert.ToInt16(sl["SDT"].ToString());
            if (num == 0)
                return false;
            return true;
        }
        public void ThemKhachHangMoi(string sdt,string ten)
        {
            dtKhachHang = db.LayDuLieu("select * from KHACHHANG");
            Xoa_DataBindings();
            DataRow newrow = dtKhachHang.NewRow();
            int SDT_KH = int.Parse(sdt);
          //  MessageBox.Show("SDT: " + SDT_KH);
            newrow[0] = SDT_KH;
            newrow[1] = ten;
            newrow[2] = 0;
            dtKhachHang.Rows.Add(newrow);
            try
            {
                // set lai SqlDataAdapter
                string sql = "select * from KHACHHANG";                
                db.UpdateData(sql, dtKhachHang);
            //    MessageBox.Show("Them khach hang thanh cong");
            }
            catch (Exception)
            {
                MessageBox.Show("Loi~ them khach hang");
            }
        }

    }
}
