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
    public partial class Frm_NhaSanXuat : Form
    {
        XyLyDatabase db = new XyLyDatabase();
        DataTable dsNhaCungCap, dtLayMaNCC;
        DataColumn[] keyNCC = new DataColumn[1];
        int xuly = 0;
        public Frm_NhaSanXuat()
        {
            InitializeComponent();
        }

        private void Frm_NhaSanXuat_Load(object sender, EventArgs e)
        {

            {
                string sql = "select * from NhaCungCap";
                dsNhaCungCap = db.LayDuLieu(sql);
                keyNCC[0] = dsNhaCungCap.Columns[0];
                dsNhaCungCap.PrimaryKey = keyNCC;
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dsNhaCungCap;
                dataGridView1.Columns[0].DataPropertyName = "MaNCC";
                dataGridView1.Columns[1].DataPropertyName = "TenNCC";
                dataGridView1.Columns[2].DataPropertyName = "DiaChi";
                dataGridView1.Columns[3].DataPropertyName = "SDT";

                txt_TenNCC.Enabled = txt_SDT.Enabled = txt_DiaChi.Enabled = false;
                NCC_Databiding();

                btn_Luu.Visible = false;
                btn_Luu.Enabled = false;
            }
        }
        void NCC_Databiding()
        {
            txt_TenNCC.DataBindings.Add("Text", dsNhaCungCap, "TenNCC");
            txt_DiaChi.DataBindings.Add("Text", dsNhaCungCap, "DiaChi");
            txt_SDT.DataBindings.Add("Text", dsNhaCungCap, "SDT");

        }
        public int checkDuLieuNhap()
        {
            if (txt_TenNCC.Text == "" || txt_DiaChi.Text == "" || txt_SDT.Text == "")
            {
                MessageBox.Show("nhap du thong tin nhe");
                return 0;
            }
            return 1;
        }

        private void btn_Them_Click(object sender, EventArgs e)

        {
            xuly = 1;

            txt_DiaChi.DataBindings.Clear();
            txt_SDT.DataBindings.Clear();
            txt_TenNCC.DataBindings.Clear();

            txt_TenNCC.Clear();

            txt_SDT.Clear();
            txt_DiaChi.Clear();

            txt_TenNCC.Enabled = txt_SDT.Enabled = txt_DiaChi.Enabled = true;
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
                dtSV = db.LayDuLieu("Select distinct MaNCC from NhaCungCap where TenNCC='" + getmaNCC(txt_TenNCC.Text) + "'");

                DataRow r = dsNhaCungCap.Rows.Find(getmaNCC(txt_TenNCC.Text));
                if (r != null)
                {
                    r.Delete();
                }
            }
            string data = "select * from NhaCungCap";
            db.UpdateData(data, dsNhaCungCap);
            MessageBox.Show("succsess");
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {

            {
                if (xuly == 1)
                {
                    if (checkDuLieuNhap() == 1)
                    {
                        string SetMaDV = " select count(*)+1 a from NhaCungCap";
                        dtLayMaNCC = db.LayDuLieu(SetMaDV);
                        int num;
                        DataRow sl = dtLayMaNCC.Rows[0];

                        num = Convert.ToInt16(sl["a"].ToString());

                        string MaNCC = "NCC_" + num;
                        DataRow newrow = dsNhaCungCap.NewRow();
                        newrow[0] = MaNCC;
                        newrow[1] = txt_TenNCC.Text;
                        newrow[2] = txt_DiaChi.Text;
                        newrow[3] = txt_SDT.Text;

                        try
                        {
                            dsNhaCungCap.Rows.Add(newrow);
                            string sql = "select * from NhaCungCap";
                            db.UpdateData(sql, dsNhaCungCap);
                            MessageBox.Show("succsess");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("cập nhật dữ liệu THấT BạI");
                            throw;
                        }
                        NCC_Databiding();
                    }
                    else
                    {
                        MessageBox.Show("loi roi");
                        NCC_Databiding();
                    }

                }
                else
                {
                    dataGridView1.Refresh();

                    MessageBox.Show("succsess");
                    try
                    {
                        // set lai SqlDataAdapter
                        string sql = "select * from NhaCungCap";
                        db.UpdateData(sql, dsNhaCungCap);
                        MessageBox.Show("succsess");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Loi~");
                    }

                }


                btn_Them.Enabled = btn_Sua.Enabled = btn_Xoa.Enabled = true;
                txt_TenNCC.Enabled = txt_SDT.Enabled = txt_DiaChi.Enabled = false;
                btn_Luu.Enabled = false;
                btn_Luu.Visible = false;
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            btn_Luu.Visible = true;
            btn_Luu.Enabled = txt_TenNCC.Enabled = txt_DiaChi.Enabled = txt_SDT.Enabled = true;
            btn_Them.Enabled = btn_Xoa.Enabled = false;
            dataGridView1.ReadOnly = true;
            xuly = 0;
        }

        public string getmaNCC(string tenNCC)
        {
            string sql = string.Format(@"select * from NhaCungCap Where TenNCC = N'{0}'", tenNCC);
            dtLayMaNCC = db.LayDuLieu(sql);
            DataRow getma = dtLayMaNCC.Rows[0];
            string mancc = getma["MaNCC"].ToString();
            return mancc;
        }
    }
}
