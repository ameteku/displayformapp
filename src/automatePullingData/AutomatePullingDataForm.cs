using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SharePoint;

namespace DisplayFormApp.src
{
    public partial class AutomatePullingDataForm : Form
    {
       
        public AutomatePullingDataForm()
        {
            InitializeComponent();
        }

       public List<Class> getClasses()
        {
            List<Class> classes = new List<Class>();
            return classes;
        }

        private void onPullDataButtonClicked()

        {
            Console.WriteLine("Attempting to log in");

        }

        private void AutomatePullingDataForm_Load(object sender, EventArgs e)
        {

        }
    }
}
