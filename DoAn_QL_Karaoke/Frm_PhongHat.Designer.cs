
namespace DoAn_QL_Karaoke
{
    partial class Frm_PhongHat
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.txt_BinhThuong = new System.Windows.Forms.TextBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.txt_caoDiem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grp_ThongTin = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TinhTrangPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBinhThuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaCaoDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dgv_DSPhong = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.grp_ThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_DSPhong)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(662, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "Danh Sách Phòng Hát";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Location = new System.Drawing.Point(125, 52);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(186, 21);
            this.cbTrangThai.TabIndex = 2;
            // 
            // txt_BinhThuong
            // 
            this.txt_BinhThuong.Location = new System.Drawing.Point(125, 124);
            this.txt_BinhThuong.Name = "txt_BinhThuong";
            this.txt_BinhThuong.Size = new System.Drawing.Size(186, 20);
            this.txt_BinhThuong.TabIndex = 1;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(125, 23);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(186, 20);
            this.txtTenPhong.TabIndex = 1;
            // 
            // txt_caoDiem
            // 
            this.txt_caoDiem.Location = new System.Drawing.Point(125, 91);
            this.txt_caoDiem.Name = "txt_caoDiem";
            this.txt_caoDiem.Size = new System.Drawing.Size(186, 20);
            this.txt_caoDiem.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(6, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giá bình thường";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grp_ThongTin
            // 
            this.grp_ThongTin.Controls.Add(this.cbTrangThai);
            this.grp_ThongTin.Controls.Add(this.txt_BinhThuong);
            this.grp_ThongTin.Controls.Add(this.txtTenPhong);
            this.grp_ThongTin.Controls.Add(this.groupBox4);
            this.grp_ThongTin.Controls.Add(this.txt_caoDiem);
            this.grp_ThongTin.Controls.Add(this.label7);
            this.grp_ThongTin.Controls.Add(this.label3);
            this.grp_ThongTin.Controls.Add(this.label6);
            this.grp_ThongTin.Controls.Add(this.label4);
            this.grp_ThongTin.Location = new System.Drawing.Point(25, 44);
            this.grp_ThongTin.Name = "grp_ThongTin";
            this.grp_ThongTin.Size = new System.Drawing.Size(608, 194);
            this.grp_ThongTin.TabIndex = 9;
            this.grp_ThongTin.TabStop = false;
            this.grp_ThongTin.Text = "Thông Tin";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(6, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Trạng Thái :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(6, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giá cao điểm";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên Phòng :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TinhTrangPhong
            // 
            this.TinhTrangPhong.DataPropertyName = "TinhTrang";
            this.TinhTrangPhong.HeaderText = "Tình Trạng";
            this.TinhTrangPhong.Name = "TinhTrangPhong";
            this.TinhTrangPhong.ReadOnly = true;
            this.TinhTrangPhong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // GiaBinhThuong
            // 
            this.GiaBinhThuong.HeaderText = "Giá Bình Thường ";
            this.GiaBinhThuong.Name = "GiaBinhThuong";
            this.GiaBinhThuong.ReadOnly = true;
            // 
            // GiaCaoDiem
            // 
            this.GiaCaoDiem.DataPropertyName = "GiaCaoDiem";
            this.GiaCaoDiem.HeaderText = "Giá cao điểm";
            this.GiaCaoDiem.Name = "GiaCaoDiem";
            this.GiaCaoDiem.ReadOnly = true;
            // 
            // TenPH
            // 
            this.TenPH.DataPropertyName = "TenPH";
            this.TenPH.HeaderText = "Tên PH";
            this.TenPH.Name = "TenPH";
            this.TenPH.ReadOnly = true;
            // 
            // MaPH
            // 
            this.MaPH.DataPropertyName = "MaPH";
            this.MaPH.HeaderText = "Mã PH";
            this.MaPH.Name = "MaPH";
            this.MaPH.ReadOnly = true;
            this.MaPH.Width = 70;
            // 
            // Dgv_DSPhong
            // 
            this.Dgv_DSPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_DSPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPH,
            this.TenPH,
            this.GiaCaoDiem,
            this.GiaBinhThuong,
            this.TinhTrangPhong});
            this.Dgv_DSPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_DSPhong.Location = new System.Drawing.Point(3, 16);
            this.Dgv_DSPhong.Name = "Dgv_DSPhong";
            this.Dgv_DSPhong.ReadOnly = true;
            this.Dgv_DSPhong.Size = new System.Drawing.Size(601, 220);
            this.Dgv_DSPhong.TabIndex = 0;
            this.Dgv_DSPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_DSPhong_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Dgv_DSPhong);
            this.groupBox2.Location = new System.Drawing.Point(31, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(607, 239);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Phòng";
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(146, 43);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(95, 23);
            this.btn_Luu.TabIndex = 0;
            this.btn_Luu.Text = "&Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_Them);
            this.groupBox4.Controls.Add(this.btn_Xoa);
            this.groupBox4.Controls.Add(this.btn_Luu);
            this.groupBox4.Controls.Add(this.btn_Sua);
            this.groupBox4.Location = new System.Drawing.Point(335, 23);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(252, 79);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức Năng";
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(35, 14);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(95, 23);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "&Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(146, 14);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(95, 23);
            this.btn_Xoa.TabIndex = 0;
            this.btn_Xoa.Text = "&Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(35, 43);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(95, 23);
            this.btn_Sua.TabIndex = 0;
            this.btn_Sua.Text = "&Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // Frm_PhongHat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 524);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grp_ThongTin);
            this.Controls.Add(this.groupBox2);
            this.Name = "Frm_PhongHat";
            this.Text = "Frm_PhongHat";
            this.Load += new System.EventHandler(this.Frm_PhongHat_Load);
            this.grp_ThongTin.ResumeLayout(false);
            this.grp_ThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_DSPhong)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.TextBox txt_BinhThuong;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.TextBox txt_caoDiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grp_ThongTin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrangPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBinhThuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaCaoDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPH;
        private System.Windows.Forms.DataGridView Dgv_DSPhong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
    }
}