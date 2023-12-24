namespace PTUDTM_Supermarket_Winform
{
    partial class HoaDonFrm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewDsHoaDon = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TimKiemButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewChiTieHoaDon = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TrangThaiCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.xuatHoaDonButton = new System.Windows.Forms.Button();
            this.TienPhaiTraTextBox = new System.Windows.Forms.TextBox();
            this.MaKhachHangTextBox = new System.Windows.Forms.TextBox();
            this.GiamGiaTextBox = new System.Windows.Forms.TextBox();
            this.MaNhanVienTextBox = new System.Windows.Forms.TextBox();
            this.TongTienTextBox = new System.Windows.Forms.TextBox();
            this.NgayMuaTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TimKiemTextBox = new CustomControll.NumTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsHoaDon)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTieHoaDon)).BeginInit();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewDsHoaDon);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 848);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewDsHoaDon
            // 
            this.dataGridViewDsHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDsHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDsHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDsHoaDon.Location = new System.Drawing.Point(0, 124);
            this.dataGridViewDsHoaDon.Name = "dataGridViewDsHoaDon";
            this.dataGridViewDsHoaDon.ReadOnly = true;
            this.dataGridViewDsHoaDon.RowHeadersWidth = 51;
            this.dataGridViewDsHoaDon.RowTemplate.Height = 24;
            this.dataGridViewDsHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDsHoaDon.Size = new System.Drawing.Size(426, 724);
            this.dataGridViewDsHoaDon.TabIndex = 2;
            this.dataGridViewDsHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDsHoaDon_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(426, 124);
            this.panel3.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TimKiemTextBox);
            this.groupBox1.Controls.Add(this.TimKiemButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // TimKiemButton
            // 
            this.TimKiemButton.BackColor = System.Drawing.Color.Blue;
            this.TimKiemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TimKiemButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TimKiemButton.Location = new System.Drawing.Point(210, 64);
            this.TimKiemButton.Name = "TimKiemButton";
            this.TimKiemButton.Size = new System.Drawing.Size(194, 42);
            this.TimKiemButton.TabIndex = 1;
            this.TimKiemButton.Text = "Tìm kiếm";
            this.TimKiemButton.UseVisualStyleBackColor = false;
            this.TimKiemButton.Click += new System.EventHandler(this.TimKiemButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewChiTieHoaDon);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(426, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(841, 848);
            this.panel2.TabIndex = 1;
            // 
            // dataGridViewChiTieHoaDon
            // 
            this.dataGridViewChiTieHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewChiTieHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChiTieHoaDon.Location = new System.Drawing.Point(37, 264);
            this.dataGridViewChiTieHoaDon.Name = "dataGridViewChiTieHoaDon";
            this.dataGridViewChiTieHoaDon.ReadOnly = true;
            this.dataGridViewChiTieHoaDon.RowHeadersWidth = 51;
            this.dataGridViewChiTieHoaDon.RowTemplate.Height = 24;
            this.dataGridViewChiTieHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewChiTieHoaDon.Size = new System.Drawing.Size(792, 572);
            this.dataGridViewChiTieHoaDon.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(841, 258);
            this.panel4.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TrangThaiCheckBox);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.xuatHoaDonButton);
            this.groupBox2.Controls.Add(this.TienPhaiTraTextBox);
            this.groupBox2.Controls.Add(this.MaKhachHangTextBox);
            this.groupBox2.Controls.Add(this.GiamGiaTextBox);
            this.groupBox2.Controls.Add(this.MaNhanVienTextBox);
            this.groupBox2.Controls.Add(this.TongTienTextBox);
            this.groupBox2.Controls.Add(this.NgayMuaTextBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.IdTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(841, 258);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết phiếu bán";
            // 
            // TrangThaiCheckBox
            // 
            this.TrangThaiCheckBox.AutoSize = true;
            this.TrangThaiCheckBox.Location = new System.Drawing.Point(557, 155);
            this.TrangThaiCheckBox.Name = "TrangThaiCheckBox";
            this.TrangThaiCheckBox.Size = new System.Drawing.Size(88, 22);
            this.TrangThaiCheckBox.TabIndex = 2;
            this.TrangThaiCheckBox.Text = "Đã duyệt";
            this.TrangThaiCheckBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(281, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Duyệt hóa đơn";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // xuatHoaDonButton
            // 
            this.xuatHoaDonButton.BackColor = System.Drawing.Color.Red;
            this.xuatHoaDonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xuatHoaDonButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.xuatHoaDonButton.Location = new System.Drawing.Point(557, 199);
            this.xuatHoaDonButton.Name = "xuatHoaDonButton";
            this.xuatHoaDonButton.Size = new System.Drawing.Size(244, 42);
            this.xuatHoaDonButton.TabIndex = 1;
            this.xuatHoaDonButton.Text = "Xóa hóa đơn";
            this.xuatHoaDonButton.UseVisualStyleBackColor = false;
            this.xuatHoaDonButton.Click += new System.EventHandler(this.xuatHoaDonButton_Click);
            // 
            // TienPhaiTraTextBox
            // 
            this.TienPhaiTraTextBox.Location = new System.Drawing.Point(558, 115);
            this.TienPhaiTraTextBox.Name = "TienPhaiTraTextBox";
            this.TienPhaiTraTextBox.Size = new System.Drawing.Size(244, 24);
            this.TienPhaiTraTextBox.TabIndex = 1;
            // 
            // MaKhachHangTextBox
            // 
            this.MaKhachHangTextBox.Location = new System.Drawing.Point(152, 154);
            this.MaKhachHangTextBox.Name = "MaKhachHangTextBox";
            this.MaKhachHangTextBox.Size = new System.Drawing.Size(244, 24);
            this.MaKhachHangTextBox.TabIndex = 1;
            // 
            // GiamGiaTextBox
            // 
            this.GiamGiaTextBox.Location = new System.Drawing.Point(558, 76);
            this.GiamGiaTextBox.Name = "GiamGiaTextBox";
            this.GiamGiaTextBox.Size = new System.Drawing.Size(244, 24);
            this.GiamGiaTextBox.TabIndex = 1;
            // 
            // MaNhanVienTextBox
            // 
            this.MaNhanVienTextBox.Location = new System.Drawing.Point(152, 115);
            this.MaNhanVienTextBox.Name = "MaNhanVienTextBox";
            this.MaNhanVienTextBox.Size = new System.Drawing.Size(244, 24);
            this.MaNhanVienTextBox.TabIndex = 1;
            // 
            // TongTienTextBox
            // 
            this.TongTienTextBox.Location = new System.Drawing.Point(558, 37);
            this.TongTienTextBox.Name = "TongTienTextBox";
            this.TongTienTextBox.Size = new System.Drawing.Size(244, 24);
            this.TongTienTextBox.TabIndex = 1;
            // 
            // NgayMuaTextBox
            // 
            this.NgayMuaTextBox.Location = new System.Drawing.Point(152, 76);
            this.NgayMuaTextBox.Name = "NgayMuaTextBox";
            this.NgayMuaTextBox.Size = new System.Drawing.Size(244, 24);
            this.NgayMuaTextBox.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(454, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Trạng thái:";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(152, 37);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(244, 24);
            this.IdTextBox.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(454, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tiền phải trả:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã khách hàng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(454, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giảm giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã nhân viên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(454, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng tiền:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày mua:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu bán:";
            // 
            // TimKiemTextBox
            // 
            this.TimKiemTextBox.Location = new System.Drawing.Point(12, 23);
            this.TimKiemTextBox.Name = "TimKiemTextBox";
            this.TimKiemTextBox.Size = new System.Drawing.Size(392, 24);
            this.TimKiemTextBox.TabIndex = 2;
            // 
            // HoaDonFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1267, 848);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "HoaDonFrm";
            this.Text = "HoaDonFrm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsHoaDon)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTieHoaDon)).EndInit();
            this.panel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button TimKiemButton;
        private System.Windows.Forms.DataGridView dataGridViewChiTieHoaDon;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TienPhaiTraTextBox;
        private System.Windows.Forms.TextBox MaKhachHangTextBox;
        private System.Windows.Forms.TextBox GiamGiaTextBox;
        private System.Windows.Forms.TextBox MaNhanVienTextBox;
        private System.Windows.Forms.TextBox TongTienTextBox;
        private System.Windows.Forms.TextBox NgayMuaTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button xuatHoaDonButton;
        private System.Windows.Forms.DataGridView dataGridViewDsHoaDon;
        private System.Windows.Forms.CheckBox TrangThaiCheckBox;
        private System.Windows.Forms.Button button1;
        private CustomControll.NumTextBox TimKiemTextBox;
    }
}