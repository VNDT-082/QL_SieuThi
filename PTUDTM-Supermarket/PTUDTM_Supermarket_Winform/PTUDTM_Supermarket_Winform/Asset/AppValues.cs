using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTUDTM_Supermarket_Winform.Asset
{
    public class AppValues
    {
        //------------------------color
        public static Color LAVENDER = Color.FromArgb(128, 128, 255);
       // public static Color SlateBlue = Color.FromArgb(128, 128, 255);
       public static Color HEADERCOLOR= Color.FromArgb(99, 184, 255);
        public static Color ROWCHAN = Color.FromArgb(242, 242, 242);
        public static Color ROWLE = Color.White;


        public static Color BACKGROUND_COLOR = Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
        public static Color FORE_COLOR = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
        public static Color RED_COLOR = Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        public static Color NONE_COLOR = Color.Transparent;
        public static Color BLUE_COLOR = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
        public static Color LABEL_COLOR;
        //--------------------------font style
        public static Font DEFAULT_FONTSTYLE_REGULAR = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point, ((byte)(163)));
        public static Font FONT_11_REGULAR = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point, ((byte)(163)));

        public static Font DEFAULT_FONTSTYLE_BOLD = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold,
            System.Drawing.GraphicsUnit.Point, ((byte)(163)));
        public static Font FONT_11_BOLD = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold,
            System.Drawing.GraphicsUnit.Point, ((byte)(163)));
        public static Font FONT_10_BOLD = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, 
            System.Drawing.GraphicsUnit.Point, ((byte)(163)));
        public static Font FONT_14_REGULAR = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point, ((byte)(163)));
        public static Font FONT_14_BOLD= new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold,
            System.Drawing.GraphicsUnit.Point, ((byte)(163)));
        //public class WindowsDevice
        //{
        //    //Panel
        //    public static void setWidthOfCerrentPanel(int widthParent, Panel panel,float percent)
        //    {
        //        panel.Width = (int)Math.Ceiling(widthParent * percent);
        //    }
        //    public static void setHeightOfCerrentPanel(int widthParent, Panel panel, float percent)
        //    {
        //        panel.Height = (int)Math.Ceiling(widthParent * percent);
        //    }
        //    //TableLayoutPanel
        //    public static void setWidthOfCerrentTableLayoutPanel(int widthParent, TableLayoutPanel panel, float percent)
        //    {
        //        panel.Width = (int)Math.Ceiling(widthParent * percent);
        //    }
        //    public static void setHeightOfCerrentTableLayoutPanel(int widthParent, TableLayoutPanel panel, float percent)
        //    {
        //        panel.Height = (int)Math.Ceiling(widthParent * percent);
        //    }
        //}
    }
}
