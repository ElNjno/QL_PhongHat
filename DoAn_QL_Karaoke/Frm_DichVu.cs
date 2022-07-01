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
    public partial class Frm_DichVu : Form
    {
        string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

        XyLyDatabase db = new XyLyDatabase();
        DataTable dtDichVu;
        DataTable dtLayMaDV;
        DataColumn[] keyDV = new DataColumn[1];
        public Frm_DichVu()
        {
            InitializeComponent();
        }

        private void DichVu_Load(object sender, EventArgs e)
        {
            btn_Luu.Visible = false;
            btnluu.Visible = false;


            dtDichVu = db.LayDuLieu("Select * from DichVu");
            keyDV[0] = dtDichVu.Columns[0];
            dtDichVu.PrimaryKey = keyDV;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dtDichVu;
            dataGridView1.Columns[0].DataPropertyName = "MADV";
            dataGridView1.Columns[1].DataPropertyName = "TENDV";
            dataGridView1.Columns[2].DataPropertyName = "DonGia";
            dataGridView1.Columns[3].DataPropertyName = "DonViTinh";
            DichVu_Databiding();
        }
        void DichVu_Databiding()
        {
            txt_TenDV.DataBindings.Add("Text", dtDichVu, "TENDV");
            txt_DonGia.DataBindings.Add("Text", dtDichVu, "DonGia");
            txt_DVT.DataBindings.Add("Text", dtDichVu, "DonViTinh");
            txt_TenDV.Enabled = false;
            txt_DonGia.Enabled = false;
            txt_DVT.Enabled = false;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            txt_TenDV.DataBindings.Clear();
            txt_DonGia.DataBindings.Clear();
            txt_DVT.DataBindings.Clear();
            txt_TenDV.Clear();
            txt_DonGia.Clear();
            txt_DVT.Clear();
            btn_Luu.Enabled = true;
            btn_Luu.Visible = true;
            btn_Sua.Enabled = btn_Xoa.Enabled = false;
            txt_TenDV.Enabled = true;
            txt_DonGia.Enabled = true;
            txt_DVT.Enabled = true;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        public int checkDuLieuNhap()
        {
            if (txt_DonGia.Text == "" || txt_DVT.Text == "" || txt_TenDV.Text == "")
            {
                return 0;
            }
            return 1;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (checkDuLieuNhap() == 1)
            {

                string SetMaDV = " select count(*)+1 a from DICHVU";
                dtLayMaDV = db.LayDuLieu(SetMaDV);
                int num;
                DataRow sl = dtLayMaDV.Rows[0];

                num = Convert.ToInt16(sl["a"].ToString());
                //  MessageBox.Show("asda" +num);

                string laymadv = "DV_" + num;



                DataRow newrow = dtDichVu.NewRow();
                //  newrow[0] = laymadv;
                newrow[0] = laymadv;
                newrow[1] = txt_TenDV.Text;
                newrow[2] = txt_DonGia.Text;
                newrow[3] = txt_DVT.Text;

                dtDichVu.Rows.Add(newrow);
                DichVu_Databiding();
                btn_Luu.Enabled = false;
                btn_Them.Enabled = btn_Sua.Enabled = btn_Xoa.Enabled = true;
                txt_TenDV.Clear();
                txt_DonGia.Clear();
                txt_DVT.Clear();
                try
                {
                    string sql = "select * from DichVu";
                    db.UpdateData(sql, dtDichVu);
                    MessageBox.Show("succsess");
                    txt_TenDV.DataBindings.Clear();
                    txt_DonGia.DataBindings.Clear();
                    txt_DVT.DataBindings.Clear();
                    txt_TenDV.Clear();
                    txt_DonGia.Clear();
                    txt_DVT.Clear();
                    btn_Luu.Enabled = false;
                    btn_Luu.Visible = false;
                    DichVu_Databiding();
                }
                catch (Exception)
                {
                    MessageBox.Show("Loi~");
                }
            }
        }

        private void txt_DonGia_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban Co Muon Xoa Khong", "Canh Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                    // set lai cells cho dung' ten mon'
                    string tenmon = Convert.ToString(selectedRow.Cells[0].Value);
                    //   MessageBox.Show("data: " + tenmon);
                    DialogResult dialogResult = MessageBox.Show("Xác Nhận Hủy DV: " + tenmon, "Thong Bao", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                            {
                                dataGridView1.Rows.RemoveAt(item.Index);
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Loi Huy Mon !");
                        }

                    }
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = true;

            txt_TenDV.Enabled = true;
            txt_DonGia.Enabled = true;
            txt_DVT.Enabled = true;
            btnluu.Enabled = true;
            btnluu.Visible = true;
           btn_Them.Enabled= btn_Sua.Enabled = btn_Xoa.Enabled = false;
          //  txt_TenDV.Enabled = true;
            txt_DonGia.Enabled = true;
        //    txt_DVT.Enabled = true;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();

            DataTable dtKhoa;
            string sql = "select * from DICHVU";
            dtKhoa = db.LayDuLieu(sql);

            try
            {
                db.UpdateData("select * from DICHVU", dtKhoa);
                MessageBox.Show("Cập nhật thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txt_DVT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
