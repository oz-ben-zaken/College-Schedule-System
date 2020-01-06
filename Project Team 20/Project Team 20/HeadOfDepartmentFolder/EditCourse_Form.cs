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
    public partial class EditCourse_Form : Form
    {
        private SqlConnection sqlConnection;

        public EditCourse_Form()
        {
            InitializeComponent();
            CourseSQL.LoadCoursesToListView(ref this.listView);
            this.sqlConnection = SQLConnection.GetSqlConnection();
        }

        private void FormClosedHandling(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).Close();
            sender = null;
            this.Show();
        }

        private void deleteCourse_button_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("No course was selected.");
                return;
            }
            else if (listView.SelectedItems.Count > 1)
            {
                MessageBox.Show("Choose only one course to delete at the time.");
                return;
            }
            Course course= new Course();
            try
            {
                course.CourseID = Convert.ToInt16(this.listView.SelectedItems[0].SubItems[0].Text);
            }
            catch (Exception errorMsg)
            {
                MessageBox.Show(errorMsg.Message);
                return;
            }
            course.CourseName = this.listView.SelectedItems[0].SubItems[1].Text;
            try
            {
                course.YearTaught = Convert.ToInt16(this.listView.SelectedItems[0].SubItems[2].Text);
            }
            catch (Exception errorMsg)
            {
                MessageBox.Show(errorMsg.Message);
                return;
            }
            int temp;
            try
            {
                temp= Convert.ToInt16(this.listView.SelectedItems[0].SubItems[3].Text);
            }
            catch (Exception errorMsg)
            {
                MessageBox.Show(errorMsg.Message);
                return;
            }
            switch (temp)
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
            EditCourseDetail_Form editCourseDetailForm = new EditCourseDetail_Form(course);
            this.Hide();
            editCourseDetailForm.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            editCourseDetailForm.ShowDialog();
            CourseSQL.LoadCoursesToListView(ref this.listView);
        }
    }
}
