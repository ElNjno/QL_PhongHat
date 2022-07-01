
namespace DoAn_QL_Karaoke
{
    partial class Frm_NhanDatPhong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_NhanDatPhong));
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_CTHoaDon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.btn_NPhongTQ = new System.Windows.Forms.Button();
            this.btn_chuyenphong = new System.Windows.Forms.Button();
            this.btn_NPhongDT = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_GioBT = new System.Windows.Forms.Label();
            this.lbl_GioCD = new System.Windows.Forms.Label();
            this.lbl_TenPhong = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rad_Tatca = new System.Windows.Forms.RadioButton();
            this.rad_PhongCoKhach = new System.Windows.Forms.RadioButton();
            this.rad_PhongTrong = new System.Windows.Forms.RadioButton();
            this.rad_PhongDaDat = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.img_hinh = new System.Windows.Forms.ImageList(this.components);
            this.lst_Phong = new System.Windows.Forms.ListView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.lbl_Giovao = new System.Windows.Forms.Label();
            this.lbl_ngay = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_NgayCS = new System.Windows.Forms.Label();
            this.txt_KhachHang = new System.Windows.Forms.TextBox();
            this.lbl_GioCS = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl_MaTP = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.Menu_CTHoaDon.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dataGridView2);
            this.groupBox7.Location = new System.Drawing.Point(719, 310);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(562, 185);
            this.groupBox7.TabIndex = 22;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "DS Phòng Nhận";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 15;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(556, 166);
            this.dataGridView2.TabIndex = 94;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã TP";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Khách Hàng";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "SDT Khách Hàng";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Ngày Vào";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Giờ Vào";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // xoaToolStripMenuItem
            // 
            this.xoaToolStripMenuItem.Name = "xoaToolStripMenuItem";
            this.xoaToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.xoaToolStripMenuItem.Text = "&Xóa";
            // 
            // Menu_CTHoaDon
            // 
            this.Menu_CTHoaDon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xoaToolStripMenuItem});
            this.Menu_CTHoaDon.Name = "Menu_CTHoaDon";
            this.Menu_CTHoaDon.Size = new System.Drawing.Size(95, 26);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btn_ThanhToan);
            this.groupBox9.Controls.Add(this.btn_NPhongTQ);
            this.groupBox9.Controls.Add(this.btn_chuyenphong);
            this.groupBox9.Controls.Add(this.btn_NPhongDT);
            this.groupBox9.Location = new System.Drawing.Point(544, 310);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(166, 181);
            this.groupBox9.TabIndex = 23;
            this.groupBox9.TabStop = false;
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.Location = new System.Drawing.Point(10, 136);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(137, 28);
            this.btn_ThanhToan.TabIndex = 0;
            this.btn_ThanhToan.Text = "Thanh Toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = true;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // btn_NPhongTQ
            // 
            this.btn_NPhongTQ.Location = new System.Drawing.Point(10, 12);
            this.btn_NPhongTQ.Name = "btn_NPhongTQ";
            this.btn_NPhongTQ.Size = new System.Drawing.Size(137, 28);
            this.btn_NPhongTQ.TabIndex = 1;
            this.btn_NPhongTQ.Text = "Nhận Phòng Tại Quầy";
            this.btn_NPhongTQ.UseVisualStyleBackColor = true;
            this.btn_NPhongTQ.Click += new System.EventHandler(this.btn_NPhongTQ_Click);
            // 
            // btn_chuyenphong
            // 
            this.btn_chuyenphong.Location = new System.Drawing.Point(10, 88);
            this.btn_chuyenphong.Name = "btn_chuyenphong";
            this.btn_chuyenphong.Size = new System.Drawing.Size(137, 26);
            this.btn_chuyenphong.TabIndex = 2;
            this.btn_chuyenphong.Text = "Chuyển Phòng";
            this.btn_chuyenphong.UseVisualStyleBackColor = true;
            this.btn_chuyenphong.Click += new System.EventHandler(this.btn_chuyenphong_Click);
            // 
            // btn_NPhongDT
            // 
            this.btn_NPhongDT.Location = new System.Drawing.Point(10, 54);
            this.btn_NPhongDT.Name = "btn_NPhongDT";
            this.btn_NPhongDT.Size = new System.Drawing.Size(137, 28);
            this.btn_NPhongDT.TabIndex = 1;
            this.btn_NPhongDT.Text = "Nhận Phòng Đặt Trước";
            this.btn_NPhongDT.UseVisualStyleBackColor = true;
            this.btn_NPhongDT.Click += new System.EventHandler(this.btn_NPhongDT_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(28, 310);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(493, 185);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Phòng Đặt";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 15;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(487, 166);
            this.dataGridView1.TabIndex = 93;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã TP";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Khách Hàng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "SDT Khách Hàng";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ngày Đặt";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Giờ Đặt";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // lbl_GioBT
            // 
            this.lbl_GioBT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_GioBT.Location = new System.Drawing.Point(335, 51);
            this.lbl_GioBT.Name = "lbl_GioBT";
            this.lbl_GioBT.Size = new System.Drawing.Size(93, 21);
            this.lbl_GioBT.TabIndex = 0;
            // 
            // lbl_GioCD
            // 
            this.lbl_GioCD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_GioCD.Location = new System.Drawing.Point(335, 20);
            this.lbl_GioCD.Name = "lbl_GioCD";
            this.lbl_GioCD.Size = new System.Drawing.Size(93, 21);
            this.lbl_GioCD.TabIndex = 0;
            // 
            // lbl_TenPhong
            // 
            this.lbl_TenPhong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_TenPhong.Location = new System.Drawing.Point(104, 21);
            this.lbl_TenPhong.Name = "lbl_TenPhong";
            this.lbl_TenPhong.Size = new System.Drawing.Size(158, 21);
            this.lbl_TenPhong.TabIndex = 0;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(268, 51);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(40, 13);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Giờ BT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Phòng";
            // 
            // rad_Tatca
            // 
            this.rad_Tatca.AutoSize = true;
            this.rad_Tatca.Location = new System.Drawing.Point(10, 19);
            this.rad_Tatca.Name = "rad_Tatca";
            this.rad_Tatca.Size = new System.Drawing.Size(57, 17);
            this.rad_Tatca.TabIndex = 3;
            this.rad_Tatca.TabStop = true;
            this.rad_Tatca.Text = "Tất Cả";
            this.rad_Tatca.UseVisualStyleBackColor = true;
            this.rad_Tatca.CheckedChanged += new System.EventHandler(this.rad_Tatca_CheckedChanged);
            // 
            // rad_PhongCoKhach
            // 
            this.rad_PhongCoKhach.AutoSize = true;
            this.rad_PhongCoKhach.Location = new System.Drawing.Point(10, 43);
            this.rad_PhongCoKhach.Name = "rad_PhongCoKhach";
            this.rad_PhongCoKhach.Size = new System.Drawing.Size(106, 17);
            this.rad_PhongCoKhach.TabIndex = 2;
            this.rad_PhongCoKhach.TabStop = true;
            this.rad_PhongCoKhach.Text = "Phòng Có Khách";
            this.rad_PhongCoKhach.UseVisualStyleBackColor = true;
            this.rad_PhongCoKhach.CheckedChanged += new System.EventHandler(this.rad_PhongCoKhach_CheckedChanged);
            // 
            // rad_PhongTrong
            // 
            this.rad_PhongTrong.AutoSize = true;
            this.rad_PhongTrong.Location = new System.Drawing.Point(10, 66);
            this.rad_PhongTrong.Name = "rad_PhongTrong";
            this.rad_PhongTrong.Size = new System.Drawing.Size(87, 17);
            this.rad_PhongTrong.TabIndex = 0;
            this.rad_PhongTrong.TabStop = true;
            this.rad_PhongTrong.Text = "Phòng Trống";
            this.rad_PhongTrong.UseVisualStyleBackColor = true;
            this.rad_PhongTrong.CheckedChanged += new System.EventHandler(this.rad_PhongTrong_CheckedChanged);
            // 
            // rad_PhongDaDat
            // 
            this.rad_PhongDaDat.AutoSize = true;
            this.rad_PhongDaDat.Location = new System.Drawing.Point(10, 89);
            this.rad_PhongDaDat.Name = "rad_PhongDaDat";
            this.rad_PhongDaDat.Size = new System.Drawing.Size(93, 17);
            this.rad_PhongDaDat.TabIndex = 1;
            this.rad_PhongDaDat.TabStop = true;
            this.rad_PhongDaDat.Text = "Phòng Đã Đặt";
            this.rad_PhongDaDat.UseVisualStyleBackColor = true;
            this.rad_PhongDaDat.CheckedChanged += new System.EventHandler(this.rad_PhongDaDat_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(268, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Giờ CD ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rad_Tatca);
            this.groupBox2.Controls.Add(this.rad_PhongCoKhach);
            this.groupBox2.Controls.Add(this.rad_PhongTrong);
            this.groupBox2.Controls.Add(this.rad_PhongDaDat);
            this.groupBox2.Location = new System.Drawing.Point(544, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 139);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trạng Thái";
            // 
            // img_hinh
            // 
            this.img_hinh.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_hinh.ImageStream")));
            this.img_hinh.TransparentColor = System.Drawing.Color.Transparent;
            this.img_hinh.Images.SetKeyName(0, "microphone-karaoke-sound-line-style-icon-free-vector.jpg");
            this.img_hinh.Images.SetKeyName(1, "images.png");
            this.img_hinh.Images.SetKeyName(2, "karaoke-icon-png-6.jpg");
            // 
            // lst_Phong
            // 
            this.lst_Phong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst_Phong.HideSelection = false;
            this.lst_Phong.LargeImageList = this.img_hinh;
            this.lst_Phong.Location = new System.Drawing.Point(3, 16);
            this.lst_Phong.MultiSelect = false;
            this.lst_Phong.Name = "lst_Phong";
            this.lst_Phong.Size = new System.Drawing.Size(490, 205);
            this.lst_Phong.TabIndex = 0;
            this.lst_Phong.UseCompatibleStateImageBehavior = false;
            this.lst_Phong.SelectedIndexChanged += new System.EventHandler(this.lst_Phong_SelectedIndexChanged);
            this.lst_Phong.Click += new System.EventHandler(this.lst_Phong_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txt_SDT);
            this.groupBox5.Controls.Add(this.lbl_Giovao);
            this.groupBox5.Controls.Add(this.lbl_ngay);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.lbl_NgayCS);
            this.groupBox5.Controls.Add(this.txt_KhachHang);
            this.groupBox5.Controls.Add(this.lbl_GioCS);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(719, 185);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(562, 119);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thông Tin Khách Hàng";
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(117, 47);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(123, 20);
            this.txt_SDT.TabIndex = 2;
            this.txt_SDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SDT_KeyPress);
            // 
            // lbl_Giovao
            // 
            this.lbl_Giovao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Giovao.Location = new System.Drawing.Point(329, 16);
            this.lbl_Giovao.Name = "lbl_Giovao";
            this.lbl_Giovao.Size = new System.Drawing.Size(105, 25);
            this.lbl_Giovao.TabIndex = 0;
            this.lbl_Giovao.Click += new System.EventHandler(this.lbl_Giovao_Click);
            // 
            // lbl_ngay
            // 
            this.lbl_ngay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_ngay.Location = new System.Drawing.Point(118, 82);
            this.lbl_ngay.Name = "lbl_ngay";
            this.lbl_ngay.Size = new System.Drawing.Size(123, 25);
            this.lbl_ngay.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "SDT Khách Hàng";
            // 
            // lbl_NgayCS
            // 
            this.lbl_NgayCS.AutoSize = true;
            this.lbl_NgayCS.Location = new System.Drawing.Point(10, 94);
            this.lbl_NgayCS.Name = "lbl_NgayCS";
            this.lbl_NgayCS.Size = new System.Drawing.Size(32, 13);
            this.lbl_NgayCS.TabIndex = 0;
            this.lbl_NgayCS.Text = "Ngày";
            // 
            // txt_KhachHang
            // 
            this.txt_KhachHang.Location = new System.Drawing.Point(118, 20);
            this.txt_KhachHang.Name = "txt_KhachHang";
            this.txt_KhachHang.Size = new System.Drawing.Size(123, 20);
            this.txt_KhachHang.TabIndex = 1;
            // 
            // lbl_GioCS
            // 
            this.lbl_GioCS.AutoSize = true;
            this.lbl_GioCS.Location = new System.Drawing.Point(270, 18);
            this.lbl_GioCS.Name = "lbl_GioCS";
            this.lbl_GioCS.Size = new System.Drawing.Size(45, 13);
            this.lbl_GioCS.TabIndex = 0;
            this.lbl_GioCS.Text = "Giờ Vào";
            this.lbl_GioCS.Click += new System.EventHandler(this.lbl_GioCS_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên Khách Hàng";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbl_GioBT);
            this.groupBox4.Controls.Add(this.lbl_GioCD);
            this.groupBox4.Controls.Add(this.lbl_MaTP);
            this.groupBox4.Controls.Add(this.lbl_TenPhong);
            this.groupBox4.Controls.Add(this.lbl);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(716, 76);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(562, 78);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông Tin Phòng";
            // 
            // lbl_MaTP
            // 
            this.lbl_MaTP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_MaTP.Location = new System.Drawing.Point(104, 49);
            this.lbl_MaTP.Name = "lbl_MaTP";
            this.lbl_MaTP.Size = new System.Drawing.Size(158, 21);
            this.lbl_MaTP.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã TP";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lst_Phong);
            this.groupBox1.Location = new System.Drawing.Point(25, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 224);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trạng Thái Phòng";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1262, 34);
            this.label1.TabIndex = 15;
            this.label1.Text = "Quản Lý Thuê Trả Phòng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_NhanDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 633);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Frm_NhanDatPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frnm_NhanDatPhong";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frnm_NhanDatPhong_Load);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.Menu_CTHoaDon.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ToolStripMenuItem xoaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip Menu_CTHoaDon;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button btn_chuyenphong;
        private System.Windows.Forms.Button btn_NPhongDT;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_GioBT;
        private System.Windows.Forms.Label lbl_GioCD;
        private System.Windows.Forms.Label lbl_TenPhong;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rad_Tatca;
        private System.Windows.Forms.RadioButton rad_PhongCoKhach;
        private System.Windows.Forms.RadioButton rad_PhongTrong;
        private System.Windows.Forms.RadioButton rad_PhongDaDat;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ImageList img_hinh;
        private System.Windows.Forms.ListView lst_Phong;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lbl_Giovao;
        private System.Windows.Forms.Label lbl_ngay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_KhachHang;
        private System.Windows.Forms.Label lbl_GioCS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btn_NPhongTQ;
        private System.Windows.Forms.Label lbl_MaTP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_NgayCS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}