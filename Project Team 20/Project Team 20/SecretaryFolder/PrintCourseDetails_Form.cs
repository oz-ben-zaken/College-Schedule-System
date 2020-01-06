using Project_Team_20.Course_Folder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Team_20.SecretaryFolder
{
    public partial class PrintCourseDetails_Form : Form
    {
        public PrintCourseDetails_Form()
        {
            InitializeComponent();
            select_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            select_comboBox.Items.Add("Course Name");
            select_comboBox.Items.Add("Course ID");
            instruction_label.Visible = false;
            textBox.Visible = false;
        }

        private void select_comboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (select_comboBox.Text == "Course Name")
            {
                instruction_label.Text = "Enter the course name to search:";
                instruction_label.Visible = true;
                textBox.Visible = true;
            }
            else if (select_comboBox.Text == "Course ID")
            {
                instruction_label.Text = "Enter the course ID to search:";
                instruction_label.Visible = true;
                textBox.Visible = true;
            }
        }

        private void search_Button_Click(object sender, EventArgs e)
        {
            if(textBox.Text.Length == 0)
            {
                MessageBox.Show("No text was entered, try again please.");
                return;
            }

            CourseSQL.LoadAllCoursesAsObjects();
            Course[] allCourses = CourseSQL.Get_Courses();

            Course result = null;
            if (select_comboBox.Text == "Course Name")
            {
                foreach(Course course in allCourses)
                {
                    if(course != null && course.CourseName == textBox.Text)
                    {
                        result = course;
                        break;
                    }
                }
            }

            else if (select_comboBox.Text == "Course ID")
            {
                int courseID;
                try
                {
                    courseID = Convert.ToInt32(textBox.Text);
                }
                catch(Exception err)
                {
                    MessageBox.Show("Course ID must be an Integer.");
                    err.ToString();
                    return;
                }
                foreach (Course course in allCourses)
                {
                    if (course != null && course.CourseID == courseID)
                    {
                        result = course;
                        break;
                    }
                }
            }

            if (result != null)
            {
                MessageBox.Show("Results:\n" +
                    "Course ID: " + result.CourseID + "\n" +
                    "Course Name: " + result.CourseName + "\n" +
                    "Year Taught: " + result.YearTaught + "\n" +
                    "Semester Taught: " + result.SemesterTaught);
            }
            else
                MessageBox.Show("No result was found.");
        }


    }
}
