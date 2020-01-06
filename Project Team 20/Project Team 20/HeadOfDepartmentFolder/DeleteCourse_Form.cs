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
   
    public partial class DeleteCourse_Form : Form
    {
        private SqlConnection sqlConnection;
        public DeleteCourse_Form()
        {
            InitializeComponent();
            CourseSQL.LoadCoursesToListView(ref this.listView);
            this.sqlConnection = SQLConnection.GetSqlConnection();
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
            HeadOfDepartmentSQL headOfDepartmentSql = new HeadOfDepartmentSQL(this.sqlConnection);
            int courseID;
            try
            {
                courseID = Convert.ToInt16(this.listView.SelectedItems[0].SubItems[0].Text);
            }
            catch(Exception errorMsg)
            {
                MessageBox.Show(errorMsg.Message);
                return;
            }
            headOfDepartmentSql.DeleteCourse(courseID);
            CourseSQL.LoadCoursesToListView(ref this.listView);
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
