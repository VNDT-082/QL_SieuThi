namespace PTUDTM_Supermarket_Winform
{
    partial class KhuyenMaiFrm
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listViewDsSanPhamKhuyenMai = new System.Windows.Forms.ListView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listViewDsSanPham = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXoaSanPhamKhuyenMai = new System.Windows.Forms.Button();
            this.TenSanPhamTimKiem = new System.Windows.Forms.TextBox();
            this.MaSanPhamTimKiem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnThemSanPhamKhuyenMai = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TimSanPhamButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoaKhuyenMai = new System.Windows.Forms.Button();
            this.btnSuaKhuyenMai = new System.Windows.Forms.Button();
            this.ThemButton = new System.Windows.Forms.Button();
            this.NgayKetThucTextBox = new System.Windows.Forms.DateTimePicker();
            this.NgayBatDauTextBox = new System.Windows.Forms.DateTimePicker();
            this.GiaTriKhuyenMaiTextBox = new CustomControll.NumTextBox();
            this.NoiDungTextBox = new System.Windows.Forms.TextBox();
            this.MaKhuyenMaiTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listViewKhuyenMai = new System.Windows.Forms.ListView();
            this.image_list = new System.Windows.Forms.ImageList(this.components);
            this.image_list_sanphamkhuyenmai = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tảiLạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1279, 765);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listViewDsSanPhamKhuyenMai);
            this.groupBox3.Location = new System.Drawing.Point(436, 234);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(404, 522);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách sản phẩm khuyến mãi";
            // 
            // listViewDsSanPhamKhuyenMai
            // 
            this.listViewDsSanPhamKhuyenMai.FullRowSelect = true;
            this.listViewDsSanPhamKhuyenMai.GridLines = true;
            this.listViewDsSanPhamKhuyenMai.HideSelection = false;
            this.listViewDsSanPhamKhuyenMai.Location = new System.Drawing.Point(11, 23);
            this.listViewDsSanPhamKhuyenMai.Name = "listViewDsSanPhamKhuyenMai";
            this.listViewDsSanPhamKhuyenMai.Size = new System.Drawing.Size(387, 493);
            this.listViewDsSanPhamKhuyenMai.TabIndex = 0;
            this.listViewDsSanPhamKhuyenMai.UseCompatibleStateImageBehavior = false;
            this.listViewDsSanPhamKhuyenMai.View = System.Windows.Forms.View.Details;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listViewDsSanPham);
            this.groupBox4.Location = new System.Drawing.Point(23, 391);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(404, 365);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách sản phẩm cửa hàng";
            // 
            // listViewDsSanPham
            // 
            this.listViewDsSanPham.ContextMenuStrip = this.contextMenuStrip1;
            this.listViewDsSanPham.FullRowSelect = true;
            this.listViewDsSanPham.GridLines = true;
            this.listViewDsSanPham.HideSelection = false;
            this.listViewDsSanPham.Location = new System.Drawing.Point(6, 23);
            this.listViewDsSanPham.Name = "listViewDsSanPham";
            this.listViewDsSanPham.Size = new System.Drawing.Size(387, 339);
            this.listViewDsSanPham.TabIndex = 0;
            this.listViewDsSanPham.UseCompatibleStateImageBehavior = false;
            this.listViewDsSanPham.View = System.Windows.Forms.View.Details;
            this.listViewDsSanPham.SelectedIndexChanged += new System.EventHandler(this.listViewDsSanPham_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXoaSanPhamKhuyenMai);
            this.groupBox2.Controls.Add(this.TenSanPhamTimKiem);
            this.groupBox2.Controls.Add(this.MaSanPhamTimKiem);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnThemSanPhamKhuyenMai);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TimSanPhamButton);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(23, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 151);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sản phẩm";
            // 
            // btnXoaSanPhamKhuyenMai
            // 
            this.btnXoaSanPhamKhuyenMai.BackColor = System.Drawing.Color.Red;
            this.btnXoaSanPhamKhuyenMai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaSanPhamKhuyenMai.ForeColor = System.Drawing.Color.White;
            this.btnXoaSanPhamKhuyenMai.Location = new System.Drawing.Point(209, 101);
            this.btnXoaSanPhamKhuyenMai.Name = "btnXoaSanPhamKhuyenMai";
            this.btnXoaSanPhamKhuyenMai.Size = new System.Drawing.Size(186, 38);
            this.btnXoaSanPhamKhuyenMai.TabIndex = 4;
            this.btnXoaSanPhamKhuyenMai.Text = "Xóa";
            this.btnXoaSanPhamKhuyenMai.UseVisualStyleBackColor = false;
            // 
            // TenSanPhamTimKiem
            // 
            this.TenSanPhamTimKiem.Location = new System.Drawing.Point(124, 58);
            this.TenSanPhamTimKiem.Name = "TenSanPhamTimKiem";
            this.TenSanPhamTimKiem.Size = new System.Drawing.Size(269, 24);
            this.TenSanPhamTimKiem.TabIndex = 1;
            // 
            // MaSanPhamTimKiem
            // 
            this.MaSanPhamTimKiem.Location = new System.Drawing.Point(124, 23);
            this.MaSanPhamTimKiem.Name = "MaSanPhamTimKiem";
            this.MaSanPhamTimKiem.Size = new System.Drawing.Size(174, 24);
            this.MaSanPhamTimKiem.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên sản phẩm:";
            // 
            // btnThemSanPhamKhuyenMai
            // 
            this.btnThemSanPhamKhuyenMai.BackColor = System.Drawing.Color.Blue;
            this.btnThemSanPhamKhuyenMai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemSanPhamKhuyenMai.ForeColor = System.Drawing.Color.White;
            this.btnThemSanPhamKhuyenMai.Location = new System.Drawing.Point(15, 101);
            this.btnThemSanPhamKhuyenMai.Name = "btnThemSanPhamKhuyenMai";
            this.btnThemSanPhamKhuyenMai.Size = new System.Drawing.Size(186, 38);
            this.btnThemSanPhamKhuyenMai.TabIndex = 4;
            this.btnThemSanPhamKhuyenMai.Text = "Thêm";
            this.btnThemSanPhamKhuyenMai.UseVisualStyleBackColor = false;
            this.btnThemSanPhamKhuyenMai.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tìm sản phẩm:";
            // 
            // TimSanPhamButton
            // 
            this.TimSanPhamButton.BackColor = System.Drawing.Color.Blue;
            this.TimSanPhamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TimSanPhamButton.ForeColor = System.Drawing.Color.White;
            this.TimSanPhamButton.Location = new System.Drawing.Point(306, 18);
            this.TimSanPhamButton.Name = "TimSanPhamButton";
            this.TimSanPhamButton.Size = new System.Drawing.Size(89, 34);
            this.TimSanPhamButton.TabIndex = 4;
            this.TimSanPhamButton.Text = "Tìm";
            this.TimSanPhamButton.UseVisualStyleBackColor = false;
            this.TimSanPhamButton.Click += new System.EventHandler(this.TimSanPhamButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoaKhuyenMai);
            this.groupBox1.Controls.Add(this.btnSuaKhuyenMai);
            this.groupBox1.Controls.Add(this.ThemButton);
            this.groupBox1.Controls.Add(this.NgayKetThucTextBox);
            this.groupBox1.Controls.Add(this.NgayBatDauTextBox);
            this.groupBox1.Controls.Add(this.GiaTriKhuyenMaiTextBox);
            this.groupBox1.Controls.Add(this.NoiDungTextBox);
            this.groupBox1.Controls.Add(this.MaKhuyenMaiTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(817, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khuyến mãi";
            // 
            // btnXoaKhuyenMai
            // 
            this.btnXoaKhuyenMai.BackColor = System.Drawing.Color.Red;
            this.btnXoaKhuyenMai.Enabled = false;
            this.btnXoaKhuyenMai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaKhuyenMai.ForeColor = System.Drawing.Color.White;
            this.btnXoaKhuyenMai.Location = new System.Drawing.Point(696, 120);
            this.btnXoaKhuyenMai.Name = "btnXoaKhuyenMai";
            this.btnXoaKhuyenMai.Size = new System.Drawing.Size(106, 38);
            this.btnXoaKhuyenMai.TabIndex = 4;
            this.btnXoaKhuyenMai.Text = "Xóa";
            this.btnXoaKhuyenMai.UseVisualStyleBackColor = false;
            this.btnXoaKhuyenMai.Click += new System.EventHandler(this.btnXoaKhuyenMai_Click);
            // 
            // btnSuaKhuyenMai
            // 
            this.btnSuaKhuyenMai.BackColor = System.Drawing.Color.Olive;
            this.btnSuaKhuyenMai.Enabled = false;
            this.btnSuaKhuyenMai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuaKhuyenMai.ForeColor = System.Drawing.Color.White;
            this.btnSuaKhuyenMai.Location = new System.Drawing.Point(574, 120);
            this.btnSuaKhuyenMai.Name = "btnSuaKhuyenMai";
            this.btnSuaKhuyenMai.Size = new System.Drawing.Size(106, 38);
            this.btnSuaKhuyenMai.TabIndex = 4;
            this.btnSuaKhuyenMai.Text = "Sửa";
            this.btnSuaKhuyenMai.UseVisualStyleBackColor = false;
            this.btnSuaKhuyenMai.Click += new System.EventHandler(this.btnSuaKhuyenMai_Click);
            // 
            // ThemButton
            // 
            this.ThemButton.BackColor = System.Drawing.Color.Blue;
            this.ThemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ThemButton.ForeColor = System.Drawing.Color.White;
            this.ThemButton.Location = new System.Drawing.Point(452, 120);
            this.ThemButton.Name = "ThemButton";
            this.ThemButton.Size = new System.Drawing.Size(106, 38);
            this.ThemButton.TabIndex = 4;
            this.ThemButton.Text = "Thêm";
            this.ThemButton.UseVisualStyleBackColor = false;
            this.ThemButton.Click += new System.EventHandler(this.ThemButton_Click);
            // 
            // NgayKetThucTextBox
            // 
            this.NgayKetThucTextBox.Location = new System.Drawing.Point(573, 77);
            this.NgayKetThucTextBox.Name = "NgayKetThucTextBox";
            this.NgayKetThucTextBox.Size = new System.Drawing.Size(227, 24);
            this.NgayKetThucTextBox.TabIndex = 3;
            // 
            // NgayBatDauTextBox
            // 
            this.NgayBatDauTextBox.Location = new System.Drawing.Point(166, 77);
            this.NgayBatDauTextBox.Name = "NgayBatDauTextBox";
            this.NgayBatDauTextBox.Size = new System.Drawing.Size(227, 24);
            this.NgayBatDauTextBox.TabIndex = 3;
            // 
            // GiaTriKhuyenMaiTextBox
            // 
            this.GiaTriKhuyenMaiTextBox.Location = new System.Drawing.Point(166, 122);
            this.GiaTriKhuyenMaiTextBox.Name = "GiaTriKhuyenMaiTextBox";
            this.GiaTriKhuyenMaiTextBox.Size = new System.Drawing.Size(227, 24);
            this.GiaTriKhuyenMaiTextBox.TabIndex = 2;
            // 
            // NoiDungTextBox
            // 
            this.NoiDungTextBox.Location = new System.Drawing.Point(573, 32);
            this.NoiDungTextBox.Name = "NoiDungTextBox";
            this.NoiDungTextBox.Size = new System.Drawing.Size(227, 24);
            this.NoiDungTextBox.TabIndex = 1;
            // 
            // MaKhuyenMaiTextBox
            // 
            this.MaKhuyenMaiTextBox.BackColor = System.Drawing.Color.White;
            this.MaKhuyenMaiTextBox.Location = new System.Drawing.Point(166, 32);
            this.MaKhuyenMaiTextBox.Name = "MaKhuyenMaiTextBox";
            this.MaKhuyenMaiTextBox.ReadOnly = true;
            this.MaKhuyenMaiTextBox.Size = new System.Drawing.Size(227, 24);
            this.MaKhuyenMaiTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giá trị khuyến mãi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(456, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày kết thúc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày bắt đầu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(456, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nội dung:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khuyến mãi:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(846, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(433, 765);
            this.panel2.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listViewKhuyenMai);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(433, 765);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh sách khuyến mãi";
            // 
            // listViewKhuyenMai
            // 
            this.listViewKhuyenMai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewKhuyenMai.FullRowSelect = true;
            this.listViewKhuyenMai.GridLines = true;
            this.listViewKhuyenMai.HideSelection = false;
            this.listViewKhuyenMai.Location = new System.Drawing.Point(3, 20);
            this.listViewKhuyenMai.Name = "listViewKhuyenMai";
            this.listViewKhuyenMai.Size = new System.Drawing.Size(427, 742);
            this.listViewKhuyenMai.TabIndex = 1;
            this.listViewKhuyenMai.UseCompatibleStateImageBehavior = false;
            this.listViewKhuyenMai.View = System.Windows.Forms.View.Details;
            this.listViewKhuyenMai.SelectedIndexChanged += new System.EventHandler(this.listViewKhuyenMai_SelectedIndexChanged);
            // 
            // image_list
            // 
            this.image_list.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.image_list.ImageSize = new System.Drawing.Size(16, 16);
            this.image_list.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // image_list_sanphamkhuyenmai
            // 
            this.image_list_sanphamkhuyenmai.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.image_list_sanphamkhuyenmai.ImageSize = new System.Drawing.Size(16, 16);
            this.image_list_sanphamkhuyenmai.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tảiLạiToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 56);
            this.contextMenuStrip1.Click += new System.EventHandler(this.contextMenuStrip1_Click);
            // 
            // tảiLạiToolStripMenuItem
            // 
            this.tảiLạiToolStripMenuItem.Name = "tảiLạiToolStripMenuItem";
            this.tảiLạiToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.tảiLạiToolStripMenuItem.Text = "Tải lại";
            // 
            // KhuyenMaiFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1279, 765);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "KhuyenMaiFrm";
            this.Text = "KhuyenMaiFrm";
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NoiDungTextBox;
        private System.Windows.Forms.TextBox MaKhuyenMaiTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker NgayKetThucTextBox;
        private System.Windows.Forms.DateTimePicker NgayBatDauTextBox;
        private CustomControll.NumTextBox GiaTriKhuyenMaiTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXoaKhuyenMai;
        private System.Windows.Forms.Button btnSuaKhuyenMai;
        private System.Windows.Forms.Button ThemButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnXoaSanPhamKhuyenMai;
        private System.Windows.Forms.TextBox MaSanPhamTimKiem;
        private System.Windows.Forms.Button btnThemSanPhamKhuyenMai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button TimSanPhamButton;
        private System.Windows.Forms.TextBox TenSanPhamTimKiem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listViewDsSanPhamKhuyenMai;
        private System.Windows.Forms.ListView listViewDsSanPham;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ImageList image_list;
        private System.Windows.Forms.ImageList image_list_sanphamkhuyenmai;
        private System.Windows.Forms.ListView listViewKhuyenMai;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tảiLạiToolStripMenuItem;
    }
}