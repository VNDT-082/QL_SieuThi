using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControll
{
    public class UpperCaseTextBox:TextBox
    {
        public UpperCaseTextBox()
            : base()
        {
            this.KeyPress += UpperCaseTextBox_KeyPress;
        }

        void UpperCaseTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsUpper(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
