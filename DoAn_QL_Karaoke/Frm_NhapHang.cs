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
    public partial class Frm_NhapHang : Form
    {
        XyLyDatabase db = new XyLyDatabase();
        DataTable dtLayDuLieuDVSapHet, dtLayDuLieuDVHet, dtdichvu;
        DataTable dtNCC, dtPhieuNhap, dtLayMaPN, dtChiTietPhieuNhap;
        DataTable dtGetMaDV;
        DateTime TGHienTai = DateTime.Now;
        ListViewItem lsv_Item;
        string MaNCC = "";

        private void lst_DichVu_Click(object sender, EventArgs e)
        {
            txt_TenDV.Text = lst_DichVu.SelectedItems[0].SubItems[0].Text;

        }

        private void btn_taoPN_Click(object sender, EventArgs e)
        {
            if (cb_NCC.Text == "")
            {
                MessageBox.Show("nhập nhà cung cấp nhé");
            }
            else
            {
                trangThaiThongTin(true);
                btn_ChonVatLieu.Enabled = true;
                taoPhieuNhap();
                btn_taoPN.Enabled = false;
                cb_NCC.Enabled = false;
                txt_TenNCC.Text = cb_NCC.Text;
                txt_tenNV.Text = Frm_DangNhap.Ten;
                cb_NCC.Text = "";
            }
        }
        public void DichVuSapHet()
        {
            dataGridView1.AutoGenerateColumns = false;
            dtLayDuLieuDVSapHet = db.LayDuLieu("select * from DICHVU where SLTon > 0 and SLTon <=30");
            dataGridView1.DataSource = dtLayDuLieuDVSapHet;
            dataGridView1.Columns[0].DataPropertyName = "MaDV";
            dataGridView1.Columns[1].DataPropertyName = "TenDV";
            dataGridView1.Columns[2].DataPropertyName = "DonGia";
            dataGridView1.Columns[3].DataPropertyName = "DonViTinh";
            dataGridView1.Columns[4].DataPropertyName = "SLTon";
        }
        public void DichVuHet()
        {
            dataGridView2.AutoGenerateColumns = false;
            dtLayDuLieuDVHet = db.LayDuLieu("select * from DICHVU where SLTon = 0");
            dataGridView2.DataSource = dtLayDuLieuDVHet;
            dataGridView2.Columns[0].DataPropertyName = "MaDV";
            dataGridView2.Columns[1].DataPropertyName = "TenDV";
            dataGridView2.Columns[2].DataPropertyName = "DonGia";
            dataGridView2.Columns[3].DataPropertyName = "DonViTinh";
            dataGridView2.Columns[4].DataPropertyName = "SLTon";
        }

        public void NhaCungCap()
        {
            dtNCC = db.LayDuLieu("select * from NhaCungCap");
            cb_NCC.DataSource = dtNCC;
            cb_NCC.DisplayMember = "TenNCC";
            cb_NCC.ValueMember = "MaNCC";
            MaNCC = cb_NCC.SelectedValue.ToString();
        }
        public void ShowListViewDichVu()
        {
            lst_DichVu.Items.Clear();
            dtdichvu = db.LayDuLieu("select * from DICHVU");
            for (int i = 0; i < dtdichvu.Rows.Count; i++)
            {
                if (dtdichvu.Rows[i]["TenDV"].ToString().ToLower() == "coca".ToLower())
                {
                    lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                    lsv_Item.ImageIndex = 0;
                }
                if (dtdichvu.Rows[i]["TenDV"].ToString().ToLower() == "Bí đao".ToLower())
                {

                    lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                    lsv_Item.ImageIndex = 1;

                }
                if (dtdichvu.Rows[i]["TenDV"].ToString().ToLower() == "bia Heineken".ToLower())
                {

                    lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                    lsv_Item.ImageIndex = 2;

                }
                if (dtdichvu.Rows[i]["TenDV"].ToString().ToLower() == "Nước cam ".ToLower())
                {

                    lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                    lsv_Item.ImageIndex = 3;

                }
                if (dtdichvu.Rows[i]["TenDV"].ToString().ToLower() == "nước lọc".ToLower())
                {

                    lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                    lsv_Item.ImageIndex = 4;

                }
                if (dtdichvu.Rows[i]["TenDV"].ToString().ToLower() == "pepsi".ToLower())
                {

                    lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                    lsv_Item.ImageIndex = 5;

                }
                if (dtdichvu.Rows[i]["TenDV"].ToString().ToLower() == "redbull".ToLower())
                {

                    lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                    lsv_Item.ImageIndex = 6;

                }
                if (dtdichvu.Rows[i]["TenDV"].ToString().ToLower() == "bia sài gòn".ToLower())
                {

                    lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                    lsv_Item.ImageIndex = 7;

                }
                if (dtdichvu.Rows[i]["TenDV"].ToString().ToLower() == "Sting".ToLower())
                {

                    lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                    lsv_Item.ImageIndex = 8;

                }
                if (dtdichvu.Rows[i]["TenDV"].ToString().ToLower() == "Bia tiger".ToLower())
                {
                    lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                    lsv_Item.ImageIndex = 9;
                }

            }
        }

        public void showPhongTheoRadio()
        {
            lst_DichVu.Items.Clear();
            dtdichvu = db.LayDuLieu("select * from DICHVU");
            for (int i = 0; i < dtdichvu.Rows.Count; i++)
            {
                if (radio_SapHet.Checked == true)
                {
                    if (int.Parse(dtdichvu.Rows[i]["SLTon"].ToString()) > 0 && int.Parse(dtdichvu.Rows[i]["SLTon"].ToString()) <= 30)
                    {
                        if (dtdichvu.Rows[i]["TenDV"].ToString().ToLower() == "coca".ToLower())
                        {
                            lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                            lsv_Item.ImageIndex = 0;
                        }
                        if (dtdichvu.Rows[i]["TenDV"].ToString().ToLower() == "Bí đao".ToLower())
                        {

                            lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                            lsv_Item.ImageIndex = 1;

                        }
                        if (dtdichvu.Rows[i]["TenDV"].ToString().ToLower() == "bia Heineken".ToLower())
                        {

                            lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                            lsv_Item.ImageIndex = 2;

                        }
                        if (dtdichvu.Rows[i]["TenDV"].ToString().ToLower() == "Nước Cam".ToLower())
                        {

                            lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                            lsv_Item.ImageIndex = 3;

                        }
                        if (dtdichvu.Rows[i]["TenDV"].ToString().ToLower() == "nước lọc".ToLower())
                        {

                            lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                            lsv_Item.ImageIndex = 4;

                        }
                        if (dtdichvu.Rows[i]["TenDV"].ToString().ToLower() == "pepsi".ToLower())
                        {

                            lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                            lsv_Item.ImageIndex = 5;

                        }
                        if (dtdichvu.Rows[i]["TenDV"].ToString().ToLower() == "redbull".ToLower())
                        {

                            lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                            lsv_Item.ImageIndex = 6;

                        }
                        if (dtdichvu.Rows[i]["TenDV"].ToString().ToLower() == "bia sài gòn".ToLower())
                        {

                            lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                            lsv_Item.ImageIndex = 7;

                        }
                        if (dtdichvu.Rows[i]["TenDV"].ToString().ToLower() == "Sting".ToLower())
                        {

                            lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                            lsv_Item.ImageIndex = 8;

                        }
                        if (dtdichvu.Rows[i]["TenDV"].ToString().ToLower() == "Bia tiger".ToLower())
                        {
                            lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                            lsv_Item.ImageIndex = 9;
                        }
                    }
                }
                if (radio_Het.Checked == true && int.Parse(dtdichvu.Rows[i]["SLTon"].ToString()) == 0)
                {
                    if (dtdichvu.Rows[i]["TenDV"].ToString().ToLower() == "coca".ToLower())
                    {
                        lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                        lsv_Item.ImageIndex = 0;
                    }
                    if (dtdichvu.Rows[i]["TenDV"].ToString().ToLower() == "Bí đao".ToLower())
                    {

                        lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                        lsv_Item.ImageIndex = 1;

                    }
                    if (dtdichvu.Rows[i]["TenDV"].ToString().ToLower() == "bia Heineken".ToLower())
                    {

                        lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                        lsv_Item.ImageIndex = 2;

                    }
                    if (dtdichvu.Rows[i]["TenDV"].ToString().ToLower() == "Nước cam ".ToLower())
                    {

                        lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                        lsv_Item.ImageIndex = 3;

                    }
                    if (dtdichvu.Rows[i]["TenDV"].ToString().ToLower() == "nước lọc".ToLower())
                    {

                        lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                        lsv_Item.ImageIndex = 4;

                    }
                    if (dtdichvu.Rows[i]["TenDV"].ToString().ToLower() == "pepsi".ToLower())
                    {

                        lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                        lsv_Item.ImageIndex = 5;

                    }
                    if (dtdichvu.Rows[i]["TenDV"].ToString().ToLower() == "redbull".ToLower())
                    {

                        lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                        lsv_Item.ImageIndex = 6;

                    }
                    if (dtdichvu.Rows[i]["TenDV"].ToString().ToLower() == "bia sài gòn".ToLower())
                    {

                        lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                        lsv_Item.ImageIndex = 7;

                    }
                    if (dtdichvu.Rows[i]["TenDV"].ToString().ToLower() == "Sting".ToLower())
                    {

                        lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                        lsv_Item.ImageIndex = 8;

                    }
                    if (dtdichvu.Rows[i]["TenDV"].ToString().ToLower() == "Bia tiger".ToLower())
                    {
                        lsv_Item = lst_DichVu.Items.Add(dtdichvu.Rows[i]["TenDV"].ToString());
                        lsv_Item.ImageIndex = 9;
                    }
                }
                if (radio_All.Checked == true)
                {
                    ShowListViewDichVu();
                }
            }
        }
        private void btn_ChonVatLieu_Click(object sender, EventArgs e)
        {
            if (txt_TenDV.Text == "" || txtDonGia.Text == "")
            {
                MessageBox.Show("Bạn không được để trống nhé!");
            }
            else
            {
                xuLyChonDV(txt_TenDV.Text);
                txt_TenDV.Text = "";
                txtDonGia.Text = "";
                btn_Xacnhan.Enabled = true;
            }
        }

        private void radio_All_CheckedChanged(object sender, EventArgs e)
        {
            showPhongTheoRadio();

        }

        private void radio_SapHet_CheckedChanged(object sender, EventArgs e)
        {
            showPhongTheoRadio();

        }

        private void radio_Het_CheckedChanged(object sender, EventArgs e)
        {
            showPhongTheoRadio();

        }

        private void btn_Xacnhan_Click(object sender, EventArgs e)

        {
            if (MessageBox.Show("Bạn có muốn nhập tất cả nguyên vật liệu này ?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                {
                    TenDichVu = dataGridView3.Rows[i].Cells[1].Value.ToString();
                    xulyDatHang(MaPN, TenDichVu);

                }
                capnhattien(MaPN);
                btn_INPhieu.Enabled = btn_NhapTiep.Enabled = true;
                btn_Xacnhan.Enabled = btn_ChonVatLieu.Enabled = false;
                dataGridView3.DataSource = null;
                dataGridView3.Rows.Clear();
                DichVuSapHet();
                DichVuHet();

            }
        }
        public void capnhattien(string mapn)
        {
            string sql = "update PhieuNhap  set ThanhTien=(select sum(ThanhTien) from ChiTietNhap where MaPhieuNhap ='" + mapn + "') where MaPhieuNhap = '" + mapn + "'";
            //MessageBox.Show("" + sql);
            db.ThemXoaSua(sql);
        }
        public void xulyDatHang(string mapn, string tendv)
        {
            dtChiTietPhieuNhap = db.LayDuLieu("select *from ChiTietNhap");
            DataRow newrow = dtChiTietPhieuNhap.NewRow();
            newrow[0] = mapn;
            newrow[1] = getMaDV(tendv).ToString();
            newrow[2] = dataGridView3.Rows[Layvitritrung(tendv)].Cells[2].Value.ToString();
            newrow[3] = dataGridView3.Rows[Layvitritrung(tendv)].Cells[3].Value.ToString();
            newrow[4] = "0.0";
            dtChiTietPhieuNhap.Rows.Add(newrow);
            try
            {
                string sql = "select * from ChiTietNhap";
                db.UpdateData(sql, dtChiTietPhieuNhap);
                showDVdaNhap(MaPN);
                btn_taoPN.Enabled = false;
                cb_NCC.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Loi~111111");
                btn_taoPN.Enabled = true;
                cb_NCC.Enabled = true;
            }
        }
        public string getMaDV(string TenDV)
        {
            string sql = string.Format(@"select * from DichVu where TenDV=N'{0}'", TenDV);
            dtGetMaDV = db.LayDuLieu(sql);
            DataRow getma = dtGetMaDV.Rows[0];
            string maDV = getma["MaDV"].ToString();
            return maDV;
        }
        public int checkDuLieuNhap()
        {
            if (cb_NCC.Text == "")
            {
                return 0;
            }
            return 1;
        }
        public void taoPhieuNhap()
        {
            if (checkDuLieuNhap() == 1)
            {
                string SetMaDV = " select count(*)+1 a from PhieuNhap";
                dtLayMaPN = db.LayDuLieu(SetMaDV);
                int num;
                DataRow sl = dtLayMaPN.Rows[0];

                num = Convert.ToInt16(sl["a"].ToString());
                //  MessageBox.Show("asda" +num);




                MaPN = "PN_" + num;
                dtPhieuNhap = db.LayDuLieu("select *from PhieuNhap");
                DataRow newrow = dtPhieuNhap.NewRow();
                newrow[0] = MaPN;
                newrow[1] = Frm_DangNhap.MaNV;
                newrow[2] = cb_NCC.SelectedValue.ToString();
                newrow[3] = "0.0";
                newrow[4] = TGHienTai;
                dtPhieuNhap.Rows.Add(newrow);
                try
                {
                    string sql = "select * from PhieuNhap";
                    db.UpdateData(sql, dtPhieuNhap);

                }
                catch (Exception)
                {
                    MessageBox.Show("Loi~111111");
                }
            }
            else
            {
                MessageBox.Show("Bạn cần điền đủ thông tin nhé");
            }
        }
        public void showDVdaNhap(string mapn)
        {
            dataGridView4.AutoGenerateColumns = false;
            dtChiTietPhieuNhap = db.LayDuLieu("select ROW_NUMBER() OVER (ORDER BY DICHVU.MaDV) AS STT,TenNCC,TenDV,SoLuong, Chitietnhap.Dongia,ChiTietNhap.ThanhTien from NhaCungCap, PhieuNhap,ChiTietNhap,DICHVU where DICHVU.MaDV=ChiTietNhap.MaDV and PhieuNhap.MaNCC = NhaCungCap.MaNCC and PhieuNhap.MaPhieuNhap=ChiTietNhap.MaPhieuNhap and ChiTietNhap.MaPhieuNhap = '" + mapn + "'");
            dataGridView4.DataSource = dtChiTietPhieuNhap;
            dataGridView4.Columns[0].DataPropertyName = "TenNCC";
            dataGridView4.Columns[1].DataPropertyName = "TenDV";
            dataGridView4.Columns[2].DataPropertyName = "SoLuong";
            dataGridView4.Columns[3].DataPropertyName = "DonGia";
            dataGridView4.Columns[4].DataPropertyName = "ThanhTien";
        }
        public void xulyViewData(string TenDV)
        {
            try
            {
                string laydulieu = "select * from DICHVU where TenDV = N'" + TenDV + "'";
                dtdichvu = db.LayDuLieu(laydulieu);
                DataRow data = dtdichvu.Rows[0];
                txtDonGia.Text = data["DonGia"].ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btn_NhapTiep_Click(object sender, EventArgs e)
        {
            btn_taoPN.Enabled = true;
            cb_NCC.Enabled = true;
            trangThai(false);
            MaPN = "";
            showDVdaNhap(MaPN);
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();

        }
        public void xuLyChonDV(string tendv)
        {
            if (dataGridView3.Rows[0].Cells[0].Value == null)
            {
                int rowId = dataGridView3.Rows.Add();
                DataGridViewRow row = dataGridView3.Rows[rowId];
                row.Cells["Column11"].Value = txt_TenNCC.Text;
                row.Cells["Column12"].Value = txt_TenDV.Text;
                row.Cells["Column13"].Value = num_soLuong.Text;
                row.Cells["Column14"].Value = txtDonGia.Text;
            }
            else
            {
                if (checkDichVu1(tendv) == 0)
                {
                    int rowId = dataGridView3.Rows.Add();
                    DataGridViewRow row = dataGridView3.Rows[rowId];
                    row.Cells["Column11"].Value = txt_TenNCC.Text;
                    row.Cells["Column12"].Value = txt_TenDV.Text;
                    row.Cells["Column13"].Value = num_soLuong.Text;
                    row.Cells["Column14"].Value = txtDonGia.Text;
                }
                else
                {
                    int vitri = Layvitritrung(tendv);
                    string soluong = dataGridView3.Rows[vitri].Cells[1].Value.ToString();
                    a = int.Parse(soluong) + int.Parse(num_soLuong.Text);
                    dataGridView3.Rows[vitri].Cells[1].Value = "" + a;

                }
            }

        }
        public int checkDichVu1(string tendv)
        {
            for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
            {
                if (dataGridView3.Rows[i].Cells[0].Value.ToString() == tendv)
                {
                    return 1;
                }
            }
            return 0;
        }
        public int Layvitritrung(string tendv)
        {
            for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
            {
                if (dataGridView3.Rows[i].Cells[1].Value.ToString() == tendv)
                {
                    return i;
                }
            }
            return 0;
        }

        public void trangThai(bool mo)
        {
            txt_TenDV.Enabled = mo;
            txtDonGia.Enabled = mo;
            num_soLuong.Enabled = mo;
            btn_Xacnhan.Enabled = mo;
            btn_ChonVatLieu.Enabled = mo;
            btn_INPhieu.Enabled = mo;
            btn_NhapTiep.Enabled = mo;
        }
        public void TrangThaiAn(bool mo)
        {
            txt_TenNCC.Enabled = mo;
            txt_tenNV.Enabled = mo;
        }

        public void trangThaiThongTin(bool mo)
        {
            txt_TenDV.Enabled = mo;
            txtDonGia.Enabled = mo;
            num_soLuong.Enabled = mo;
        }

        string MaPN = "";
        string TenDichVu;
        int a;
        public Frm_NhapHang()
        {
            InitializeComponent();
        }

        private void Frm_NhapHang_Load(object sender, EventArgs e)
        {
            trangThai(false);
            TrangThaiAn(false);
            DichVuSapHet();
            DichVuHet();
            radio_All.Visible = true;
            radio_All.Checked = true;
            //ShowListViewDichVu();
            NhaCungCap();
        }
    }
}
