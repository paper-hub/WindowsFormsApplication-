using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loveORunlove
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void love_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我也爱你呀！！！么么哒");
            this.Close();
        }
        /// <summary>
        /// 当鼠标进入按钮可见部分的时候，给按钮一个新的坐标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void unlove_MouseEnter(object sender, EventArgs e)
        {
            int x = this.ClientSize.Width - unlove.Width;
            int y = this.ClientSize.Height - unlove.Height;
            Random rdm = new Random();
            unlove.Location = new Point(rdm .Next (0,x+1),rdm .Next (0,y+1));
        }

        private void unlove_Click(object sender, EventArgs e)
        {
            MessageBox.Show("终于让你个屌丝点到了！");
            this.Close();
        }
    }
}
