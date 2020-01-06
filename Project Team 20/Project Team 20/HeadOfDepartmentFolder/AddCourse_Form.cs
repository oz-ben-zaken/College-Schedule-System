using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Project_Team_20.SQL_DataBase;
using Project_Team_20.Course_Folder;
using System.Data.SqlClient;

namespace Project_Team_20.HeadOfDepartmentFolder
{
    public partial class AddCourse_Form : Form
    {
        public AddCourse_Form()
        {
            InitializeComponent();
        }

        private void iTalk_Button_21_Click(object sender, EventArgs e)
        {
            String courseName = this.courseName_textBox.Text;
            int yearTaught = this.yearTaught_checkedListBox.SelectedIndex + 1;
            int semesterTaught = this.semesterTaught_checkedListBox.SelectedIndex + 1;
            Semester semester;
            String errorMsg="";
            if (courseName.Length == 0)
                errorMsg+= "\n-No course name was entered.";
            if(yearTaught_checkedListBox.SelectedItems.Count == 0)
                errorMsg += "\n-No year was choosen.";
            if (semesterTaught_checkedListBox.SelectedItems.Count == 0)
                errorMsg += "\n-No semester was choosen.";
            if (errorMsg.Length > 0)
            {
                MessageBox.Show("The following errors occured:" + errorMsg);
                return;
            }
            switch(semesterTaught)
            {
                case 1: semester = Semester.First;
                    break;
                case 2: semester = Semester.Second;
                    break;
                case 3: semester = Semester.Third;
                    break;
                default: semester = Semester.First;
                    break;
            }
            SqlConnection connection = SQLConnection.GetSqlConnection();
            if (connection == null)
            {
                MessageBox.Show("SQL connection hasn't been initialized or has been closed.");
                return;
            }
            HeadOfDepartmentSQL sql = new HeadOfDepartmentSQL(connection);

            //MessageBox.Show("Last Added Course ID= " + sql.GetLastAddedCourseID());
            sql.AddNewCourse(new Course(sql.GetLastAddedCourseID(), courseName, yearTaught, semester, false));
            this.Dispose();
        }

        private void courseName_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
