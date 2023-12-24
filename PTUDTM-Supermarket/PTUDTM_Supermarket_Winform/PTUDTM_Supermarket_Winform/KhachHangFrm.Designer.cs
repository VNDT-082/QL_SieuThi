namespace PTUDTM_Supermarket_Winform
{
    partial class KhachHangFrm
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
            this.dataGridViewKhachHang = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewPhieuBan = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.MatKhauTextBox = new System.Windows.Forms.TextBox();
            this.PhaiNuRadioButton = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.PhaiNamRadioButton = new System.Windows.Forms.RadioButton();
            this.DiaChiTextBox = new System.Windows.Forms.TextBox();
            this.SoDienThoaiTextBox = new System.Windows.Forms.TextBox();
            this.TenKhachHangTextBox = new System.Windows.Forms.TextBox();
            this.MaKhachHangTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhachHang)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhieuBan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewKhachHang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 812);
            this.panel1.TabIndex = 4;
            // 
            // dataGridViewKhachHang
            // 
            this.dataGridViewKhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewKhachHang.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewKhachHang.Name = "dataGridViewKhachHang";
            this.dataGridViewKhachHang.RowHeadersWidth = 51;
            this.dataGridViewKhachHang.RowTemplate.Height = 24;
            this.dataGridViewKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKhachHang.Size = new System.Drawing.Size(313, 812);
            this.dataGridViewKhachHang.TabIndex = 0;
            this.dataGridViewKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKhachHang_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(313, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(978, 812);
            this.panel2.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewPhieuBan);
            this.groupBox2.Location = new System.Drawing.Point(24, 377);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(942, 408);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lịch sử mua hàng";
            // 
            // dataGridViewPhieuBan
            // 
            this.dataGridViewPhieuBan.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPhieuBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhieuBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPhieuBan.Location = new System.Drawing.Point(3, 20);
            this.dataGridViewPhieuBan.Name = "dataGridViewPhieuBan";
            this.dataGridViewPhieuBan.RowHeadersWidth = 51;
            this.dataGridViewPhieuBan.RowTemplate.Height = 24;
            this.dataGridViewPhieuBan.Size = new System.Drawing.Size(936, 385);
            this.dataGridViewPhieuBan.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeleteButton);
            this.groupBox1.Controls.Add(this.UpdateButton);
            this.groupBox1.Controls.Add(this.MatKhauTextBox);
            this.groupBox1.Controls.Add(this.PhaiNuRadioButton);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.PhaiNamRadioButton);
            this.groupBox1.Controls.Add(this.DiaChiTextBox);
            this.groupBox1.Controls.Add(this.SoDienThoaiTextBox);
            this.groupBox1.Controls.Add(this.TenKhachHangTextBox);
            this.groupBox1.Controls.Add(this.MaKhachHangTextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 340);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Red;
            this.DeleteButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(462, 280);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(187, 40);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Xóa";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.Olive;
            this.UpdateButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.UpdateButton.ForeColor = System.Drawing.Color.White;
            this.UpdateButton.Location = new System.Drawing.Point(229, 280);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(187, 40);
            this.UpdateButton.TabIndex = 5;
            this.UpdateButton.Text = "Cập nhật";
            this.UpdateButton.UseVisualStyleBackColor = false;
            // 
            // MatKhauTextBox
            // 
            this.MatKhauTextBox.Location = new System.Drawing.Point(171, 234);
            this.MatKhauTextBox.Name = "MatKhauTextBox";
            this.MatKhauTextBox.Size = new System.Drawing.Size(478, 24);
            this.MatKhauTextBox.TabIndex = 5;
            // 
            // PhaiNuRadioButton
            // 
            this.PhaiNuRadioButton.AutoSize = true;
            this.PhaiNuRadioButton.Location = new System.Drawing.Point(322, 118);
            this.PhaiNuRadioButton.Name = "PhaiNuRadioButton";
            this.PhaiNuRadioButton.Size = new System.Drawing.Size(48, 22);
            this.PhaiNuRadioButton.TabIndex = 19;
            this.PhaiNuRadioButton.TabStop = true;
            this.PhaiNuRadioButton.Text = "Nữ";
            this.PhaiNuRadioButton.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 18);
            this.label10.TabIndex = 3;
            this.label10.Text = "Mật khẩu:";
            // 
            // PhaiNamRadioButton
            // 
            this.PhaiNamRadioButton.AutoSize = true;
            this.PhaiNamRadioButton.Location = new System.Drawing.Point(171, 118);
            this.PhaiNamRadioButton.Name = "PhaiNamRadioButton";
            this.PhaiNamRadioButton.Size = new System.Drawing.Size(61, 22);
            this.PhaiNamRadioButton.TabIndex = 19;
            this.PhaiNamRadioButton.TabStop = true;
            this.PhaiNamRadioButton.Text = "Nam";
            this.PhaiNamRadioButton.UseVisualStyleBackColor = true;
            // 
            // DiaChiTextBox
            // 
            this.DiaChiTextBox.Location = new System.Drawing.Point(171, 156);
            this.DiaChiTextBox.Name = "DiaChiTextBox";
            this.DiaChiTextBox.Size = new System.Drawing.Size(478, 24);
            this.DiaChiTextBox.TabIndex = 12;
            // 
            // SoDienThoaiTextBox
            // 
            this.SoDienThoaiTextBox.Location = new System.Drawing.Point(171, 195);
            this.SoDienThoaiTextBox.Name = "SoDienThoaiTextBox";
            this.SoDienThoaiTextBox.Size = new System.Drawing.Size(478, 24);
            this.SoDienThoaiTextBox.TabIndex = 14;
            // 
            // TenKhachHangTextBox
            // 
            this.TenKhachHangTextBox.Location = new System.Drawing.Point(171, 78);
            this.TenKhachHangTextBox.Name = "TenKhachHangTextBox";
            this.TenKhachHangTextBox.Size = new System.Drawing.Size(478, 24);
            this.TenKhachHangTextBox.TabIndex = 17;
            // 
            // MaKhachHangTextBox
            // 
            this.MaKhachHangTextBox.Location = new System.Drawing.Point(171, 39);
            this.MaKhachHangTextBox.Name = "MaKhachHangTextBox";
            this.MaKhachHangTextBox.Size = new System.Drawing.Size(478, 24);
            this.MaKhachHangTextBox.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "Giới tính:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số điện thoại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tênkhách hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã khách hàng:";
            // 
            // KhachHangFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1291, 812);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "KhachHangFrm";
            this.Text = "KhachHangFrm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhachHang)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhieuBan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewKhachHang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewPhieuBan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TextBox MatKhauTextBox;
        private System.Windows.Forms.RadioButton PhaiNuRadioButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton PhaiNamRadioButton;
        private System.Windows.Forms.TextBox DiaChiTextBox;
        private System.Windows.Forms.TextBox SoDienThoaiTextBox;
        private System.Windows.Forms.TextBox TenKhachHangTextBox;
        private System.Windows.Forms.TextBox MaKhachHangTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}