using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControll
{
    public class WindowsDevice
    {
        public static void setWidthOfCerrentPanel(int widthParent, Panel panel, float percent)
        {
            panel.Width = (int)Math.Ceiling(widthParent * percent);
        }
        public static void setHeightOfCerrentPanel(int widthParent, Panel panel, float percent)
        {
            panel.Height = (int)Math.Ceiling(widthParent * percent);
        }
        //TableLayoutPanel
        public static void setWidthOfCerrentTableLayoutPanel(int widthParent, TableLayoutPanel panel, float percent)
        {
            panel.Width = (int)Math.Ceiling(widthParent * percent);
        }
        public static void setHeightOfCerrentTableLayoutPanel(int widthParent, TableLayoutPanel panel, float percent)
        {
            panel.Height = (int)Math.Ceiling(widthParent * percent);
        }

        public static void setWidthOfCerrentPictureBox(int widthParent, PictureBox picture, float percent)
        {
            picture.Width = (int)Math.Ceiling(widthParent * percent);
        }
        public static void setHeightOfCerrentPictureBox(int widthParent, PictureBox picture, float percent)
        {
            picture.Height = (int)Math.Ceiling(widthParent * percent);
        }

        public static void setWidthOfCerrentPanel(int widthParent, TextBox textBox, float percent)
        {
            textBox.Width = (int)Math.Ceiling(widthParent * percent);
        }

        public static void setWidthOfCerrentPanel(int widthParent, Label label, float percent)
        {
            label.Width = (int)Math.Ceiling(widthParent * percent);
        }
        public static void setHeightOfCerrentPanel(int widthParent, ListView listView, float percent)
        {
            listView.Height = (int)Math.Ceiling(widthParent * percent);
        }
    }
}
