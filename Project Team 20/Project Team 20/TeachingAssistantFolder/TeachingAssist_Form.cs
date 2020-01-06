using Project_Team_20.TeachingAssistant_Folder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Project_Team_20.TeachingAssistantFolder.TeachingAsForms;
using Project_Team_20.Course_Folder;
using System.Threading;
using Project_Team_20.EmployeeInterface;
using Project_Team_20.ScheduleFolder;

namespace Project_Team_20
{
    public partial class TeachingAssist_Form : Form
    {
        private NumOfDays_Form NumOfDaysForm;
        private SemestersToTeach_Form SemesterToTeachForm;
        private OfficeHours_Form OfficeHoursForm;
        private TeachingAssistant teachingAssist;
        EmpInterface emp;
        private LoginForm loginForm;
        //private ChooseHoursToWork_Form hoursToWork;

        public TeachingAssist_Form(ref TeachingAssistant t, LoginForm loginForm)
        {
            teachingAssist = t;
            emp = this.teachingAssist;
            this.loginForm = loginForm;
            InitializeComponent();
        }
    
        public TeachingAssist_Form()
        {
            teachingAssist = null;
            InitializeComponent();
        }
        protected virtual void NumOfDays_button_Click(object sender, EventArgs e)
        {
            this.NumOfDaysForm = new NumOfDays_Form(ref this.emp);
            this.Hide();
            NumOfDaysForm.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            NumOfDaysForm.ShowDialog();
        }

        protected virtual void DaysToTeach_button_Click(object sender, EventArgs e)
        {
            ChooseDaysToTeach_Form form = new ChooseDaysToTeach_Form(ref emp);
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            form.ShowDialog();
        }

        protected virtual void SemestersToTeach_button_Click(object sender, EventArgs e)
        {
            this.SemesterToTeachForm = new SemestersToTeach_Form(ref this.emp, false);
            this.Hide();
            SemesterToTeachForm.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            SemesterToTeachForm.ShowDialog();
        }

        protected virtual void ChooceOfficeHours_button_Click(object sender, EventArgs e)
        {
            //need to add     if(מערכת שעות exist)
            this.OfficeHoursForm = new OfficeHours_Form(ref this.emp);
            this.Hide();
            OfficeHoursForm.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            OfficeHoursForm.ShowDialog();
        }

        protected virtual void ChangeOfficeHours_button_Click(object sender, EventArgs e)
        {
            //need to add     if(מערכת שעות exist)
            this.OfficeHoursForm = new OfficeHours_Form(ref this.emp);
            this.Hide();
            OfficeHoursForm.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            OfficeHoursForm.ShowDialog();
        }

        private void FormClosedHandling(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).Close();
            sender = null;
            this.Show();      
        }

        private void TeachingAssist_Form_Load(object sender, EventArgs e)
        {
            if(this.loginForm != null)
                this.loginForm.Hide();
        }
        protected virtual void TimeBetweenClassses_button_Click(object sender, EventArgs e)
        {
            NewMinTimeBetweenClasses_Form form = new NewMinTimeBetweenClasses_Form(ref 
                this.emp);
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            form.ShowDialog();
        }

        protected virtual void HoursToTeach_button_Click(object sender, EventArgs e)
        {       
            ChooseHoursToTeach form = new ChooseHoursToTeach(ref emp);
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            form.ShowDialog();
        }

        protected virtual void CourseToTeach_button_Click(object sender, EventArgs e)
        {
            ChooseCoursesToTeach form;
            if (teachingAssist != null)
                form = new ChooseCoursesToTeach(teachingAssist.CoursesToTeach, ref emp);
            else
                form = new ChooseCoursesToTeach(null, ref emp);
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            form.ShowDialog();
        }

        protected virtual void PrintDetails_button1_Click(object sender, EventArgs e)
        {
            String message = "Details:\n";
            message += "First Name: " + teachingAssist.FirstName;
            message += "\nLast Name: " + teachingAssist.LastName;
            message += "\nID: " + teachingAssist.Id;
            message += "\nAge: " + teachingAssist.Age;
            message += "\nUsername: " + teachingAssist.Username;
            message += "\nPassword: " + teachingAssist.Password;
            MessageBox.Show(message);
        }

        protected virtual void button2_Click(object sender, EventArgs e)
        {
            String message = "Constraint:\n";
            message += "Courses To Teach:\n";
            if (teachingAssist.CoursesToTeach == null)
                message += "not selected yet.\n";
            else
            {
                for(int i = 0; i < teachingAssist.CoursesToTeach.Length;i++)
                {
                    message += "Course number [" + (i + 1) + "]:\n";
                    message += "\tCourse ID: " + teachingAssist.CoursesToTeach[i].CourseID + "\n";
                    message += "\tCourse Name: " + teachingAssist.CoursesToTeach[i].CourseName + "\n";
                    message += "\tYear Taught: " + teachingAssist.CoursesToTeach[i].YearTaught + "\n";
                    message += "\tSemester Taught: " + teachingAssist.CoursesToTeach[i].SemesterTaught + "\n\n";
                }
            }
            message += "\nDays to teach:\n";
            if (teachingAssist.DaysToTeach == null)
                message += "Not selected yet.\n";
            else
            {
                for (int i = 0; i < teachingAssist.DaysToTeach.Length; i++)
                    message += "\t" + teachingAssist.DaysToTeach[i].ToString() + "\n";
            }
        
            message += "\nHours to teach: ";
            if (teachingAssist.HoursToTeach == null)
                message += "Not selected yet.\n";
            else
            {
                message += "From " + teachingAssist.HoursToTeach[0].ToShortTimeString();
                message += " To " + teachingAssist.HoursToTeach[1].ToShortTimeString();
            }
            message += "\nMinimum time between classes: " + teachingAssist.MinTimeBetweenClasses;
            message += "\nNumber of days to teach: " + teachingAssist.NumOfDaysToTeach;
            message += "\nSemesters to teach: ";
            if (teachingAssist.SemestersToTeach == null)
                message += "Not selected yet.\n";
            else
            {
                foreach (Semester semester in teachingAssist.SemestersToTeach)
                    message += "\t" + semester + "\n";
            }
            message += "\nOffice hours: ";
            if (teachingAssist.OfficeHoursFrom == null || teachingAssist.OfficeHoursTo == null)
                message += "Not selected yet.\n";
            else
            {
                message += "From " + teachingAssist.OfficeHoursFrom.ToShortTimeString();
                message += " To " + teachingAssist.OfficeHoursTo.ToShortTimeString();
            }
            MessageBox.Show(message);
        }
        protected virtual void TeachingAssist_Form_Closing(object sender, System.EventArgs e)
        {
            if(this.teachingAssist != null)
            {             
                Thread save = new Thread(new ThreadStart(SaveOnClosing));
                save.Start();
            }
        }
        protected virtual void SaveOnClosing()
        {
            TeachingAssistantSQL sql = new TeachingAssistantSQL();
            sql.UpdateTeachingAssistantOnClosing(this.teachingAssist);
        }

        protected virtual void SearchTeachingAssist_button_Click(object sender, EventArgs e)
        {
            SearchTeachingAssistant_Form form = new SearchTeachingAssistant_Form();
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            form.ShowDialog();
        }

        protected virtual void searchLecturer_button_Click(object sender, EventArgs e)
        {
            SearchLecturer_Form form = new SearchLecturer_Form();
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            form.ShowDialog();
        }

        protected virtual void PrintSchedule_button_Click(object sender, EventArgs e)
        {
            if (ScheduleSQL.SearchSchedule(this.teachingAssist.Id) == false)
                MessageBox.Show("No schedule has been assigned yet.");
        }

        private void AddNewTeachingAssist_button_Click(object sender, EventArgs e)
        {

        }

        protected virtual void TeachingAssist_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.loginForm.Show();
            this.Dispose();
        }
    }
}
