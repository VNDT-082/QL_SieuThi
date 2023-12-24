using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CustomControll
{
    public class UserTextBox:TextBox
    {
        private ErrorProvider errorProvider1;
    
        public UserTextBox()
            : base()
        {
            InitializeComponent();
            this.TextChanged += UserTextBox_TextChanged;
        }

        void UserTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string value = textBox.Text;
            foreach (char c in value)
            {
                if (char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c))
                {
                    errorProvider1.Clear();
                }
                else { 
                    errorProvider1.SetError(this, "Khong chap nhan ky tu dac biet");
                }
            } 
            
        }

        private void InitializeComponent()
        {
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
