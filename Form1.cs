using DisplayFormApp.DataSourceHandler;
using DisplayFormApp.utils;

namespace DisplayFormApp
{
    public partial class Form1 : Form
    {
        public List<Class> Classes { get; set; }
        private int currentDay;
        private DataSourceWrapper dataSourceWrapper { get; set; }
        enum DataGridView1Headers { Subject, InstructorName, RoomNumber, StartTime, EndTime, Date }

        public Form1(ref DataSourceWrapper wrapper)
        {
            dataSourceWrapper = wrapper;
            Classes = dataSourceWrapper.getClassesFunction();
            InitializeComponent();
        }
 
        List<Class> blankSameConsecutiveLabNames(List<Class> rows)
        {
            List<Class> newClassData = rows;

            //insert the first labs name,
            //then for the starting of a new labroom number, insert a row name.

            String previousRoomNumber = newClassData[0].RoomNumber;
            for (int i = 1; i < newClassData.Count; i++)
            {
                if (previousRoomNumber == newClassData[i].RoomNumber)
                {

                    newClassData[i].RoomNumber = null;
                }
                else
                {
                    previousRoomNumber = newClassData[i].RoomNumber;
                }
            }
            return newClassData;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            currentDay = currentDate.Day;

            updateDataSource(currentDate);

            label1.Text = currentDate.ToString();

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
      
            this.label1.Text =currentTime.ToString();

            if (currentDay != currentTime.Day)
            {
                updateDataSource(currentTime);
            } 
        }


        //updates data being displayed in the datagrid with the schedule of the current day.
        private void updateDataSource(DateTime currentTime)
        {
            currentDay = currentTime.Day;
            List<Class> classes = Classes.Where(singleClass =>  (singleClass.InstructorName == null && singleClass.Subject == null && singleClass.RoomNumber != null) || singleClass.Date.Day == currentDay).ToList();
            dataGridView1.DataSource = blankSameConsecutiveLabNames(classes);

            modifyGridView1();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        /*
        private void dataGridView1_SizeChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Height = (dataGridView1.ClientRectangle.Height - dataGridView1.ColumnHeadersHeight) / dataGridView1.Rows.Count;
            }
        }
        */


    }

    
}