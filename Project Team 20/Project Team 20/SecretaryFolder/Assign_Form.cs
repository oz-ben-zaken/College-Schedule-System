using Project_Team_20.Course_Folder;
using Project_Team_20.HeadOfDepartmentFolder;
using Project_Team_20.LecturerFolder;
using Project_Team_20.ScheduleFolder;
using Project_Team_20.SQL_DataBase;
using Project_Team_20.TeachingAssistantFolder.TeachingAsForms;
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
    public partial class Assign_Form : Form
    {
        String type;
        TabPage currentTabPage;
        TeachingAssistant selectedTeachingAssist;
        Lecturer selectedLecturer;
        Course selectedCourse;
        Course[] allCourses;
        Days selectedDay;
        DateTime[] assignedHours;

        public Assign_Form(String type)
        {
            InitializeComponent();
            this.type = type;
            chooseWorker_listView.FullRowSelect = true;
            workerCourses_listView.FullRowSelect = true;
            otherCourses_listView.FullRowSelect = true;
            if (CourseSQL.Get_Courses() == null)
                CourseSQL.LoadAllCoursesAsObjects();
            allCourses = CourseSQL.Get_Courses();
            HeadOfDepartmentSQL sql = new HeadOfDepartmentSQL(SQLConnection.GetSqlConnection());
            sql.LoadAllPeopleInListView(ref this.chooseWorker_listView, type);
            if (type == "Lecturer")
            {
                choose_Button.Text = "Choose Lecturer";
                tabPage1_label.Text = "Choose Lecturer To Assign";
                coursesWantToTeach_label.Text = "Courses Lecturer Wants To Teach:";
            }
            else if (type == "TeachingAssistant")
            {
                choose_Button.Text = "Choose TeachingAssistant";
                tabPage1_label.Text = "Choose Teaching-Assistant To Assign";
                coursesWantToTeach_label.Text = "Courses TeachingAssistant Wants To Teach:";
            }

            tabControl.SelectedIndexChanged += new System.EventHandler(
                this.tabControl_SelectedIndexChanged);
            currentTabPage = choose_tabPage;
            tabControl.SelectedTab = currentTabPage;
        }
        
        private void tabControl_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            tabControl.SelectedTab = currentTabPage;
        }
        
        private void choose_Button_Click(object sender, EventArgs e)
        {
            if(chooseWorker_listView.SelectedItems.Count == 0)
            {
                if (type == "Lecturer")
                    MessageBox.Show("No Lecturer has been selected, try again please.");
                else
                    MessageBox.Show("No Teaching-Assistant has been selected, try again please.");
                return;
            }
            currentTabPage = assignCourse_tabPage;
            tabControl.SelectedTab = currentTabPage;
            CourseSQL.LoadCoursesToListView(ref this.workerCourses_listView);
            if (type == "Lecturer")
            {
                TeachingAssistantSQL sql = new TeachingAssistantSQL();
                this.selectedLecturer = sql.SearchLecturer(
                    "id", chooseWorker_listView.SelectedItems[0].SubItems[2].Text);
            }
            else
            {
                TeachingAssistantSQL sql = new TeachingAssistantSQL();
                this.selectedTeachingAssist = sql.SearchTeachingAssistant(
                    "id", chooseWorker_listView.SelectedItems[0].SubItems[2].Text);
            }
            foreach (ListViewItem item in workerCourses_listView.Items)
            {
                if (IsCourseInSelfCourses(Convert.ToInt32(item.SubItems[0].Text)) == false)
                {
                    ListViewItem copy = item;
                    workerCourses_listView.Items.Remove(item);
                    otherCourses_listView.Items.Add(copy);
                }
            }
        }

        public bool IsCourseInSelfCourses(int courseID)
        {
            if (type == "Lecturer")
            {
                foreach(Course course in this.selectedLecturer.CoursesToTeach)
                {
                    if (courseID == course.CourseID)
                        return true;
                }
            }
            else
            {
                foreach (Course course in this.selectedTeachingAssist.CoursesToTeach)
                {
                    if (courseID == course.CourseID)
                        return true;
                }
            }
            return false;
        }

        private void assignCourse_Button_Click(object sender, EventArgs e)
        {
            if(workerCourses_listView.SelectedItems.Count == 0 && 
                otherCourses_listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("No course has been selected, try again please.");
                return;
            }

            int selectedCourseID = -1;


            if (workerCourses_listView.SelectedItems.Count > 0)
                selectedCourseID = Convert.ToInt32(workerCourses_listView.
                SelectedItems[0].SubItems[0].Text);
            else if (otherCourses_listView.SelectedItems.Count > 0)
                selectedCourseID = Convert.ToInt32(otherCourses_listView.
                SelectedItems[0].SubItems[0].Text);

            foreach (Course course in this.allCourses)
            {
                if (selectedCourseID == course.CourseID)
                {
                    this.selectedCourse = course;
                    break;
                }
            }

            MessageBox.Show("Selected Course:\n" +
                "Course ID: " + selectedCourse.CourseID + "\n"+
                "Course Name: " + selectedCourse.CourseName);

            Init_PreferredDaysListView();
            currentTabPage = assignDay_tabPage;
            tabControl.SelectedTab = currentTabPage;
        }

        public void Init_PreferredDaysListView()
        {
            preferredDays_listView.View = View.Details;
            preferredDays_listView.Columns[0].Text = "Day";
            Days[] daysArr = {Days.Sunday, Days.Monday, Days.Tuesday, Days.Wednesday,
            Days.Thursday, Days.Friday};
            for (int i = 0; i < daysArr.Length; i++)
            {
                ListViewItem item = new ListViewItem(daysArr[i].ToString());
                otherDays_listView.Items.Add(item);
            }
            if (type == "Lecturer")
            {
                foreach (ListViewItem item in otherDays_listView.Items)
                {
                    for (int i = 0; i < selectedLecturer.DaysToTeach.Length; i++)
                    {
                        if (item.Text == selectedLecturer.DaysToTeach[i].ToString())
                        {
                            ListViewItem temp = item;
                            otherDays_listView.Items.Remove(item);
                            preferredDays_listView.Items.Add(item);
                            break;
                        }
                    }
                }
            }
            else
            {
                foreach (ListViewItem item in otherDays_listView.Items)
                {
                    for (int i = 0; i < selectedTeachingAssist.DaysToTeach.Length; i++)
                    {
                        if (item.Text == selectedTeachingAssist.DaysToTeach[i].ToString())
                        {
                            ListViewItem temp = item;
                            otherDays_listView.Items.Remove(item);
                            preferredDays_listView.Items.Add(item);
                            break;
                        }
                    }
                }
            }
        }
        private void Assign_Button_Click(object sender, EventArgs e)
        {
            if (otherDays_listView.SelectedItems.Count == 0 &&
            preferredDays_listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("No day has been selected, try again please.");
                return;
            }

            String day = null;
            if (otherDays_listView.SelectedItems.Count > 0)
            {
                day = otherDays_listView.SelectedItems[0].SubItems[0].Text;
            }

            else if (preferredDays_listView.SelectedItems.Count > 0)
            {
                day = preferredDays_listView.SelectedItems[0].SubItems[0].Text;
            }

            switch (day)
            {
                case "Sunday":
                    selectedDay = Days.Sunday;
                    break;
                case "Monday":
                    selectedDay = Days.Monday;
                    break;
                case "Tuesday":
                    selectedDay = Days.Tuesday;
                    break;
                case "Wednesday":
                    selectedDay = Days.Wednesday;
                    break;
                case "Thursday":
                    selectedDay = Days.Thursday;
                    break;
                case "Friday":
                    selectedDay = Days.Friday;
                    break;
                default:
                    selectedDay = Days.Sunday;
                    break;
            }

            MessageBox.Show("Selected Day: " + selectedDay.ToString());
            Init_PreferredHoursLabels();
            currentTabPage = assignHours_tabPage;
            tabControl.SelectedTab = currentTabPage;
        }

        public void Init_PreferredHoursLabels()
        {
            if (type == "Lecturer")
            {
                if(selectedLecturer.HoursToTeach != null)
                {
                    preferredHoursFrom_Label.Text = selectedLecturer.HoursToTeach[0].ToShortTimeString();
                    preferredHoursTo_Label.Text = selectedLecturer.HoursToTeach[1].ToShortTimeString();
                }
            }
            else
            {
                if(selectedTeachingAssist.HoursToTeach != null)
                {
                    preferredHoursFrom_Label.Text = selectedTeachingAssist.HoursToTeach[0].ToShortTimeString();
                    preferredHoursTo_Label.Text = selectedTeachingAssist.HoursToTeach[1].ToShortTimeString();
                }
            }
        }

        private void assignHours_button_Click(object sender, EventArgs e)
        {
            int from_hour, from_minutes, to_hour, to_minutes;
            try
            {
                from_hour = Convert.ToInt32(from_hour_textBox.Text);
                from_minutes = Convert.ToInt32(from_minutes_textBox.Text);
                to_hour = Convert.ToInt32(to_hour_textBox.Text);
                to_minutes = Convert.ToInt32(to_minutes_textBox.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Error, at least one of the values wasn't filled or" +
                    "isn't an integer try again please.");
                err.ToString();
                return;
            }
            if (from_hour < 0 || from_hour > 24 || to_hour < 0 || to_hour > 24 ||
                from_minutes < 0 || from_minutes > 59 || to_minutes < 0 || to_minutes > 59)
            {
                MessageBox.Show("Error, illegal time chosen, try again please.");
                return;
            }
            DateTime from = new DateTime(2000, 10, 3, from_hour,
            from_minutes, 0);
            DateTime to = new DateTime(2000, 10, 3, to_hour,
                to_minutes, 0);

            String errorMessage = "";
            if (from.Hour > to.Hour)
                errorMessage += "\n-To must be higher than From.";
            else
            {
                if (from.Hour < 8)
                    errorMessage += "\n-From-hour must be at least 08:00.";
                else if (from.Hour > 19)
                    errorMessage += "\n-From-hour must be lower than 19:00.";
                if (to.Hour < 9)
                    errorMessage += "\n-To-hour must be at least 09:00.";
                else if (to.Hour > 20)
                    errorMessage += "\n-To-hour must lower than 20:00.";
            }
            if (errorMessage.Length > 1)
            {
                MessageBox.Show("The following errors occured:" + errorMessage);
                return;
            }
            else
            {
                //MessageBox.Show("You preferred teaching-hours were saved successfully.");
                DateTime[] time = null;
                try
                {
                    time = new DateTime[2];
                }
                catch (ArgumentOutOfRangeException err)
                {
                    err.ToString();
                }

                if (time != null)
                {
                    time[0] = new DateTime(2000, 10, 3, from.Hour, from.Minute, 1);
                    time[1] = new DateTime(2000, 10, 3, to.Hour, to.Minute, 1);
                    assignedHours = time;
                }

                MessageBox.Show("Selected Hours:\n" +
                    "From: " + assignedHours[0].ToShortTimeString() + "\n" +
                    "To: " + assignedHours[1].ToShortTimeString());
            }
            CreateSchedule();
        }

        public void CreateSchedule()
        {
            Schedule schedule;
            if(type == "Lecturer")
            {
                schedule = new Schedule(selectedLecturer.Id, selectedLecturer.FirstName,
                    selectedLecturer.LastName, "Lecturer", selectedCourse.CourseID,
                    assignedHours, selectedDay, selectedCourse.CourseName);
            }
            else
            {
                schedule = new Schedule(selectedTeachingAssist.Id, selectedTeachingAssist.FirstName,
                    selectedTeachingAssist.LastName, "TeachingAssistant", selectedCourse.CourseID,
                    assignedHours, selectedDay, selectedCourse.CourseName);
            }

            ScheduleSQL scheduleSQL = new ScheduleSQL();
            scheduleSQL.SaveScheduleToSQL(schedule);
            this.Dispose();
        }
    }
}
