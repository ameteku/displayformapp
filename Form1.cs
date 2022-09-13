using DisplayFormApp.utils;

namespace DisplayFormApp
{
    public partial class Form1 : Form
    {
        public List<Class> Classes { get; set; }
        public List<Class> UnfilteredClasses { get; set; }
        private int currentDay;
        enum DataGridView1Headers { Subject, InstructorName, RoomNumber, StartTime, EndTime, Date }

        public Form1()
        {
            Classes = getClasses();
            InitializeComponent();
        }
 
        private List<Class> getClasses()
        {

            string path = Form2.ScheduleFolderPath; 
           
            string path101 = path + @"\Schedule101.CSV";
            string path106 = path + @"\Schedule106.CSV";
            string path176 = path + @"\Schedule176.CSV";

            // Create Stream Reader
            StreamReader reader = null;

            List<Class> classes = new List<Class>();
            List<Class> unfilteredClasses = new List<Class>();

            string currentFilePath = null;
            string currentRoomNumber = null;

            for (int i = 0; i < 3; i++)
            {
                switch (i)
                {
                    case 0:
                        currentFilePath = path101;
                        currentRoomNumber = "101";
                        break;
                    case 1:
                        currentFilePath = path106;
                        currentRoomNumber = "106";
                        break;
                    case 2:
                        currentFilePath = path176;
                        currentRoomNumber = "176";
                        break;
                    default:
                        Console.WriteLine("Error found in the switch statement");
                        break;
                }
                try
                {
                    reader = new StreamReader(File.OpenRead(currentFilePath));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    Console.WriteLine(currentFilePath);
                }
                

                List<string> list = new List<string>();

                // Reads in header 
                var line = reader.ReadLine();

                while (!reader.EndOfStream)
                {

                    line = reader.ReadLine();

                    if (!reader.EndOfStream)
                    {
                        line += reader.ReadLine();
                    }

                    if (!reader.EndOfStream)
                    {
                        line += reader.ReadLine();
                    }

                    var records = line.Split(',');

                    if (records.Length == 0 || records[0] != "\"Subject\"")
                    {
                        foreach (var item in records)
                        {
                            if (item.Length > 2)
                           {
                                list.Add(item);                             
                            }
                        }
                    }

                    classes.Add(new Class
                    {
                        
                        Subject = UtilityFunctions.removeOpenAndClosingQoutationMarks(list[0]),
                        RoomNumber = currentRoomNumber,
                        Date = DateOnly.Parse(list[1].Substring(1, list[1].Length -2 )),
                        StartTime = UtilityFunctions.toShortTimeOnlyString(UtilityFunctions.removeOpenAndClosingQoutationMarks(list[2])),
                        EndTime = UtilityFunctions.toShortTimeOnlyString(UtilityFunctions.removeOpenAndClosingQoutationMarks(list[4])),
                        InstructorName = UtilityFunctions.removeOpenAndClosingQoutationMarks(list[10]) 
                    }
                    );

                    list.Clear();
                }
                reader.Close();
            }

            classes = classes.OrderBy(o => o.RoomNumber).ThenBy(o => o.Date).ThenBy(o => o.StartTime).ToList();

            return classes;

        }

    
        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            currentDay = currentDate.Day;

            updateDataSource(currentDate);

            label1.Text = currentDate.ToString();

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            modifyGridView1();
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
            dataGridView1.DataSource = Classes.Where(singleClass => singleClass.Date.Day == currentDay).ToList();   
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