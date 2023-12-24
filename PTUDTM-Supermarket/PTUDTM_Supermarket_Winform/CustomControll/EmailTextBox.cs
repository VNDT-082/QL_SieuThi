using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CustomControll
{
    public class EmailTextBox:TextBox
    {
        private ErrorProvider errorProvider1;
        //public ErrorProvider err;
        public EmailTextBox()
            : base()
        {
            InitializeComponent();
            this.TextChanged += EmailTextBox_TextChanged;
        }

        void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBox textBox = (TextBox)sender;
                string text = textBox.Text;
                string pattern = "^([a-zA-Z0-9_\\-])+\\@(([a-zA-Z0-9\\-])+\\.)+([a-zA-Z0-9]{2,4})+$";
                if (!Regex.IsMatch(text, pattern))
                {
                    errorProvider1.SetError(this, "Email khong hop le!!!");
                }
                else { errorProvider1.Clear(); }
            }
            catch (Exception ex)
            {
                throw(ex);
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
