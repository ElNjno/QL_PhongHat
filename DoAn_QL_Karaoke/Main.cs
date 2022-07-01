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
    public partial class Main : Form
    {
        private int childFormNumber = 0;
        string MaNV = Frm_DangNhap.MaNV;
        DataTable dataDN;
        XyLyDatabase db = new XyLyDatabase();

        public Main(string Macuanhanvien)
        {
            MaNV = Macuanhanvien;
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        public void Admin(bool mo)
        {
            đăngNhâpToolStripMenuItem.Enabled = !mo;
            đăngXuấtToolStripMenuItem.Enabled = mo;
            đặtPhòngOnlineToolStripMenuItem.Enabled = mo;
            dịchVụToolStripMenuItem.Enabled = mo;
            nhậnĐặtPhòngToolStripMenuItem.Enabled = mo;
            phòngHátToolStripMenuItem.Enabled = mo;
            thốngKêDoanhThuToolStripMenuItem.Enabled = mo;
            thốngKêNguyênVậtLiệuToolStripMenuItem.Enabled = mo;
            thốngKêTheoNgàyToolStripMenuItem.Enabled = mo;
            nhàSánXuấtToolStripMenuItem.Enabled = mo;
            nhậpNguyênVậtLiệuToolStripMenuItem.Enabled = mo;
            nguyênVậtLiệuToolStripMenuItem.Visible = true;
            thốngKêTheoNgàyToolStripMenuItem.Visible = true;
            thốngKêToolStripMenuItem.Visible = true;
        }

        public void nhanvien(bool mo)
        {
            đặtPhòngOnlineToolStripMenuItem.Enabled = mo;
            nhậnĐặtPhòngToolStripMenuItem.Enabled = mo;
            đăngNhâpToolStripMenuItem.Enabled = !mo;
            đăngXuấtToolStripMenuItem.Enabled = mo;

            nguyênVậtLiệuToolStripMenuItem.Visible = false;
            thốngKêTheoNgàyToolStripMenuItem.Visible = false;
            thốngKêToolStripMenuItem.Visible = false;
        }
        private void test_Load(object sender, EventArgs e)
        {
            string chucvu = "select ChucVu from NHANVIEN where MaNV = '" + MaNV + "'";
            dataDN = db.LayDuLieu(chucvu);
            DataRow data = dataDN.Rows[0];
            string matphong = data["ChucVu"].ToString();
            if (matphong == "Quản lý")
            {
                //MessageBox.Show("QL");
                Admin(true);
            }
            else if (matphong == "Nhân viên")
            {
               // MessageBox.Show("NV");
                Admin(false);
                nhanvien(true);
            }
            //TrangThai(Frm_DangNhap.flat);


            string[] smangNgay = { "Chủ Nhật", "Thứ Hai", "Thứ Ba", "Thứ Tư", "Thứ Năm", "Thứ Sáu", "Thứ Bảy" };
            int ingay = DateTime.Now.DayOfWeek.GetHashCode();
            Lbl_HomNay.Text = Lbl_HomNay.Text + smangNgay[ingay].ToString() + " Ngày " + DateTime.Today.Day.ToString()
                + " Tháng " + DateTime.Today.Month.ToString() + " Năm " + DateTime.Today.Year.ToString();
            Lbl_HomNay.Text = Lbl_HomNay.Text + "__" + Frm_DangNhap.ChucVu + "__" + Frm_DangNhap.Ten;

            //đăngNhâpToolStripMenuItem_Click(sender, e);
        }

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DichVu FrmDP = new Frm_DichVu();
            FrmDP.ShowDialog();
        }

        private void nhậnĐặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string manhaann = Frm_DangNhap.MaNV;
            Frm_NhanDatPhong FrmDP = new Frm_NhanDatPhong(manhaann);
            FrmDP.MdiParent = this;
            FrmDP.Show();            
        }

        private void đăngNhâpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DangNhap FrmDNhap = new Frm_DangNhap();
            FrmDNhap.ShowDialog();
            Lbl_HomNay.Text = Lbl_HomNay.Text + "__" + Frm_DangNhap.ChucVu + "__" + Frm_DangNhap.Ten;
            if (Frm_DangNhap.ChucVu == "Quản lý")
            {
                Admin(true);
            }
            else if (Frm_DangNhap.ChucVu == "Nhân viên")
            {
                nhanvien(true);
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đặtPhòngOnlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string manhaann = Frm_DangNhap.MaNV;
            Frm_DatPhongOnline FrmDP = new Frm_DatPhongOnline(manhaann);
            FrmDP.ShowDialog();
        }

        private void thôngTinTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ThongTin FrmDP = new Frm_ThongTin();
            FrmDP.ShowDialog();
        }

        private void thốngKêDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ThongKeDoanhThu FrmDP = new Frm_ThongKeDoanhThu();
            FrmDP.MdiParent = this;
            FrmDP.Show();
        }

        private void thốngKêNguyênVậtLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ThongKeVatLieu FrmDP = new Frm_ThongKeVatLieu();
            FrmDP.MdiParent = this;
            FrmDP.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dang Xuat Thanh Cong");
            Frm_DangNhap maina = new Frm_DangNhap();
            maina.Show();
        }

        private void nhậpNguyênVậtLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_NhapHang FrmDP = new Frm_NhapHang();
            FrmDP.MdiParent = this;
            FrmDP.Show();
        }

        private void nhàSánXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_NhaSanXuat a = new Frm_NhaSanXuat();
            a.Show();
        }

        private void phòngHátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_PhongHat a = new Frm_PhongHat();
            a.Show();
        }

        private void nguyênVậtLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thốngKêTheoNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
