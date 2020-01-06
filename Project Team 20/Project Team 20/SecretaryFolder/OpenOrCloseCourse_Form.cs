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
    public partial class OpenOrCloseCourse_Form : Form
    {
        private Course[] allCourses;
        public OpenOrCloseCourse_Form()
        {
            InitializeComponent();
            CourseSQL.LoadCoursesToListView(ref openCourses_listView);
            openCourses_listView.FullRowSelect = true;
            closeCourses_listView.FullRowSelect = true;
            if(CourseSQL.Get_Courses() == null)
                CourseSQL.LoadAllCoursesAsObjects();
            allCourses = CourseSQL.Get_Courses();

            foreach (ListViewItem item in openCourses_listView.Items)
            { 
                for(int i = 0; i < allCourses.Length; i++)
                {
                    if(Convert.ToInt16(item.SubItems[0].Text) == allCourses[i].CourseID)
                    {
                        if(allCourses[i].IsOpen == false)
                        {
                            ListViewItem temp = item;
                            openCourses_listView.Items.Remove(item);
                            closeCourses_listView.Items.Add(item);
                        }
                        break;
                    }
                }
            }
        }

        private void leftArrow_pictureBox_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = openCourses_listView.SelectedItems[0];
                openCourses_listView.Items.Remove(openCourses_listView.SelectedItems[0]);
                closeCourses_listView.Items.Add(item);

            }
            catch (ArgumentOutOfRangeException error)
            {
                MessageBox.Show("No items were selected");
                error.ToString();
            }
        }

        private void rightArrow_pictureBox_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = closeCourses_listView.SelectedItems[0];
                closeCourses_listView.Items.Remove(closeCourses_listView.SelectedItems[0]);
                openCourses_listView.Items.Add(item);

            }
            catch (ArgumentOutOfRangeException error)
            {
                MessageBox.Show("No items were selected");
                error.ToString();
            }
        }

        private void iTalk_Button_21_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in openCourses_listView.Items)
            {
                int courseID = Convert.ToInt16(item.SubItems[0].Text);
                foreach (Course course in this.allCourses)
                {
                    if (course.CourseID == courseID)
                    {
                        course.IsOpen = true;
                        break;
                    }
                }
            }
            foreach (ListViewItem item in closeCourses_listView.Items)
            {
                int courseID = Convert.ToInt16(item.SubItems[0].Text);
                foreach (Course course in this.allCourses)
                {
                    if (course.CourseID == courseID)
                    {
                        course.IsOpen = false;
                        break;
                    }
                }
            }
            MessageBox.Show("Changes saved successfully.\n");
            this.Dispose();
        }

        public void OpenOrCloseCourse_Form_Closing(object sender, System.EventArgs e)
        {

        }
    }
}
