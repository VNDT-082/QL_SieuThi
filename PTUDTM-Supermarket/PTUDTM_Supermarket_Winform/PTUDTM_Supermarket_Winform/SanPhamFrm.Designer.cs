namespace PTUDTM_Supermarket_Winform
{
    partial class SanPhamFrm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listViewSanPham = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnChiTietSanPhamNhap = new System.Windows.Forms.Panel();
            this.edtDVT = new System.Windows.Forms.ComboBox();
            this.edtLoaiSP = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemThem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.itemXem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemReload = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChoosenFile = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.btnUploadHinh = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.edtGiaSP = new System.Windows.Forms.TextBox();
            this.edtMoTa = new System.Windows.Forms.TextBox();
            this.edtSLT = new System.Windows.Forms.TextBox();
            this.edtTenSP = new System.Windows.Forms.TextBox();
            this.edtMaSP = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.image_list = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnChiTietSanPhamNhap.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1319, 71);
            this.panel2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(449, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(287, 24);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GhostWhite;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(747, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tìm sản phẩm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listViewSanPham);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1319, 712);
            this.panel1.TabIndex = 3;
            // 
            // listViewSanPham
            // 
            this.listViewSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewSanPham.FullRowSelect = true;
            this.listViewSanPham.HideSelection = false;
            this.listViewSanPham.Location = new System.Drawing.Point(0, 277);
            this.listViewSanPham.Name = "listViewSanPham";
            this.listViewSanPham.Size = new System.Drawing.Size(1319, 435);
            this.listViewSanPham.TabIndex = 1;
            this.listViewSanPham.UseCompatibleStateImageBehavior = false;
            this.listViewSanPham.View = System.Windows.Forms.View.Details;
            this.listViewSanPham.SelectedIndexChanged += new System.EventHandler(this.listViewSanPham_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnChiTietSanPhamNhap);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1319, 277);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // pnChiTietSanPhamNhap
            // 
            this.pnChiTietSanPhamNhap.Controls.Add(this.edtDVT);
            this.pnChiTietSanPhamNhap.Controls.Add(this.edtLoaiSP);
            this.pnChiTietSanPhamNhap.Controls.Add(this.btnChoosenFile);
            this.pnChiTietSanPhamNhap.Controls.Add(this.pictureBox1);
            this.pnChiTietSanPhamNhap.Controls.Add(this.panel3);
            this.pnChiTietSanPhamNhap.Controls.Add(this.btnUploadHinh);
            this.pnChiTietSanPhamNhap.Controls.Add(this.AddButton);
            this.pnChiTietSanPhamNhap.Controls.Add(this.UpdateButton);
            this.pnChiTietSanPhamNhap.Controls.Add(this.DeleteButton);
            this.pnChiTietSanPhamNhap.Controls.Add(this.edtGiaSP);
            this.pnChiTietSanPhamNhap.Controls.Add(this.edtMoTa);
            this.pnChiTietSanPhamNhap.Controls.Add(this.edtSLT);
            this.pnChiTietSanPhamNhap.Controls.Add(this.edtTenSP);
            this.pnChiTietSanPhamNhap.Controls.Add(this.edtMaSP);
            this.pnChiTietSanPhamNhap.Controls.Add(this.label13);
            this.pnChiTietSanPhamNhap.Controls.Add(this.label12);
            this.pnChiTietSanPhamNhap.Controls.Add(this.label11);
            this.pnChiTietSanPhamNhap.Controls.Add(this.label10);
            this.pnChiTietSanPhamNhap.Controls.Add(this.label9);
            this.pnChiTietSanPhamNhap.Controls.Add(this.label8);
            this.pnChiTietSanPhamNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnChiTietSanPhamNhap.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.pnChiTietSanPhamNhap.Location = new System.Drawing.Point(3, 20);
            this.pnChiTietSanPhamNhap.Name = "pnChiTietSanPhamNhap";
            this.pnChiTietSanPhamNhap.Size = new System.Drawing.Size(1313, 251);
            this.pnChiTietSanPhamNhap.TabIndex = 2;
            // 
            // edtDVT
            // 
            this.edtDVT.FormattingEnabled = true;
            this.edtDVT.Location = new System.Drawing.Point(861, 34);
            this.edtDVT.Name = "edtDVT";
            this.edtDVT.Size = new System.Drawing.Size(100, 26);
            this.edtDVT.TabIndex = 8;
            // 
            // edtLoaiSP
            // 
            this.edtLoaiSP.ContextMenuStrip = this.contextMenuStrip1;
            this.edtLoaiSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edtLoaiSP.FormattingEnabled = true;
            this.edtLoaiSP.Location = new System.Drawing.Point(125, 74);
            this.edtLoaiSP.Name = "edtLoaiSP";
            this.edtLoaiSP.Size = new System.Drawing.Size(262, 26);
            this.edtLoaiSP.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemThem,
            this.itemXoa,
            this.itemXem,
            this.itemReload});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(206, 100);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // itemThem
            // 
            this.itemThem.Name = "itemThem";
            this.itemThem.Size = new System.Drawing.Size(205, 24);
            this.itemThem.Text = "Thêm một loại mới";
            // 
            // itemXoa
            // 
            this.itemXoa.Name = "itemXoa";
            this.itemXoa.Size = new System.Drawing.Size(205, 24);
            this.itemXoa.Text = "Xóa loại hiện tại";
            // 
            // itemXem
            // 
            this.itemXem.Name = "itemXem";
            this.itemXem.Size = new System.Drawing.Size(205, 24);
            this.itemXem.Text = "Xem chi tiết";
            // 
            // itemReload
            // 
            this.itemReload.Name = "itemReload";
            this.itemReload.Size = new System.Drawing.Size(205, 24);
            this.itemReload.Text = "Tải lại";
            // 
            // btnChoosenFile
            // 
            this.btnChoosenFile.BackgroundImage = global::PTUDTM_Supermarket_Winform.Properties.Resources.btnFind;
            this.btnChoosenFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChoosenFile.Location = new System.Drawing.Point(1246, 164);
            this.btnChoosenFile.Name = "btnChoosenFile";
            this.btnChoosenFile.Size = new System.Drawing.Size(58, 40);
            this.btnChoosenFile.TabIndex = 7;
            this.btnChoosenFile.UseVisualStyleBackColor = true;
            this.btnChoosenFile.Click += new System.EventHandler(this.btnChoosenFile_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PTUDTM_Supermarket_Winform.Properties.Resources._default;
            this.pictureBox1.Location = new System.Drawing.Point(1062, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.label14);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 210);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1313, 41);
            this.panel3.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Location = new System.Drawing.Point(483, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(181, 18);
            this.label14.TabIndex = 0;
            this.label14.Text = "DANH SÁCH SẢN PHẨM";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUploadHinh
            // 
            this.btnUploadHinh.BackColor = System.Drawing.Color.Blue;
            this.btnUploadHinh.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUploadHinh.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUploadHinh.Location = new System.Drawing.Point(1062, 165);
            this.btnUploadHinh.Name = "btnUploadHinh";
            this.btnUploadHinh.Size = new System.Drawing.Size(178, 38);
            this.btnUploadHinh.TabIndex = 2;
            this.btnUploadHinh.Text = "Tải ảnh lên";
            this.btnUploadHinh.UseVisualStyleBackColor = false;
            this.btnUploadHinh.Click += new System.EventHandler(this.btnUploadHinh_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Blue;
            this.AddButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.AddButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AddButton.Location = new System.Drawing.Point(166, 166);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(221, 38);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Thêm";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.Olive;
            this.UpdateButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.UpdateButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.UpdateButton.Location = new System.Drawing.Point(457, 166);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(221, 38);
            this.UpdateButton.TabIndex = 2;
            this.UpdateButton.Text = "Cập nhật";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Red;
            this.DeleteButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DeleteButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DeleteButton.Location = new System.Drawing.Point(761, 166);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(221, 38);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Xóa";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // edtGiaSP
            // 
            this.edtGiaSP.BackColor = System.Drawing.Color.White;
            this.edtGiaSP.Location = new System.Drawing.Point(562, 34);
            this.edtGiaSP.Name = "edtGiaSP";
            this.edtGiaSP.Size = new System.Drawing.Size(64, 26);
            this.edtGiaSP.TabIndex = 1;
            // 
            // edtMoTa
            // 
            this.edtMoTa.Location = new System.Drawing.Point(861, 71);
            this.edtMoTa.Name = "edtMoTa";
            this.edtMoTa.Size = new System.Drawing.Size(100, 26);
            this.edtMoTa.TabIndex = 1;
            // 
            // edtSLT
            // 
            this.edtSLT.BackColor = System.Drawing.Color.White;
            this.edtSLT.Location = new System.Drawing.Point(562, 74);
            this.edtSLT.Name = "edtSLT";
            this.edtSLT.Size = new System.Drawing.Size(64, 26);
            this.edtSLT.TabIndex = 1;
            // 
            // edtTenSP
            // 
            this.edtTenSP.BackColor = System.Drawing.Color.White;
            this.edtTenSP.Location = new System.Drawing.Point(176, 34);
            this.edtTenSP.Name = "edtTenSP";
            this.edtTenSP.Size = new System.Drawing.Size(211, 26);
            this.edtTenSP.TabIndex = 1;
            // 
            // edtMaSP
            // 
            this.edtMaSP.BackColor = System.Drawing.Color.White;
            this.edtMaSP.Location = new System.Drawing.Point(125, 34);
            this.edtMaSP.Name = "edtMaSP";
            this.edtMaSP.ReadOnly = true;
            this.edtMaSP.Size = new System.Drawing.Size(45, 26);
            this.edtMaSP.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(744, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 18);
            this.label13.TabIndex = 0;
            this.label13.Text = "Mô tả:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(454, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "Số lượng tồn:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(454, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "Giá:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Loại sản phẩm:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tên sản phẩm:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(744, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Đơn vị tính:";
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
            // SanPhamFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1319, 783);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "SanPhamFrm";
            this.Text = "SanPhamFrm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.pnChiTietSanPhamNhap.ResumeLayout(false);
            this.pnChiTietSanPhamNhap.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnChiTietSanPhamNhap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox edtGiaSP;
        private System.Windows.Forms.TextBox edtMoTa;
        private System.Windows.Forms.TextBox edtSLT;
        private System.Windows.Forms.TextBox edtTenSP;
        private System.Windows.Forms.TextBox edtMaSP;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView listViewSanPham;
        private System.Windows.Forms.Button btnChoosenFile;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.ImageList image_list;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox edtLoaiSP;
        private System.Windows.Forms.ComboBox edtDVT;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itemThem;
        private System.Windows.Forms.ToolStripMenuItem itemXoa;
        private System.Windows.Forms.ToolStripMenuItem itemXem;
        private System.Windows.Forms.Button btnUploadHinh;
        private System.Windows.Forms.ToolStripMenuItem itemReload;
    }
}