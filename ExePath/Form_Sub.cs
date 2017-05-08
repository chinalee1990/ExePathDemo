using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExePath
{
    public partial class Form_Sub : Form
    {
        public Form_Sub()
        {
            InitializeComponent();
        }

        private void Form_Sub_Load(object sender, EventArgs e)
        {
            listBox1.HorizontalScrollbar = true;
            string strPath1 = Environment.CurrentDirectory;
            listBox1.Items.Add("Environment.CurrentDirectory = " + strPath1);

            string strPath2 = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
            listBox1.Items.Add("MainModule.FileName = " + strPath2);

            string strPath3 = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
            strPath3 = System.IO.Path.GetDirectoryName(strPath3);
            listBox1.Items.Add("MainModule.FileName.Path = \r\n" + strPath3);

            string strPath4 = System.AppDomain.CurrentDomain.BaseDirectory;
            listBox1.Items.Add("AppDomain.CurrentDomain.BaseDirectory = " + strPath4);

            string strPath5 = Application.StartupPath;                          //获取启动了应用程序的可执行文件的路径，不包括可执行文件的名称。
            listBox1.Items.Add("Application.StartupPath = " + strPath5);

            string strPath6 = Application.ExecutablePath;                       //获取启动了应用程序的可执行文件的路径，包括可执行文件的名称。
            listBox1.Items.Add("Application.ExecutablePath = " + strPath6);


            string strPath7 = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;//获取或设置包含该应用程序的目录的名称。
            listBox1.Items.Add("AppDomain.CurrentDomain.SetupInformation.ApplicationBase = " + strPath7);

        }
    }
}
