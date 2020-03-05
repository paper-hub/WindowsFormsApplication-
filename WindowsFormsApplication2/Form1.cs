using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 初始化窗体控件
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 注册一个事件，点击按钮打开窗体2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }
        /// <summary>
        ///把创建的静态字段与窗体相关联 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            TestClose.frm1testclose = this;
        }
    }
}
