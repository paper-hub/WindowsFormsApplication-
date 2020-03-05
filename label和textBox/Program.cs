using System;
using System.Collections.Generic;
using System.Diagnostics;
//using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace label和textBox
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Process current = Process.GetCurrentProcess();
            Process[] processes = Process.GetProcessesByName(current.ProcessName);

            foreach (Process item in processes)
            {
                if (item.Id!=current.Id)
                {
                    if (item.MainModule.FileName==current.MainModule.FileName)
                    {
                        MessageBox.Show("程序已启动");
                        return;
                    }
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

