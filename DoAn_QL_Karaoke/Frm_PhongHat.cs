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
    public partial class Frm_PhongHat : Form
    {
        public Frm_PhongHat()
        {
            InitializeComponent();
        }
        XyLyDatabase db = new XyLyDatabase();
        DataTable dsPhonhHat, dtLayMaPH;
        DataColumn[] keyPhongHat = new DataColumn[1];
        int xuly = 0;

        private void Frm_PhongHat_Load(object sender, EventArgs e)
        {
            string sql = "select * from PHONGHAT";
            dsPhonhHat = db.LayDuLieu(sql);
            keyPhongHat[0] = dsPhonhHat.Columns[0];
            dsPhonhHat.PrimaryKey = keyPhongHat;
            Dgv_DSPhong.AutoGenerateColumns = false;
            Dgv_DSPhong.DataSource = dsPhonhHat;
            Dgv_DSPhong.Columns[0].DataPropertyName = "MaPH";
            Dgv_DSPhong.Columns[1].DataPropertyName = "TenPH";
            Dgv_DSPhong.Columns[2].DataPropertyName = "GiaCaoDiem";
            Dgv_DSPhong.Columns[3].DataPropertyName = "GiaBinhThuong";
            Dgv_DSPhong.Columns[4].DataPropertyName = "TinhTrang";

            Phonghat_Databiding();
            cbTrangThai.Items.Add("Phòng Trống");
            cbTrangThai.Items.Add("Phòng đang sửa");
            txtTenPhong.Enabled = txt_caoDiem.Enabled = txt_BinhThuong.Enabled = cbTrangThai.Enabled = false;
            btn_Luu.Visible = false;
            btn_Luu.Enabled = false;
        }
        void Phonghat_Databiding()
        {
            txtTenPhong.DataBindings.Add("Text", dsPhonhHat, "TenPH");
            txt_caoDiem.DataBindings.Add("Text", dsPhonhHat, "GiaCaoDiem");
            txt_BinhThuong.DataBindings.Add("Text", dsPhonhHat, "GiaBinhThuong");
            cbTrangThai.DataBindings.Add("Text", dsPhonhHat, "TinhTrang");
        }
        public int checkDuLieuNhap()
        {
            if (txtTenPhong.Text == "" || txt_caoDiem.Text == "" || txt_BinhThuong.Text == "" || cbTrangThai.Text == "")
            {
                MessageBox.Show("nhap du thong tin nhe");
                return 0;
            }
            return 1;
        }
        private void btn_Them_Click(object sender, EventArgs e)

        {
            xuly = 1;

            txt_caoDiem.DataBindings.Clear();
            txt_BinhThuong.DataBindings.Clear();
            txtTenPhong.DataBindings.Clear();
            cbTrangThai.DataBindings.Clear();
            txtTenPhong.Clear();

            txt_caoDiem.Clear();
            txt_BinhThuong.Clear();
            cbTrangThai.Text = "";
            txtTenPhong.Enabled = txt_caoDiem.Enabled = txt_BinhThuong.Enabled = cbTrangThai.Enabled = true;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_Luu.Visible = true;
            btn_Luu.Enabled = true;

        }
        private void btn_Xoa_Click(object sender, EventArgs e)

        {
            if (MessageBox.Show("Ban Co Muon Xoa Khong", "Canh Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // check khoa ngoai
                DataTable dtSV = null;
                dtSV = db.LayDuLieu("Select distinct MAPH from PhongHat where MAPH='" + getmaPH(txtTenPhong.Text) + "'");

                DataRow r = dsPhonhHat.Rows.Find(getmaPH(txtTenPhong.Text));
                if (r != null)
                {
                    r.Delete();
                }
            }
            string data = "select MaPH,TenPH,GiaCaoDiem,GiaBinhThuong,TinhTrang from PHONGHAT";
            db.UpdateData(data, dsPhonhHat);
            MessageBox.Show("succsess");
        }
        private void btn_Sua_Click(object sender, EventArgs e)

        {
            btn_Luu.Visible = true;
            btn_Luu.Enabled = txtTenPhong.Enabled = txt_caoDiem.Enabled = txt_BinhThuong.Enabled = cbTrangThai.Enabled = true;
            btn_Them.Enabled = btn_Xoa.Enabled = false;
            Dgv_DSPhong.ReadOnly = true;
            xuly = 0;
        }
        private void btn_Luu_Click(object sender, EventArgs e)

        {
            if (xuly == 1)
            {
                if (checkDuLieuNhap() == 1)
                {
                    string SetMaDV = " select count(*)+1 a from PhongHat";
                    dtLayMaPH = db.LayDuLieu(SetMaDV);
                    int num;
                    DataRow sl = dtLayMaPH.Rows[0];

                    num = Convert.ToInt16(sl["a"].ToString());

                    string MaPH = "PH_" + num;
                    DataRow newrow = dsPhonhHat.NewRow();
                    newrow[0] = MaPH;
                    newrow[1] = txtTenPhong.Text;
                    newrow[2] = txt_caoDiem.Text;
                    newrow[3] = txt_BinhThuong.Text;
                    newrow[4] = cbTrangThai.Text;
                    try
                    {
                        dsPhonhHat.Rows.Add(newrow);
                        string sql = "select * from PhongHat";
                        db.UpdateData(sql, dsPhonhHat);
                        MessageBox.Show("succsess");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("cập nhật dữ liệu THấT BạI");
                        throw;
                    }
                    Phonghat_Databiding();
                }
                else
                {
                    MessageBox.Show("loi roi");
                    Phonghat_Databiding();
                }

            }
            else
            {
                Dgv_DSPhong.Refresh();

                MessageBox.Show("succsess");
                try
                {
                    // set lai SqlDataAdapter
                    string sql = "update phonghat set TenPH = '" + txtTenPhong.Text + "', Giacaodiem =" + float.Parse(txt_caoDiem.Text) + ",GiaBinhThuong=" + float.Parse(txt_BinhThuong.Text) + ",TinhTrang = '" + cbTrangThai.Text + "' where MaPH = '" + getmaPH(txtTenPhong.Text).ToString() + "'";
                    db.UpdateData(sql, dsPhonhHat);
                    MessageBox.Show("succsess");
                }
                catch (Exception)
                {
                    MessageBox.Show("Loi~");
                }

            }

            //Phonghat_Databiding();
            btn_Them.Enabled = btn_Sua.Enabled = btn_Xoa.Enabled = true;
            txtTenPhong.Enabled = txt_caoDiem.Enabled = txt_BinhThuong.Enabled = cbTrangThai.Enabled = false;
            btn_Luu.Enabled = false;
            btn_Luu.Visible = false;
        }

        private void Dgv_DSPhong_CellClick(object sender, DataGridViewCellEventArgs e)

        {

        }

        public string getmaPH(string tenPH)
        {
            string sql = string.Format(@"select * from PhongHat Where TenPH = N'{0}'", tenPH);
            dtLayMaPH = db.LayDuLieu(sql);
            DataRow getma = dtLayMaPH.Rows[0];
            string maph = getma["MaPH"].ToString();
            return maph;
        }

    }
}
