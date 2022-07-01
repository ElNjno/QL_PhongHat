
namespace DoAn_QL_Karaoke
{
    partial class Frm_ChuyenPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ChuyenPhong));
            this.img_hinh = new System.Windows.Forms.ImageList(this.components);
            this.lst_Phong = new System.Windows.Forms.ListView();
            this.btn_XacNhan = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lbl_TenPhong = new System.Windows.Forms.Label();
            this.lbl_MaPH = new System.Windows.Forms.Label();
            this.lbl_GioCD = new System.Windows.Forms.Label();
            this.lbl_GioBT = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // img_hinh
            // 
            this.img_hinh.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_hinh.ImageStream")));
            this.img_hinh.TransparentColor = System.Drawing.Color.Transparent;
            this.img_hinh.Images.SetKeyName(0, "PhongTrong.png");
            this.img_hinh.Images.SetKeyName(1, "PhongCoKhach.png");
            this.img_hinh.Images.SetKeyName(2, "PhongDaDat.jpg");
            // 
            // lst_Phong
            // 
            this.lst_Phong.HideSelection = false;
            this.lst_Phong.LargeImageList = this.img_hinh;
            this.lst_Phong.Location = new System.Drawing.Point(12, 164);
            this.lst_Phong.Name = "lst_Phong";
            this.lst_Phong.Size = new System.Drawing.Size(434, 245);
            this.lst_Phong.TabIndex = 1;
            this.lst_Phong.UseCompatibleStateImageBehavior = false;
            this.lst_Phong.Click += new System.EventHandler(this.lst_Phong_Click);
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.Location = new System.Drawing.Point(77, 415);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(247, 23);
            this.btn_XacNhan.TabIndex = 2;
            this.btn_XacNhan.Text = "Xac Nhan Chuyen Phong";
            this.btn_XacNhan.UseVisualStyleBackColor = true;
            this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(371, 415);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 20;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 34);
            this.label1.TabIndex = 21;
            this.label1.Text = "Quản Lý Chuyển Phòng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(268, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Giờ CD ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã PH";
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
            // lbl_TenPhong
            // 
            this.lbl_TenPhong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_TenPhong.Location = new System.Drawing.Point(104, 21);
            this.lbl_TenPhong.Name = "lbl_TenPhong";
            this.lbl_TenPhong.Size = new System.Drawing.Size(158, 21);
            this.lbl_TenPhong.TabIndex = 0;
            // 
            // lbl_MaPH
            // 
            this.lbl_MaPH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_MaPH.Location = new System.Drawing.Point(104, 49);
            this.lbl_MaPH.Name = "lbl_MaPH";
            this.lbl_MaPH.Size = new System.Drawing.Size(158, 21);
            this.lbl_MaPH.TabIndex = 0;
            // 
            // lbl_GioCD
            // 
            this.lbl_GioCD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_GioCD.Location = new System.Drawing.Point(335, 20);
            this.lbl_GioCD.Name = "lbl_GioCD";
            this.lbl_GioCD.Size = new System.Drawing.Size(93, 21);
            this.lbl_GioCD.TabIndex = 0;
            // 
            // lbl_GioBT
            // 
            this.lbl_GioBT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_GioBT.Location = new System.Drawing.Point(335, 51);
            this.lbl_GioBT.Name = "lbl_GioBT";
            this.lbl_GioBT.Size = new System.Drawing.Size(93, 21);
            this.lbl_GioBT.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbl_GioBT);
            this.groupBox4.Controls.Add(this.lbl_GioCD);
            this.groupBox4.Controls.Add(this.lbl_MaPH);
            this.groupBox4.Controls.Add(this.lbl_TenPhong);
            this.groupBox4.Controls.Add(this.lbl);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(12, 65);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(434, 78);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông Tin Phòng";
            // 
            // Frm_ChuyenPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btn_XacNhan);
            this.Controls.Add(this.lst_Phong);
            this.Name = "Frm_ChuyenPhong";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ChuyenPhong";
            this.Load += new System.EventHandler(this.Frm_ChuyenPhong_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList img_hinh;
        private System.Windows.Forms.ListView lst_Phong;
        private System.Windows.Forms.Button btn_XacNhan;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lbl_TenPhong;
        private System.Windows.Forms.Label lbl_MaPH;
        private System.Windows.Forms.Label lbl_GioCD;
        private System.Windows.Forms.Label lbl_GioBT;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}