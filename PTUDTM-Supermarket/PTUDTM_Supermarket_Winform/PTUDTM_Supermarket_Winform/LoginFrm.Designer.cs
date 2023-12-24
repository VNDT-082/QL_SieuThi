namespace PTUDTM_Supermarket_Winform
{
    partial class LoginFrm
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
            this.pnMain = new System.Windows.Forms.Panel();
            this.lblForgetPass = new System.Windows.Forms.Label();
            this.showHide = new System.Windows.Forms.CheckBox();
            this.edtPass = new System.Windows.Forms.TextBox();
            this.edtUsername = new System.Windows.Forms.TextBox();
            this.hoverButton1 = new CustomControll.HoverButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnMain.Controls.Add(this.lblForgetPass);
            this.pnMain.Controls.Add(this.showHide);
            this.pnMain.Controls.Add(this.edtPass);
            this.pnMain.Controls.Add(this.edtUsername);
            this.pnMain.Controls.Add(this.hoverButton1);
            this.pnMain.Controls.Add(this.label3);
            this.pnMain.Controls.Add(this.label2);
            this.pnMain.Controls.Add(this.label1);
            this.pnMain.Location = new System.Drawing.Point(117, 131);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(448, 337);
            this.pnMain.TabIndex = 0;
            // 
            // lblForgetPass
            // 
            this.lblForgetPass.AutoSize = true;
            this.lblForgetPass.BackColor = System.Drawing.Color.Transparent;
            this.lblForgetPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgetPass.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblForgetPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblForgetPass.Location = new System.Drawing.Point(164, 301);
            this.lblForgetPass.Name = "lblForgetPass";
            this.lblForgetPass.Size = new System.Drawing.Size(111, 16);
            this.lblForgetPass.TabIndex = 7;
            this.lblForgetPass.Text = "Quên mật khẩu?";
            // 
            // showHide
            // 
            this.showHide.AutoSize = true;
            this.showHide.BackColor = System.Drawing.Color.Transparent;
            this.showHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showHide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.showHide.Location = new System.Drawing.Point(194, 188);
            this.showHide.Name = "showHide";
            this.showHide.Size = new System.Drawing.Size(130, 20);
            this.showHide.TabIndex = 6;
            this.showHide.Text = "Hiển thị mật khẩu";
            this.showHide.UseVisualStyleBackColor = false;
            this.showHide.CheckStateChanged += new System.EventHandler(this.showHide_CheckStateChanged);
            // 
            // edtPass
            // 
            this.edtPass.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.edtPass.Location = new System.Drawing.Point(194, 152);
            this.edtPass.Name = "edtPass";
            this.edtPass.Size = new System.Drawing.Size(215, 29);
            this.edtPass.TabIndex = 5;
            this.edtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edtPass_KeyPress);
            // 
            // edtUsername
            // 
            this.edtUsername.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.edtUsername.Location = new System.Drawing.Point(194, 100);
            this.edtUsername.Name = "edtUsername";
            this.edtUsername.Size = new System.Drawing.Size(215, 29);
            this.edtUsername.TabIndex = 4;
            // 
            // hoverButton1
            // 
            this.hoverButton1.BackColor = System.Drawing.Color.Blue;
            this.hoverButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hoverButton1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.hoverButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.hoverButton1.Location = new System.Drawing.Point(153, 231);
            this.hoverButton1.Name = "hoverButton1";
            this.hoverButton1.Size = new System.Drawing.Size(145, 38);
            this.hoverButton1.TabIndex = 3;
            this.hoverButton1.Text = "Đăng nhập";
            this.hoverButton1.UseVisualStyleBackColor = true;
            this.hoverButton1.Click += new System.EventHandler(this.hoverButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(154, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(31, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(31, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Tahoma", 4.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(-3, 593);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 10);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phát triển ứng dụng phần mềm thông minh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Tahoma", 4.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(-3, 604);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(424, 10);
            this.label5.TabIndex = 9;
            this.label5.Text = "Trần Văn Thắng - 2001200674 & Nguyễn Thị Ngọc Phượng - 2001206919 & Võ Nguyễn Duy" +
    " Tân - 2001200082";
            // 
            // LoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PTUDTM_Supermarket_Winform.Properties.Resources.imgLoginBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1003, 613);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LoginFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginFrm";
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControll.HoverButton hoverButton1;
        private System.Windows.Forms.TextBox edtPass;
        private System.Windows.Forms.TextBox edtUsername;
        private System.Windows.Forms.CheckBox showHide;
        private System.Windows.Forms.Label lblForgetPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}