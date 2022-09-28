using DisplayFormApp.DataSourceHandler;
using DisplayFormApp.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisplayFormApp.MainEntry
{
    public partial class MainEntryForm : Form
    {
        Form1 scheduleDisplayForm;
        Form2 folderPathGetterForm;
        AutomatePullingDataForm automatePullingDataForm;
        DataSourceWrapper dataSourceWrapper;
      
        public MainEntryForm()
        {
            InitializeComponent();
        }

        void onAutomateButtonClick(Object obj, EventArgs args)
        {
            Console.WriteLine("Automate clicked");
            dataSourceWrapper = new DataSourceWrapper();
            automatePullingDataForm = new AutomatePullingDataForm(ref dataSourceWrapper);
            DialogResult result = automatePullingDataForm.ShowDialog();

            if(result == DialogResult.OK)
            {
                dataSourceWrapper.getClassesFunction = automatePullingDataForm.getClasses;
                showScheduleForm();

            }
        }

        void onManualButtonClick(Object obj, EventArgs args)
        {
            Console.Write("Manual clickeeddddd");
            dataSourceWrapper = new DataSourceWrapper();
            folderPathGetterForm = new Form2();
            DialogResult result =  folderPathGetterForm.ShowDialog();

            if(result == DialogResult.OK)
            {
                dataSourceWrapper.getClassesFunction = folderPathGetterForm.getClasses;
                showScheduleForm();
            }

        }

        void showScheduleForm()
        {
            scheduleDisplayForm = new Form1(ref dataSourceWrapper);
            scheduleDisplayForm.ShowDialog();
        }

        private void MainEntryForm_Load(object sender, EventArgs e)
        {

        }
    }



}

