namespace PTUDTM_Supermarket_Winform
{
    partial class NhanVienFrm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listViewDsNhanVien = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnChoosenFile = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TaiKhoanCombobox = new System.Windows.Forms.ComboBox();
            this.MatKhauTextBox = new System.Windows.Forms.TextBox();
            this.btnLuuTaiKhoan = new System.Windows.Forms.Button();
            this.btnTaoTaiKhoanMoi = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NgaySinhTextBox = new System.Windows.Forms.DateTimePicker();
            this.PhaiNuRadioButton = new System.Windows.Forms.RadioButton();
            this.btnThemNhanVien = new System.Windows.Forms.Button();
            this.PhaiNamRadioButton = new System.Windows.Forms.RadioButton();
            this.LuongCoBanTextBox = new System.Windows.Forms.TextBox();
            this.DiaChiTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.SoDienThoaiTextBox = new System.Windows.Forms.TextBox();
            this.TenNhanVienTextBox = new System.Windows.Forms.TextBox();
            this.MaNhanVienTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxNhanVien = new System.Windows.Forms.PictureBox();
            this.TenHinhAnhLable = new System.Windows.Forms.Label();
            this.image_list = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listViewDsNhanVien);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 760);
            this.panel1.TabIndex = 0;
            // 
            // listViewDsNhanVien
            // 
            this.listViewDsNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewDsNhanVien.FullRowSelect = true;
            this.listViewDsNhanVien.GridLines = true;
            this.listViewDsNhanVien.HideSelection = false;
            this.listViewDsNhanVien.Location = new System.Drawing.Point(0, 0);
            this.listViewDsNhanVien.Name = "listViewDsNhanVien";
            this.listViewDsNhanVien.Size = new System.Drawing.Size(331, 760);
            this.listViewDsNhanVien.TabIndex = 0;
            this.listViewDsNhanVien.UseCompatibleStateImageBehavior = false;
            this.listViewDsNhanVien.View = System.Windows.Forms.View.Details;
            this.listViewDsNhanVien.SelectedIndexChanged += new System.EventHandler(this.listViewDsNhanVien_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnChoosenFile);
            this.panel2.Controls.Add(this.DeleteButton);
            this.panel2.Controls.Add(this.UpdateButton);
            this.panel2.Controls.Add(this.AddButton);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.pictureBoxNhanVien);
            this.panel2.Controls.Add(this.TenHinhAnhLable);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(331, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(950, 760);
            this.panel2.TabIndex = 1;
            // 
            // btnChoosenFile
            // 
            this.btnChoosenFile.BackgroundImage = global::PTUDTM_Supermarket_Winform.Properties.Resources.btnFind;
            this.btnChoosenFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChoosenFile.Location = new System.Drawing.Point(219, 306);
            this.btnChoosenFile.Name = "btnChoosenFile";
            this.btnChoosenFile.Size = new System.Drawing.Size(58, 40);
            this.btnChoosenFile.TabIndex = 6;
            this.btnChoosenFile.UseVisualStyleBackColor = true;
            this.btnChoosenFile.Click += new System.EventHandler(this.btnChoosenFile_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Red;
            this.DeleteButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(714, 671);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(166, 36);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Xóa";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.Olive;
            this.UpdateButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.UpdateButton.ForeColor = System.Drawing.Color.White;
            this.UpdateButton.Location = new System.Drawing.Point(507, 671);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(166, 36);
            this.UpdateButton.TabIndex = 5;
            this.UpdateButton.Text = "Cập nhật";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Blue;
            this.AddButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(300, 671);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(166, 36);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Thêm nhân viên";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TaiKhoanCombobox);
            this.groupBox2.Controls.Add(this.MatKhauTextBox);
            this.groupBox2.Controls.Add(this.btnLuuTaiKhoan);
            this.groupBox2.Controls.Add(this.btnTaoTaiKhoanMoi);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(300, 512);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(581, 153);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tài khoản";
            // 
            // TaiKhoanCombobox
            // 
            this.TaiKhoanCombobox.Enabled = false;
            this.TaiKhoanCombobox.FormattingEnabled = true;
            this.TaiKhoanCombobox.Location = new System.Drawing.Point(152, 30);
            this.TaiKhoanCombobox.Name = "TaiKhoanCombobox";
            this.TaiKhoanCombobox.Size = new System.Drawing.Size(425, 26);
            this.TaiKhoanCombobox.TabIndex = 6;
            this.TaiKhoanCombobox.SelectedIndexChanged += new System.EventHandler(this.TaiKhoanCombobox_SelectedIndexChanged);
            // 
            // MatKhauTextBox
            // 
            this.MatKhauTextBox.Location = new System.Drawing.Point(152, 69);
            this.MatKhauTextBox.Name = "MatKhauTextBox";
            this.MatKhauTextBox.Size = new System.Drawing.Size(425, 26);
            this.MatKhauTextBox.TabIndex = 5;
            // 
            // btnLuuTaiKhoan
            // 
            this.btnLuuTaiKhoan.BackColor = System.Drawing.Color.Blue;
            this.btnLuuTaiKhoan.Enabled = false;
            this.btnLuuTaiKhoan.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuuTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnLuuTaiKhoan.Location = new System.Drawing.Point(152, 101);
            this.btnLuuTaiKhoan.Name = "btnLuuTaiKhoan";
            this.btnLuuTaiKhoan.Size = new System.Drawing.Size(208, 37);
            this.btnLuuTaiKhoan.TabIndex = 5;
            this.btnLuuTaiKhoan.Text = "Lưu tài khoản";
            this.btnLuuTaiKhoan.UseVisualStyleBackColor = false;
            this.btnLuuTaiKhoan.Click += new System.EventHandler(this.btnLuuTaiKhoan_Click);
            // 
            // btnTaoTaiKhoanMoi
            // 
            this.btnTaoTaiKhoanMoi.BackColor = System.Drawing.Color.Blue;
            this.btnTaoTaiKhoanMoi.Enabled = false;
            this.btnTaoTaiKhoanMoi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTaoTaiKhoanMoi.ForeColor = System.Drawing.Color.White;
            this.btnTaoTaiKhoanMoi.Location = new System.Drawing.Point(369, 101);
            this.btnTaoTaiKhoanMoi.Name = "btnTaoTaiKhoanMoi";
            this.btnTaoTaiKhoanMoi.Size = new System.Drawing.Size(208, 37);
            this.btnTaoTaiKhoanMoi.TabIndex = 5;
            this.btnTaoTaiKhoanMoi.Text = "Tạo tài khoản mới";
            this.btnTaoTaiKhoanMoi.UseVisualStyleBackColor = false;
            this.btnTaoTaiKhoanMoi.Click += new System.EventHandler(this.btnTaoTaiKhoanMoi_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 18);
            this.label10.TabIndex = 3;
            this.label10.Text = "Mật khẩu:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 18);
            this.label9.TabIndex = 4;
            this.label9.Text = "Tên đăng nhập:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NgaySinhTextBox);
            this.groupBox1.Controls.Add(this.PhaiNuRadioButton);
            this.groupBox1.Controls.Add(this.btnThemNhanVien);
            this.groupBox1.Controls.Add(this.PhaiNamRadioButton);
            this.groupBox1.Controls.Add(this.LuongCoBanTextBox);
            this.groupBox1.Controls.Add(this.DiaChiTextBox);
            this.groupBox1.Controls.Add(this.EmailTextBox);
            this.groupBox1.Controls.Add(this.SoDienThoaiTextBox);
            this.groupBox1.Controls.Add(this.TenNhanVienTextBox);
            this.groupBox1.Controls.Add(this.MaNhanVienTextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(300, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 424);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // NgaySinhTextBox
            // 
            this.NgaySinhTextBox.Location = new System.Drawing.Point(152, 123);
            this.NgaySinhTextBox.Name = "NgaySinhTextBox";
            this.NgaySinhTextBox.Size = new System.Drawing.Size(425, 26);
            this.NgaySinhTextBox.TabIndex = 20;
            // 
            // PhaiNuRadioButton
            // 
            this.PhaiNuRadioButton.AutoSize = true;
            this.PhaiNuRadioButton.Location = new System.Drawing.Point(286, 166);
            this.PhaiNuRadioButton.Name = "PhaiNuRadioButton";
            this.PhaiNuRadioButton.Size = new System.Drawing.Size(48, 22);
            this.PhaiNuRadioButton.TabIndex = 19;
            this.PhaiNuRadioButton.TabStop = true;
            this.PhaiNuRadioButton.Text = "Nữ";
            this.PhaiNuRadioButton.UseVisualStyleBackColor = true;
            // 
            // btnThemNhanVien
            // 
            this.btnThemNhanVien.BackColor = System.Drawing.Color.Blue;
            this.btnThemNhanVien.Enabled = false;
            this.btnThemNhanVien.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnThemNhanVien.Location = new System.Drawing.Point(409, 370);
            this.btnThemNhanVien.Name = "btnThemNhanVien";
            this.btnThemNhanVien.Size = new System.Drawing.Size(166, 39);
            this.btnThemNhanVien.TabIndex = 5;
            this.btnThemNhanVien.Text = "Lưu nhân viên";
            this.btnThemNhanVien.UseVisualStyleBackColor = false;
            this.btnThemNhanVien.Click += new System.EventHandler(this.btnThemNhanVien_Click);
            // 
            // PhaiNamRadioButton
            // 
            this.PhaiNamRadioButton.AutoSize = true;
            this.PhaiNamRadioButton.Location = new System.Drawing.Point(152, 166);
            this.PhaiNamRadioButton.Name = "PhaiNamRadioButton";
            this.PhaiNamRadioButton.Size = new System.Drawing.Size(60, 22);
            this.PhaiNamRadioButton.TabIndex = 19;
            this.PhaiNamRadioButton.TabStop = true;
            this.PhaiNamRadioButton.Text = "Nam";
            this.PhaiNamRadioButton.UseVisualStyleBackColor = true;
            // 
            // LuongCoBanTextBox
            // 
            this.LuongCoBanTextBox.Location = new System.Drawing.Point(152, 334);
            this.LuongCoBanTextBox.Name = "LuongCoBanTextBox";
            this.LuongCoBanTextBox.Size = new System.Drawing.Size(425, 26);
            this.LuongCoBanTextBox.TabIndex = 11;
            // 
            // DiaChiTextBox
            // 
            this.DiaChiTextBox.Location = new System.Drawing.Point(152, 291);
            this.DiaChiTextBox.Name = "DiaChiTextBox";
            this.DiaChiTextBox.Size = new System.Drawing.Size(425, 26);
            this.DiaChiTextBox.TabIndex = 12;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(152, 248);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(425, 26);
            this.EmailTextBox.TabIndex = 13;
            // 
            // SoDienThoaiTextBox
            // 
            this.SoDienThoaiTextBox.Location = new System.Drawing.Point(152, 205);
            this.SoDienThoaiTextBox.Name = "SoDienThoaiTextBox";
            this.SoDienThoaiTextBox.Size = new System.Drawing.Size(425, 26);
            this.SoDienThoaiTextBox.TabIndex = 14;
            // 
            // TenNhanVienTextBox
            // 
            this.TenNhanVienTextBox.Location = new System.Drawing.Point(152, 76);
            this.TenNhanVienTextBox.Name = "TenNhanVienTextBox";
            this.TenNhanVienTextBox.Size = new System.Drawing.Size(425, 26);
            this.TenNhanVienTextBox.TabIndex = 17;
            // 
            // MaNhanVienTextBox
            // 
            this.MaNhanVienTextBox.Location = new System.Drawing.Point(152, 33);
            this.MaNhanVienTextBox.Name = "MaNhanVienTextBox";
            this.MaNhanVienTextBox.ReadOnly = true;
            this.MaNhanVienTextBox.Size = new System.Drawing.Size(425, 26);
            this.MaNhanVienTextBox.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "Giới tính:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Lương cơ bản:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số điện thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên nhân viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã nhân viên:";
            // 
            // pictureBoxNhanVien
            // 
            this.pictureBoxNhanVien.Image = global::PTUDTM_Supermarket_Winform.Properties.Resources._default;
            this.pictureBoxNhanVien.InitialImage = global::PTUDTM_Supermarket_Winform.Properties.Resources._default;
            this.pictureBoxNhanVien.Location = new System.Drawing.Point(26, 24);
            this.pictureBoxNhanVien.Name = "pictureBoxNhanVien";
            this.pictureBoxNhanVien.Size = new System.Drawing.Size(251, 274);
            this.pictureBoxNhanVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxNhanVien.TabIndex = 0;
            this.pictureBoxNhanVien.TabStop = false;
            // 
            // TenHinhAnhLable
            // 
            this.TenHinhAnhLable.AutoSize = true;
            this.TenHinhAnhLable.Location = new System.Drawing.Point(23, 306);
            this.TenHinhAnhLable.Name = "TenHinhAnhLable";
            this.TenHinhAnhLable.Size = new System.Drawing.Size(81, 18);
            this.TenHinhAnhLable.TabIndex = 9;
            this.TenHinhAnhLable.Text = "default.png";
            // 
            // image_list
            // 
            this.image_list.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.image_list.ImageSize = new System.Drawing.Size(16, 16);
            this.image_list.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // NhanVienFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1281, 760);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "NhanVienFrm";
            this.Text = "NhanVienFrm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listViewDsNhanVien;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxNhanVien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox MatKhauTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox LuongCoBanTextBox;
        private System.Windows.Forms.TextBox DiaChiTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox SoDienThoaiTextBox;
        private System.Windows.Forms.TextBox TenNhanVienTextBox;
        private System.Windows.Forms.TextBox MaNhanVienTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton PhaiNuRadioButton;
        private System.Windows.Forms.RadioButton PhaiNamRadioButton;
        private System.Windows.Forms.DateTimePicker NgaySinhTextBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ImageList image_list;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnChoosenFile;
        private System.Windows.Forms.Label TenHinhAnhLable;
        private System.Windows.Forms.Button btnTaoTaiKhoanMoi;
        private System.Windows.Forms.Button btnLuuTaiKhoan;
        private System.Windows.Forms.Button btnThemNhanVien;
        private System.Windows.Forms.ComboBox TaiKhoanCombobox;
    }
}