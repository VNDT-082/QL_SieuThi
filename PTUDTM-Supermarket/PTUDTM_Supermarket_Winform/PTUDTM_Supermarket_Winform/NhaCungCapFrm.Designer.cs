namespace PTUDTM_Supermarket_Winform
{
    partial class NhaCungCapFrm
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
            this.btnThem = new System.Windows.Forms.Button();
            this.DiaChiTextBox = new System.Windows.Forms.TextBox();
            this.MaNhaCungCapTextBox = new System.Windows.Forms.TextBox();
            this.TenNhaCungCapTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SoDienThoaiTextBox = new CustomControll.NumTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EmailTextBox = new CustomControll.EmailTextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.EmailTextBox);
            this.panel1.Controls.Add(this.SoDienThoaiTextBox);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.DiaChiTextBox);
            this.panel1.Controls.Add(this.MaNhaCungCapTextBox);
            this.panel1.Controls.Add(this.TenNhaCungCapTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 282);
            this.panel1.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Blue;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Location = new System.Drawing.Point(72, 182);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(245, 42);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm nhà cung cấp";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // DiaChiTextBox
            // 
            this.DiaChiTextBox.Location = new System.Drawing.Point(186, 77);
            this.DiaChiTextBox.Name = "DiaChiTextBox";
            this.DiaChiTextBox.Size = new System.Drawing.Size(236, 24);
            this.DiaChiTextBox.TabIndex = 1;
            // 
            // MaNhaCungCapTextBox
            // 
            this.MaNhaCungCapTextBox.BackColor = System.Drawing.Color.White;
            this.MaNhaCungCapTextBox.Location = new System.Drawing.Point(186, 29);
            this.MaNhaCungCapTextBox.Name = "MaNhaCungCapTextBox";
            this.MaNhaCungCapTextBox.ReadOnly = true;
            this.MaNhaCungCapTextBox.Size = new System.Drawing.Size(236, 24);
            this.MaNhaCungCapTextBox.TabIndex = 1;
            // 
            // TenNhaCungCapTextBox
            // 
            this.TenNhaCungCapTextBox.Location = new System.Drawing.Point(600, 29);
            this.TenNhaCungCapTextBox.Name = "TenNhaCungCapTextBox";
            this.TenNhaCungCapTextBox.Size = new System.Drawing.Size(236, 24);
            this.TenNhaCungCapTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên nhà cung cấp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhà cung cấp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(465, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số điện thoại:";
            // 
            // SoDienThoaiTextBox
            // 
            this.SoDienThoaiTextBox.Location = new System.Drawing.Point(600, 77);
            this.SoDienThoaiTextBox.Name = "SoDienThoaiTextBox";
            this.SoDienThoaiTextBox.Size = new System.Drawing.Size(236, 24);
            this.SoDienThoaiTextBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(465, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(600, 125);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(236, 24);
            this.EmailTextBox.TabIndex = 5;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Olive;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(331, 182);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(245, 42);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Sửa nhà cung cấp";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.Location = new System.Drawing.Point(590, 182);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(245, 42);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa nhà cung cấp";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // NhaCungCapFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 282);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "NhaCungCapFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NhaCungCapFrm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox DiaChiTextBox;
        private System.Windows.Forms.TextBox MaNhaCungCapTextBox;
        private System.Windows.Forms.TextBox TenNhaCungCapTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControll.NumTextBox SoDienThoaiTextBox;
        private CustomControll.EmailTextBox EmailTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnUpdate;
    }
}