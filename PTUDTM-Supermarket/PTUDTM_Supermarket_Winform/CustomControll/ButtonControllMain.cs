using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CustomControll
{
    public class ButtonControllMain:Button
    {
        public bool Flag { get;set;}
        public ButtonControllMain()
            : base()
        {
            Flag = false;
            this.FlatAppearance.BorderColor = Color.Blue;
            this.FlatAppearance.BorderSize = 2;
            this.FlatStyle = FlatStyle.Flat;
            this.MouseLeave += ButtonControllMain_MouseLeave;
            this.MouseEnter += ButtonControllMain_MouseEnter;
        }

        void ButtonControllMain_MouseLeave(object sender, EventArgs e)
        {
            this.FlatAppearance.BorderColor = Color.Blue;
            this.FlatAppearance.BorderSize = 2;
            this.FlatStyle = FlatStyle.Flat;
            if (Flag == true)
            {
                this.BackColor = Color.MediumBlue;
            }
            else
            {
                this.BackColor = Color.Blue;
            }
            
        }

        void ButtonControllMain_MouseEnter(object sender, EventArgs e)
        {
            this.FlatAppearance.BorderColor = Color.Cyan;
            this.FlatAppearance.BorderSize = 2;
            this.FlatStyle = FlatStyle.Flat;
            this.BackColor = Color.MediumBlue;
        }
    }
}
