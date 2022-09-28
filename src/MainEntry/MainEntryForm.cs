using DisplayFormApp.DataSourceHandler;
using DisplayFormApp.src;

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

        void onAutomateButtonClick()
        {
            Console.WriteLine("Automate clicked");
            dataSourceWrapper = new DataSourceWrapper();
            automatePullingDataForm = new AutomatePullingDataForm();
            DialogResult result = automatePullingDataForm.ShowDialog();

            if(result == DialogResult.OK)
            {
                dataSourceWrapper.getClassesFunction = automatePullingDataForm.getClasses;
                showScheduleForm();
            }
        }

        void onManualButtonClick()
        {
            Console.Write("Manual upload clicked");
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

        private void MainHeader_Click(object sender, EventArgs e)
        {

        }

        private void scheduleOption2Button_Click(object sender, EventArgs e)
        {
            onManualButtonClick();
        }

        private void scheduleOption1Button_Click(object sender, EventArgs e)
        {
            onAutomateButtonClick();
        }
    }



}

