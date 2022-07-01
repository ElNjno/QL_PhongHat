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
    public partial class Frm_DangNhap : Form
    {
        XyLyDatabase kn = new XyLyDatabase();
        public static string ChucVu = "";
        public static string Ten = "";
        public static string MaNV = "";
        public Frm_DangNhap()
        {
            InitializeComponent();
        }

        private void Frm_DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)

        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnDN_Click(object sender, EventArgs e)

        {
            DataTable dt = null;
            dt = kn.LayDuLieu("Select * from NhanVien where  SDT = '" + txtuser.Text + "' and  Pass = '" + txtpass.Text + "'");
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    ChucVu = dr["ChucVu"].ToString();
                    Ten = dr["TenNV"].ToString();
                    MaNV = dr["MaNV"].ToString();
                }
                MessageBox.Show("Xin chào " + Ten + "! Bạn đã đăng nhập thành công!", "Thông báo");

                Main formmain = new Main(MaNV);
                Frm_NhanDatPhong FrmDP = new Frm_NhanDatPhong(MaNV);
                formmain.Visible = true;
                FrmDP.MdiParent = Main.ActiveForm;
                FrmDP.Show();
               // this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công!", "Thông báo");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtpass.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
            }
            else
            {
                txtpass.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
            }

        }
    }
}
