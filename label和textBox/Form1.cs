using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace label和textBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ////进程类
            //Process.Start("calc");
            //Process.Start("iexplore", "Http://www.baidu.com");

            //取消对跨线程操作的检查   ，即允许跨线程调用
            Control.CheckForIllegalCrossThreadCalls = false;

            label2.Text = DateTime.Now.ToString();
        }
        /// <summary>
        /// 用Timer，在指定的时间间隔内做指定的事情
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1 .Text  =label1.Text.Substring(1) + label1.Text.Substring(0, 1);
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
            //14点10分播放音乐
            if (DateTime .Now.Hour.ToString () ==textBox1.Text &&DateTime .Now .Minute.ToString ()==textBox2.Text &&DateTime .Now .Second .ToString ()==textBox3.Text)
            {
                SoundPlayer sp = new SoundPlayer();
                sp.SoundLocation = @"C:\迅雷下载\王菲+-+我和我的祖国.wav.wav";
                sp.Play();
                MessageBox.Show(闹钟属性.Text );
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 打开用户文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fg = new OpenFileDialog();
            fg.Title = "请选择要打开的文本文件！";
            //设置对话框可以多选
            fg.Multiselect = true;
            fg.ShowDialog();
        }
        Thread th;
        /// <summary>
        /// 创建新的线程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            //创建一个新线程
            th = new Thread(Test);
            //设置为后台线程
            th.IsBackground = true;
            //标记这个线程已经准备就绪了，可以随时被执行。
            th.IsBackground = true;
            th.Start();
        }
        private void Test()
        {
            for (int i = 0; i < 10000 ; i++)
            {
                //Console.WriteLine(i);
                textBox4.Text = i.ToString();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //当你点击关闭窗体的时候，判断新线程是否为null
            if (th !=null)
            {
                //终止线程   无法再被Start()
                th.Abort();
            }
        }
    }
}
