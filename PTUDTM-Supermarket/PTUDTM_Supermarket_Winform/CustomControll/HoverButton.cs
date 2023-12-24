using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CustomControll
{
    public class HoverButton:Button
    {
        public HoverButton()
            : base()
        {
            this.MouseEnter += HoverButton_MouseEnter;
            this.MouseLeave += HoverButton_MouseLeave;
            this.BackColor = Color.Blue;
        }

        void HoverButton_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        void HoverButton_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor=Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
        }
    }
}
