using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControll
{
    public class ButtonPageNum:Button
    {
        public bool isCurrentPage { get; set; }
        public ButtonPageNum(int pageNum, bool isCurrentPage)
            : base()
        {
            this.BackColor = System.Drawing.Color.Blue;
            this.Name = "btnNum" + pageNum;
            this.Size = new System.Drawing.Size(43, 38);
            this.TabIndex = 0;
            this.Text = pageNum.ToString();
            this.UseVisualStyleBackColor = false;
            this.isCurrentPage = isCurrentPage;
        }
    }
}
