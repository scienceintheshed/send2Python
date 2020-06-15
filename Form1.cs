using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;



namespace send2Python
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }       

        private void sendToPythonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string args = string.Format(@"Full path to python script\add.py {0} {1}", txtValue1.Text, txtValue2.Text);
            string python = @"Full path to your python executable\python.exe";

            try
            {
                Process calc = new Process();
                ProcessStartInfo calcProcessStartInfo = new ProcessStartInfo
                {
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    FileName = python,
                    Arguments = args
                };

                calc.StartInfo = calcProcessStartInfo;
                calc.Start();

                StreamReader myStreamReader = calc.StandardOutput;
                string _temp = myStreamReader.ReadLine();
                txtResult.Text = _temp;
                calc.WaitForExit();
            }
            catch
            {

            }           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
