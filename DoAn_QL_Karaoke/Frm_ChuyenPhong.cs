using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QL_Karaoke
{
    public partial class Frm_ChuyenPhong : Form
    {

        string GetMaTP;
        string GetTenPH;
        string MaNV;
        string GetMaPH;
        int loi = 0;
        XyLyDatabase db = new XyLyDatabase();
        DataTable dtPhongHat, dtLayDuLieuPhongHat;
        DataTable dtGetMaPH,dtSDT_KhachHang;
        DataColumn[] keyKhachHang = new DataColumn[1];
        DateTime TGHienTai = DateTime.Now;
        ListViewItem lsv_Item;
        public Frm_ChuyenPhong(string MaTP,string TenPH,string manhanv)
        {            
            InitializeComponent();
            GetMaTP = MaTP;
            GetTenPH = TenPH;
            MaNV = manhanv;
            GetMaPH = getMaPhongHat(GetTenPH);
          //  MessageBox.Show(""+ GetMaPH);
        }

        private void lst_Phong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Frm_ChuyenPhong_Load(object sender, EventArgs e)
        {
            showPhongTrong();
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

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {

            GetMaPH = getMaPhongHat(GetTenPH);

            if (lbl_MaPH.Text != "")
            {
                try
                {
                    // xử lý chọn phòng mới cho khách     // update phong hat khach hang chuyen vao thanh da cho thue
                    XuLyTablePhongMoi(GetMaTP, GetMaPH);
                    if (loi != 1)
                    {                  
                        //  --  Phong Hat
                           // chuuyển tình trạng phòng cũ thành trống  
                        XuLyTablePhongHat(GetMaPH);
                        // --   Thue Phong
                        // giờ ra của phòng cũ băng giờ hiện tại - Tinh trang trong table Thue Phong : CP_ChuaThanhToan
                        XuLyTableThuePhong(GetMaTP, GetMaPH);
                        // -- Thue Phong
                        MessageBox.Show("Chuyen Phong Thanh Cong");

                        Main formmain = new Main(MaNV);
                        Frm_NhanDatPhong FrmDP = new Frm_NhanDatPhong(MaNV);
                        formmain.Visible = true;
                        FrmDP.MdiParent = Main.ActiveForm;
                        FrmDP.Show();

                    }
                    else
                    {
                        MessageBox.Show("Phong Khach Da Tung thue roi");

                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Ét O Ét :(");
                }
            }
            else MessageBox.Show("Vui Long Chon Phong Hat Moi");

        }

        private void lst_Phong_Click(object sender, EventArgs e)
        {
        //    xoadulieu();
            lbl_TenPhong.Text = lst_Phong.SelectedItems[0].SubItems[0].Text;
            xulyViewData(lbl_TenPhong.Text);
        }

        public void xulyViewData(string TenPhongHat)
        {

            try
            {
                // sua lai cai nay`
                string laydulieu = "select * from PHONGHAT where TinhTrang = N'Phòng Trống' and TenPH = N'"+TenPhongHat+"'";
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

        public void XuLyTableThuePhong(string matp,string maph)
        {
            string TgTraPhong = TGHienTai.ToString("HH:mm");
            string giora = string.Format("UPDATE THUEPHONG SET GioRa = '{0}' WHERE MaTP ='{1}' and MaPH = '{2}'", TgTraPhong, matp, maph);
            string tinhtrang = string.Format("UPDATE THUEPHONG SET TinhTrang = N'CP_ChuaThanhToan' WHERE MaTP ='{0}' and MaPH = '{1}'", matp, maph);
            try
            {
                db.ThemXoaSua(giora);
                db.ThemXoaSua(tinhtrang);
            }
            catch (Exception)
            {
                MessageBox.Show("Loi~ XuLyTableThuePhong");
            }
        }
        public void XuLyTablePhongHat(string maph)
        {
            string sql = string.Format(@"UPDATE PHONGHAT SET TinhTrang = N'Phòng Trống' where MaPH='{0}'", maph);
            //MessageBox.Show("sql: "+sql);
            try
            {
                db.ThemXoaSua(sql);
                //MessageBox.Show("Chuyen Trang Thai Phong Hat Thanh Cong");
            }
            catch (Exception)
            {
                MessageBox.Show("Loi~ XuLyTablePhongHat");
            }
        }

        //public string 

        public bool checkDauVao()
        {
            if (lbl_MaPH.Text.Length==0)
            {
                return false;
            }
            return true;
        }
        public void XuLyTablePhongMoi(string matp, string maph)
        {
            // chon phong hat
            if (checkDauVao())
            {
                addcolumn(GetMaTP, lbl_MaPH.Text);
                if (loi==0)
                {
                    updateTinhTrangPhong(lbl_MaPH.Text);
                }
            }
            else
            {
                MessageBox.Show("Vui Long Chon Phong Hat Moi");
            }
        }
        public string getMaPhongHat(string tenPh)
        {
            string sql = string.Format(@"select MaPH from PHONGHAT where TenPH=N'{0}'", tenPh);
            dtGetMaPH = db.LayDuLieu(sql);
            DataRow getma = dtGetMaPH.Rows[0];
            string maph = getma["MaPH"].ToString();
            //  int num = Convert.ToInt16(sl[table].ToString());
            return maph;
        }
        public int getSDTKhachHang(string matp, string maph)
        {
            string sql = string.Format(@"select SDT_KH from THUEPHONG where MaPH ='{0}' and MaTP = '{1}'", maph, matp);
            dtSDT_KhachHang = db.LayDuLieu(sql);
            DataRow getma = dtSDT_KhachHang.Rows[0];
            int SDT = Convert.ToInt16(getma["SDT_KH"].ToString());
            return SDT;
        }

        public int getSDTKhachHang(string matp)
        {
            string sql = string.Format(@"select SDT_KH from THUEPHONG where  MaTP = '{0}'", matp);
            dtSDT_KhachHang = db.LayDuLieu(sql);
            DataRow getma = dtSDT_KhachHang.Rows[0];
            int SDT = Convert.ToInt32(getma["SDT_KH"].ToString());
            return SDT;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
    
            this.Close();
        }

        public void addcolumn(string MaTP, string MaPH)
        {
            int SDT = getSDTKhachHang(MaTP);
            string GioVao = TGHienTai.ToString("HH:mm");
            string NgayVao = TGHienTai.ToString("MM/dd/yyyy");
            string sql = string.Format(@"INSERT INTO THUEPHONG(MaTP,MaPH,SDT_KH,NgayVao,GioVao,TinhTrang,MaNV) VALUES ('{0}','{1}',{2},'{3}','{4}',N'Đã Nhận Phòng','{5}');", MaTP,MaPH,SDT,NgayVao,GioVao,MaNV);
            // MessageBox.Show("sql: " +sql);
            try
            {
                db.ThemXoaSua(sql);
                //  MessageBox.Show("Success");
                loi = 0;
            }
            catch (Exception)
            {
                loi = 1;
               // MessageBox.Show("Loi~ add");
            }
        }

        public void updateTinhTrangPhong(string MaPH)
        {
            string updatephong = "UPDATE PHONGHAT SET TinhTrang = N'Phòng Có Khách'WHERE MaPH='" + MaPH + "'";
            try
            {
                db.ThemXoaSua(updatephong);
            }
            catch (Exception)
            {
                MessageBox.Show("Loi~ add column");
            }
        }

    }
}
