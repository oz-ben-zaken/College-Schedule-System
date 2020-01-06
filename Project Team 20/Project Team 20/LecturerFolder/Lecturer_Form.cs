using Project_Team_20.EmployeeInterface;
using Project_Team_20.ScheduleFolder;
using Project_Team_20.TeachingAssistant_Folder;
using Project_Team_20.TeachingAssistantFolder.TeachingAsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Team_20.LecturerFolder
{
    public partial class Lecturer_Form : TeachingAssist_Form
    {
       //private Lecturer lecturer;
        //private TeachingAssistant teachingAssist;
        private SemestersToTeachLecturer_Form SemesterToTeachForm;
        private Lecturer lecturer;
        private TeachingAssistant teachingAssistant = new TeachingAssistant();
        private LoginForm loginForm;

        public Lecturer_Form(ref Lecturer lecturer, LoginForm loginForm)
        {
            this.loginForm = loginForm;
            this.lecturer = lecturer;
            InitializeComponent();
        }
        /*public Lecturer_Form(ref Lecturer lecturer, ref TeachingAssistant t):base(ref t)
        {
            InitializeComponent();
            this.lecturer = lecturer;
        }*/

        private void FormClosedHandling(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).Close();
            sender = null;
            this.Show();
        }

        private void SemestersToTeach_button_Click_1(object sender, EventArgs e)
        {
            this.SemesterToTeachForm = new SemestersToTeachLecturer_Form();
            this.Hide();
            SemesterToTeachForm.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            SemesterToTeachForm.ShowDialog();
        }

        protected override void DaysToTeach_button_Click(object sender, EventArgs e)
        {
            EmpInterface emp = this.lecturer;
            ChooseDaysToTeach_Form form = new ChooseDaysToTeach_Form(ref emp);
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            form.ShowDialog();
        }

        protected override void button2_Click(object sender, EventArgs e)
        {
            String message = "Constraint:\n";
            message += "Courses To Teach:\n";
            if (lecturer.CoursesToTeach == null)
                message += "not selected yet.\n";
            else
            {
                for (int i = 0; i < lecturer.CoursesToTeach.Length; i++)
                {
                    message += "Course number [" + (i + 1) + "]:\n";
                    message += "\tCourse ID: " + lecturer.CoursesToTeach[i].CourseID + "\n";
                    message += "\tCourse Name: " + lecturer.CoursesToTeach[i].CourseName + "\n";
                    message += "\tYear Taught: " + lecturer.CoursesToTeach[i].YearTaught + "\n";
                    message += "\tSemester Taught: " + lecturer.CoursesToTeach[i].SemesterTaught + "\n\n";
                }
            }

            message += "\nDays to teach:\n";
            if (lecturer.DaysToTeach == null)
                message += "No days selected.";
            for (int i = 0; i < lecturer.DaysToTeach.Length; i++)
                message += "\t" + lecturer.DaysToTeach[i].ToString() + "\n";

            message += "\nHours to teach: ";
            if (lecturer.HoursToTeach == null)
                message += "No hours were choosen yet.";
            else
            {
                message += "From " + lecturer.HoursToTeach[0].ToShortTimeString();
                message += " To " + lecturer.HoursToTeach[1].ToShortTimeString();
            }                                                                   

            message += "\nMinimum time between classes: " + lecturer.MinTimeBetweenClasses;
            message += "\nNumber of days to teach: " + lecturer.NumOfDaysToTeach;
            message += "\nSemesters to teach: ";
            foreach (Semester semester in lecturer.SemestersToTeach)
                message += "\t" + semester + "\n";

            message += "\nOffice hours: ";
            if (lecturer.OfficeHoursFrom == null || lecturer.OfficeHoursTo == null)
                message += "No office hours were choosen yet.";
            else
            {
                message += "From " + lecturer.OfficeHoursFrom.ToShortTimeString();
                message += " To " + lecturer.OfficeHoursTo.ToShortTimeString();
            }
                                                                                
            MessageBox.Show(message);
        }

        protected override void HoursToTeach_button_Click(object sender, EventArgs e)
        {
            EmpInterface emp = this.lecturer;
            ChooseHoursToTeach form = new ChooseHoursToTeach(ref emp);
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            form.ShowDialog();
        }

        protected override void TimeBetweenClassses_button_Click(object sender, EventArgs e)
        {
            EmpInterface emp = this.lecturer;
            NewMinTimeBetweenClasses_Form form = new NewMinTimeBetweenClasses_Form(ref emp);
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            form.ShowDialog();
        }

        protected override void NumOfDays_button_Click(object sender, EventArgs e)
        {
            EmpInterface emp = this.lecturer;
            NumOfDays_Form form = new NumOfDays_Form(ref emp);
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            form.ShowDialog();
        }

        protected override void SemestersToTeach_button_Click(object sender, EventArgs e)
        {
            EmpInterface emp = this.lecturer;
            SemestersToTeach_Form form = new SemestersToTeach_Form(ref emp, true);
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            form.ShowDialog();
        }

        protected override void ChooceOfficeHours_button_Click(object sender, EventArgs e)
        {
            EmpInterface emp = this.lecturer;
            OfficeHours_Form form = new OfficeHours_Form(ref emp);
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            form.ShowDialog();
        }

        protected override void ChangeOfficeHours_button_Click(object sender, EventArgs e)
        {
            EmpInterface emp = this.lecturer;
            OfficeHours_Form form = new OfficeHours_Form(ref emp);
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            form.ShowDialog();
        }
        protected override void CourseToTeach_button_Click(object sender, EventArgs e)
        {
            EmpInterface emp = this.lecturer;
            ChooseCoursesToTeach form;
            if (lecturer != null)
                form = new ChooseCoursesToTeach(lecturer.CoursesToTeach, ref emp);
            else
                form = new ChooseCoursesToTeach(null, ref emp);
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            form.ShowDialog();
        }

        protected override void PrintDetails_button1_Click(object sender, EventArgs e)
        {
            String message = "Details:\n";
            message += "First Name: " + lecturer.FirstName;
            message += "\nLast Name: " + lecturer.LastName;
            message += "\nID: " + lecturer.Id;
            message += "\nAge: " + lecturer.Age;
            message += "\nUsername: " + lecturer.Username;
            message += "\nPassword: " + lecturer.Password;
            MessageBox.Show(message);
        }

        protected override void SearchTeachingAssist_button_Click(object sender, EventArgs e)
        {
            SearchTeachingAssistant_Form form = new SearchTeachingAssistant_Form();
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            form.ShowDialog();
        }

        protected override void searchLecturer_button_Click(object sender, EventArgs e)
        {
            SearchLecturer_Form form = new SearchLecturer_Form();
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            form.ShowDialog();
        }
        protected void Lecturer_Form_Closing(object sender, System.EventArgs e)
        {
            if (this.lecturer != null)
            {
                Thread save = new Thread(new ThreadStart(SaveOnClosing));
                save.Start();
            }
        }

        protected override void SaveOnClosing()
        {
            TeachingAssistantSQL sql = new TeachingAssistantSQL();
            sql.UpdateOnClosing(this.lecturer);
        }

        protected override void PrintSchedule_button_Click(object sender, EventArgs e)
        {
            if (ScheduleSQL.SearchSchedule(this.lecturer.Id) == false)
                MessageBox.Show("No schedule has been assigned yet.");
        }

        private void Lecturer_Form_Load(object sender, EventArgs e)
        {
            if (this.loginForm != null)
                this.loginForm.Hide();
        }

        private void Lecturer_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.loginForm.Show();
            this.Dispose();
        }
        protected override void TeachingAssist_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.loginForm.Show();
            this.Dispose();
        }
    }
}
