using DisplayFormApp.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DisplayFormApp.DataSourceHandler;

namespace DisplayFormApp
{
    public partial class Form2 : Form
    {

       public static string ScheduleFolderPath;
       private Form1 displayForm;
        private DataSourceWrapper dataSource;

        public Form2(ref Form1 displayForm,ref DataSourceWrapper sourceWrapper)
        {
            this.displayForm = displayForm;
            dataSource = sourceWrapper;
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
            dataSource.getClassesFunction = getClasses;
           // displayForm = new Form1(getClasses());
            this.Close();
            if (getClasses().Count != 0)
            {
                DialogResult = DialogResult.OK;
            } else
            {
                DialogResult = DialogResult.Cancel;
            }
           // displayForm.ShowDialog();
        }

        public List<Class> getClasses()
        {

            string path = ScheduleFolderPath;

            if (path == null || path.Length == 0)
            {
                throw new ArgumentNullException("The path needed to get schedule data is null");
            }

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
                        Date = DateOnly.Parse(list[1].Replace("\"", "")),
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
    }
}
