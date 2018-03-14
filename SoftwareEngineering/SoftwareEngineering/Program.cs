using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace SoftwareEngineering
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public List<Course> buildCourseList()
        {
            List<Course> courseDB = new List<Course>();
            using(StreamReader reader = new StreamReader("CourseDB_WithFictionalCapacities.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    string[] values =  line.Split(',');
                    courseDB.Add(new Course(values[0], values[1], values[2], Convert.ToDateTime(values[3]), Convert.ToDateTime(values[4]), values[5], values[6], values[7], int.Parse(values[8]), int.Parse(values[9]));
                }
            }
            return courseDB;
        }
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
