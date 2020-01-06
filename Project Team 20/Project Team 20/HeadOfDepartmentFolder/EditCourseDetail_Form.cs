using Project_Team_20.Course_Folder;
using Project_Team_20.SQL_DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Team_20.HeadOfDepartmentFolder
{
    public partial class EditCourseDetail_Form : Form
    {
        private Course course;
        public EditCourseDetail_Form(Course course)
        {
            this.course = course;
            InitializeComponent();
            courseName_textBox.Text = course.CourseName;
        }

        private void iTalk_Button_21_Click(object sender, EventArgs e)
        {
            String errorMsg = "";
            if(courseName_textBox.Text.Length == 0)
            {
                errorMsg += "-No course name was entered.\n";
            }
            if (yearTaught_checkedListBox.SelectedItems.Count == 0)
            {
                errorMsg += "-No year was chosen.\n";
            }
            if (semesterTaught_checkedListBox.SelectedItems.Count == 0)
            {
                errorMsg += "-No semester was chosen.\n";
            }

            if(errorMsg.Length > 0)
            {
                MessageBox.Show("The following errors occured:\n" + errorMsg);
                return;
            }
            course.CourseName = this.courseName_textBox.Text;
            course.YearTaught = this.yearTaught_checkedListBox.SelectedIndex + 1;
            int semesterTaught = this.semesterTaught_checkedListBox.SelectedIndex + 1;
            switch (semesterTaught)
            {
                case 1:
                    course.SemesterTaught = Semester.First;
                    break;
                case 2:
                    course.SemesterTaught = Semester.Second;
                    break;
                case 3:
                    course.SemesterTaught = Semester.Third;
                    break;
                default:
                    course.SemesterTaught = Semester.First;
                    break;
            } 

            MessageBox.Show("Course name = " + course.CourseName + "\n" +
                "Year Taught = " + course.YearTaught + "\n" +
                "SemesterTaught = " + course.SemesterTaught);
            SqlConnection connection = SQLConnection.GetSqlConnection();
            if (connection == null)
            {
                MessageBox.Show("SQL connection hasn't been initialized or has been closed.");
                return;
            }
            HeadOfDepartmentSQL sql = new HeadOfDepartmentSQL(connection);

            //MessageBox.Show("Last Added Course ID= " + sql.GetLastAddedCourseID());
            sql.UpdateCourse(course);
            this.Close();
        }
    }
}
