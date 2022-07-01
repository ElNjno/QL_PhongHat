
namespace DoAn_QL_Karaoke
{
    partial class Frm_DatPhongOnline
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DatPhongOnline));
            this.txt_KhachHang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_giodat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dpk_ngaydat = new System.Windows.Forms.DateTimePicker();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.grp_Online = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.img_hinh = new System.Windows.Forms.ImageList(this.components);
            this.lst_Phong = new System.Windows.Forms.ListView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl_GioBT = new System.Windows.Forms.Label();
            this.lbl_GioCD = new System.Windows.Forms.Label();
            this.lbl_MaPH = new System.Windows.Forms.Label();
            this.lbl_TenPhong = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bnt_XacNhan = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.grp_Online.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_KhachHang
            // 
            this.txt_KhachHang.Location = new System.Drawing.Point(118, 28);
            this.txt_KhachHang.Name = "txt_KhachHang";
            this.txt_KhachHang.Size = new System.Drawing.Size(173, 20);
            this.txt_KhachHang.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(0, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giờ Đặt :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_giodat
            // 
            this.txt_giodat.Location = new System.Drawing.Point(117, 130);
            this.txt_giodat.MaxLength = 5;
            this.txt_giodat.Name = "txt_giodat";
            this.txt_giodat.Size = new System.Drawing.Size(174, 20);
            this.txt_giodat.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(0, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ngày Đặt :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dpk_ngaydat
            // 
            this.dpk_ngaydat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpk_ngaydat.Location = new System.Drawing.Point(117, 95);
            this.dpk_ngaydat.Name = "dpk_ngaydat";
            this.dpk_ngaydat.Size = new System.Drawing.Size(174, 20);
            this.dpk_ngaydat.TabIndex = 11;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(117, 55);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(174, 20);
            this.txt_SDT.TabIndex = 2;
            this.txt_SDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SDT_KeyPress);
            // 
            // grp_Online
            // 
            this.grp_Online.Controls.Add(this.txt_SDT);
            this.grp_Online.Controls.Add(this.dpk_ngaydat);
            this.grp_Online.Controls.Add(this.label2);
            this.grp_Online.Controls.Add(this.label3);
            this.grp_Online.Controls.Add(this.label1);
            this.grp_Online.Controls.Add(this.txt_giodat);
            this.grp_Online.Controls.Add(this.label4);
            this.grp_Online.Controls.Add(this.txt_KhachHang);
            this.grp_Online.Location = new System.Drawing.Point(22, 12);
            this.grp_Online.Name = "grp_Online";
            this.grp_Online.Size = new System.Drawing.Size(312, 169);
            this.grp_Online.TabIndex = 4;
            this.grp_Online.TabStop = false;
            this.grp_Online.Text = "Đặt Phòng Online";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(0, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên Khách Hàng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(0, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "SDT Khách Hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // img_hinh
            // 
            this.img_hinh.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_hinh.ImageStream")));
            this.img_hinh.TransparentColor = System.Drawing.Color.Transparent;
            this.img_hinh.Images.SetKeyName(0, "microphone-karaoke-sound-line-style-icon-free-vector.jpg");
            // 
            // lst_Phong
            // 
            this.lst_Phong.HideSelection = false;
            this.lst_Phong.LargeImageList = this.img_hinh;
            this.lst_Phong.Location = new System.Drawing.Point(22, 187);
            this.lst_Phong.Name = "lst_Phong";
            this.lst_Phong.Size = new System.Drawing.Size(536, 242);
            this.lst_Phong.TabIndex = 5;
            this.lst_Phong.UseCompatibleStateImageBehavior = false;
            this.lst_Phong.Click += new System.EventHandler(this.lst_Phong_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbl_GioBT);
            this.groupBox4.Controls.Add(this.lbl_GioCD);
            this.groupBox4.Controls.Add(this.lbl_MaPH);
            this.groupBox4.Controls.Add(this.lbl_TenPhong);
            this.groupBox4.Controls.Add(this.lbl);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(340, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(218, 163);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông Tin Phòng";
            // 
            // lbl_GioBT
            // 
            this.lbl_GioBT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_GioBT.Location = new System.Drawing.Point(104, 125);
            this.lbl_GioBT.Name = "lbl_GioBT";
            this.lbl_GioBT.Size = new System.Drawing.Size(94, 21);
            this.lbl_GioBT.TabIndex = 0;
            // 
            // lbl_GioCD
            // 
            this.lbl_GioCD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_GioCD.Location = new System.Drawing.Point(104, 94);
            this.lbl_GioCD.Name = "lbl_GioCD";
            this.lbl_GioCD.Size = new System.Drawing.Size(94, 21);
            this.lbl_GioCD.TabIndex = 0;
            // 
            // lbl_MaPH
            // 
            this.lbl_MaPH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_MaPH.Location = new System.Drawing.Point(104, 49);
            this.lbl_MaPH.Name = "lbl_MaPH";
            this.lbl_MaPH.Size = new System.Drawing.Size(94, 21);
            this.lbl_MaPH.TabIndex = 0;
            // 
            // lbl_TenPhong
            // 
            this.lbl_TenPhong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_TenPhong.Location = new System.Drawing.Point(104, 21);
            this.lbl_TenPhong.Name = "lbl_TenPhong";
            this.lbl_TenPhong.Size = new System.Drawing.Size(94, 21);
            this.lbl_TenPhong.TabIndex = 0;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(7, 129);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(40, 13);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Giờ BT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã PH";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Giờ CD ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên Phòng";
            // 
            // bnt_XacNhan
            // 
            this.bnt_XacNhan.Location = new System.Drawing.Point(22, 435);
            this.bnt_XacNhan.Name = "bnt_XacNhan";
            this.bnt_XacNhan.Size = new System.Drawing.Size(452, 23);
            this.bnt_XacNhan.TabIndex = 21;
            this.bnt_XacNhan.Text = "Xác nhận đặt phòng ";
            this.bnt_XacNhan.UseVisualStyleBackColor = true;
            this.bnt_XacNhan.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(480, 434);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 22;
            this.btn_Thoat.Text = "Thoat";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // Frm_DatPhongOnline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 501);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.bnt_XacNhan);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lst_Phong);
            this.Controls.Add(this.grp_Online);
            this.Name = "Frm_DatPhongOnline";
            this.Text = "Frm_DatPhongOnline";
            this.Load += new System.EventHandler(this.Frm_DatPhongOnline_Load);
            this.grp_Online.ResumeLayout(false);
            this.grp_Online.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_KhachHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_giodat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dpk_ngaydat;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.GroupBox grp_Online;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList img_hinh;
        private System.Windows.Forms.ListView lst_Phong;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbl_GioBT;
        private System.Windows.Forms.Label lbl_GioCD;
        private System.Windows.Forms.Label lbl_MaPH;
        private System.Windows.Forms.Label lbl_TenPhong;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bnt_XacNhan;
        private System.Windows.Forms.Button btn_Thoat;
    }
}