using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExePathDemo_Call
{
    public partial class Form_Call : Form
    {
        public Form_Call()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            System.Diagnostics.Process process = System.Diagnostics.Process.Start(dlg.FileName);
            process.WaitForExit();
        }
    }
}
