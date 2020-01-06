using Project_Team_20.Course_Folder;
using Project_Team_20.EmployeeInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Team_20.TeachingAssistantFolder.TeachingAsForms
{
    public partial class ChooseCoursesToTeach : Form
    {
        private Course[] selfCourses;
        private EmpInterface employee;
        public ChooseCoursesToTeach(Course[] courses, ref EmpInterface emp)
        {
            InitializeComponent();
            this.employee = emp;
            this.selfCourses = courses;
            CourseSQL.LoadCoursesToListView(ref this.allCourses_listView);
            this.myCourses_listView.FullRowSelect = true;
            /*
            The following loop runs on all the available courses and removes the courses already
            chosen by the Teaching-Assistant or Lecturer and adds the items to the other 
            listview containing the chosen courses (selfCourses).
            It's done by comparing the course ID, which is a unique parameter for each course.
            */
            if(selfCourses != null)
            {
                try
                {
                    foreach (ListViewItem item in allCourses_listView.Items)
                    {
                        for (int i = 0; i < selfCourses.Length; i++)
                        {
                            if (Convert.ToInt16(item.SubItems[0].Text) == selfCourses[i].CourseID)
                            {
                                ListViewItem temp = item;
                                allCourses_listView.Items.Remove(item);
                                myCourses_listView.Items.Add(item);   
                                break;
                            }
                        }
                    }
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void leftArrow_pictureBox_Click(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show("Selected: " + allCourses_listView.SelectedItems[0]);
                ListViewItem item = allCourses_listView.SelectedItems[0];
                allCourses_listView.Items.Remove(allCourses_listView.SelectedItems[0]);
                myCourses_listView.Items.Add(item);
                
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
                ListViewItem item = myCourses_listView.SelectedItems[0];
                myCourses_listView.Items.Remove(myCourses_listView.SelectedItems[0]);
                allCourses_listView.Items.Add(item);
            }
            catch (ArgumentOutOfRangeException error)
            {
                MessageBox.Show("No items were selected");
                error.ToString();
            }
        }

        public bool IsCourseInSelfCourses(Course course)
        {
            for(int i = 0; i < this.selfCourses.Length; i++)
            {
                if (course.CourseID == selfCourses[i].CourseID)
                    return true;
            }
            return false;
        }

        private void iTalk_Button_21_Click(object sender, EventArgs e)
        {
            //this.selfCourses = null;
            //teachingAssistant.CoursesToTeach = null;

            Course[] courses = new Course[myCourses_listView.Items.Count];
            Course[] allCourses = CourseSQL.Get_Courses();
            for (int i = 0; i < courses.Length; i++)
            {
                //courses[i] = new Course();
                //courses[i].CourseID = Convert.ToInt16(myCourses_listView.Items[i].SubItems[0].Text);
                //courses[i].CourseName = myCourses_listView.Items[i].SubItems[1].Text;
                int courseId = Convert.ToInt16(myCourses_listView.Items[i].SubItems[0].Text);
                for (int j = 0; j < allCourses.Length; j++)
                {
                    if (allCourses[j].CourseID == courseId)
                    {
                        courses[i] = new Course();
                        courses[i].CourseID = allCourses[j].CourseID;
                        courses[i].CourseName = allCourses[j].CourseName;
                        courses[i].YearTaught = allCourses[j].YearTaught;
                        courses[i].SemesterTaught = allCourses[j].SemesterTaught;
                        break;
                    }
                }
            }
            this.employee.Set_CoursesToTeach(courses);
            MessageBox.Show("Changes saved successfully.");         
            this.Close();
        }

        private void allCourses_groupBox_Enter(object sender, EventArgs e)
        {

        }

        private void ChooseCoursesToTeach_Load(object sender, EventArgs e)
        {

        }
    }
}
