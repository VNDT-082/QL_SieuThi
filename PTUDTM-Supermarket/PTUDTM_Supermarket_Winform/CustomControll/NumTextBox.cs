using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControll
{
    public class NumTextBox:TextBox
    {
        public NumTextBox():base() 
        {
            this.KeyPress += NumTextBox_KeyPress;
        }

        void NumTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            { e.Handled = true; }
        }
    }
}
