using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisplayFormApp
{
    public partial class Form2 : Form
    {

       public static string ScheduleFolderPath;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                label4.Text = fbd.SelectedPath;
                ScheduleFolderPath = fbd.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(); //this is the change, code for redirect  
            f1.ShowDialog();
            this.Close();
        }
    }
}
