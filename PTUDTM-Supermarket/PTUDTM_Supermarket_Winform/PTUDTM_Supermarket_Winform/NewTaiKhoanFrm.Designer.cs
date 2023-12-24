namespace PTUDTM_Supermarket_Winform
{
    partial class NewTaiKhoanFrm
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
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            this.panel1 = new System.Windows.Forms.Panel();
            this.LoaiTaiKhoanCombobox = new System.Windows.Forms.ComboBox();
            this.TrangThaiTaiKhoanCheckBox = new System.Windows.Forms.CheckBox();
            this.TenDangNhapTextBox = new System.Windows.Forms.TextBox();
            this.MatKhauTextBox = new System.Windows.Forms.TextBox();
            this.AddTaiKhoanBtn = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AddTaiKhoanBtn);
            this.panel1.Controls.Add(this.LoaiTaiKhoanCombobox);
            this.panel1.Controls.Add(this.TrangThaiTaiKhoanCheckBox);
            this.panel1.Controls.Add(label6);
            this.panel1.Controls.Add(this.TenDangNhapTextBox);
            this.panel1.Controls.Add(label7);
            this.panel1.Controls.Add(label8);
            this.panel1.Controls.Add(this.MatKhauTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 227);
            this.panel1.TabIndex = 0;
            // 
            // LoaiTaiKhoanCombobox
            // 
            this.LoaiTaiKhoanCombobox.FormattingEnabled = true;
            this.LoaiTaiKhoanCombobox.Location = new System.Drawing.Point(139, 83);
            this.LoaiTaiKhoanCombobox.Name = "LoaiTaiKhoanCombobox";
            this.LoaiTaiKhoanCombobox.Size = new System.Drawing.Size(197, 26);
            this.LoaiTaiKhoanCombobox.TabIndex = 34;
            // 
            // TrangThaiTaiKhoanCheckBox
            // 
            this.TrangThaiTaiKhoanCheckBox.AutoSize = true;
            this.TrangThaiTaiKhoanCheckBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TrangThaiTaiKhoanCheckBox.Location = new System.Drawing.Point(139, 114);
            this.TrangThaiTaiKhoanCheckBox.Name = "TrangThaiTaiKhoanCheckBox";
            this.TrangThaiTaiKhoanCheckBox.Size = new System.Drawing.Size(204, 22);
            this.TrangThaiTaiKhoanCheckBox.TabIndex = 33;
            this.TrangThaiTaiKhoanCheckBox.Text = "Tài khoản đang hoạt động";
            this.TrangThaiTaiKhoanCheckBox.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label6.Location = new System.Drawing.Point(19, 26);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(114, 18);
            label6.TabIndex = 28;
            label6.Text = "Tên đăng nhập:";
            // 
            // TenDangNhapTextBox
            // 
            this.TenDangNhapTextBox.BackColor = System.Drawing.Color.White;
            this.TenDangNhapTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TenDangNhapTextBox.Location = new System.Drawing.Point(139, 23);
            this.TenDangNhapTextBox.Name = "TenDangNhapTextBox";
            this.TenDangNhapTextBox.Size = new System.Drawing.Size(197, 26);
            this.TenDangNhapTextBox.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label7.Location = new System.Drawing.Point(19, 84);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(102, 18);
            label7.TabIndex = 30;
            label7.Text = "Loại tài khoản:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label8.Location = new System.Drawing.Point(19, 55);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(74, 18);
            label8.TabIndex = 31;
            label8.Text = "Mật khẩu:";
            // 
            // MatKhauTextBox
            // 
            this.MatKhauTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MatKhauTextBox.Location = new System.Drawing.Point(139, 53);
            this.MatKhauTextBox.Name = "MatKhauTextBox";
            this.MatKhauTextBox.Size = new System.Drawing.Size(197, 26);
            this.MatKhauTextBox.TabIndex = 32;
            // 
            // AddTaiKhoanBtn
            // 
            this.AddTaiKhoanBtn.BackColor = System.Drawing.Color.Blue;
            this.AddTaiKhoanBtn.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.AddTaiKhoanBtn.ForeColor = System.Drawing.Color.White;
            this.AddTaiKhoanBtn.Location = new System.Drawing.Point(139, 142);
            this.AddTaiKhoanBtn.Name = "AddTaiKhoanBtn";
            this.AddTaiKhoanBtn.Size = new System.Drawing.Size(197, 33);
            this.AddTaiKhoanBtn.TabIndex = 35;
            this.AddTaiKhoanBtn.Text = "Thêm tài khoản";
            this.AddTaiKhoanBtn.UseVisualStyleBackColor = false;
            this.AddTaiKhoanBtn.Click += new System.EventHandler(this.AddTaiKhoanBtn_Click);
            // 
            // NewTaiKhoanFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 227);
            this.Controls.Add(this.panel1);
            this.Name = "NewTaiKhoanFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewTaiKhoanFrm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox LoaiTaiKhoanCombobox;
        private System.Windows.Forms.CheckBox TrangThaiTaiKhoanCheckBox;
        private System.Windows.Forms.TextBox TenDangNhapTextBox;
        private System.Windows.Forms.TextBox MatKhauTextBox;
        private System.Windows.Forms.Button AddTaiKhoanBtn;
    }
}