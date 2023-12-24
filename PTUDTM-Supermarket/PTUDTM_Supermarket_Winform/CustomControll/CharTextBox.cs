using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControll
{
    public class CharTextBox:TextBox
    {
        public CharTextBox()
            : base()
        {
            this.KeyPress += CharTextBox_KeyPress;
        }

        void CharTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
