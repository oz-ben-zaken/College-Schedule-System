using Project_Team_20.Course_Folder;
using Project_Team_20.HeadOfDepartmentFolder;
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
    public partial class Secretary_Form : Form
    {
        private LoginForm loginForm;
        public Secretary_Form(LoginForm loginForm)
        {
            this.loginForm = loginForm;
            InitializeComponent();
        }

        private void openCourseButton_Click(object sender, EventArgs e)
        {
            OpenOrCloseCourse_Form form = new OpenOrCloseCourse_Form();
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            form.ShowDialog();
        }

        private void FormClosedHandling(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).Close();
            sender = null;
            this.Show();
        }
        //
        private void Secretary_Form_FormClosed(Object sender, FormClosedEventArgs e)
        {
            CourseSQL.SaveAllCoursesOnClosing();
        }

        private void AssignLecturerButton_Click(object sender, EventArgs e)
        {
            Assign_Form form = new Assign_Form("Lecturer");
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            form.ShowDialog();
        }

        private void AssignTeachingAssistantButton_Click(object sender, EventArgs e)
        {
            Assign_Form form = new Assign_Form("TeachingAssistant");
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            form.ShowDialog();
        }

        private void derecognitionHoursButton_Click(object sender, EventArgs e)
        {
            DerecognitionHours_Form form = new DerecognitionHours_Form();
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            form.ShowDialog();
        }

        private void exceptionHoursButton_Click(object sender, EventArgs e)
        {
            ExceptionHours_Form form = new ExceptionHours_Form();
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            form.ShowDialog();
        }

        private void printScheduleButton_Click(object sender, EventArgs e)
        {
            PrintSchedule_Form form = new PrintSchedule_Form();
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            form.ShowDialog();
        }

        private void PrintListOfLecturersButton_Click(object sender, EventArgs e)
        {
            PrintAllLecturer form = new PrintAllLecturer();
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            form.ShowDialog();
        }

        private void PrintListOfTeachingAssistantsButton_Click(object sender, EventArgs e)
        {
            PrintAllTeachingAssists form = new PrintAllTeachingAssists();
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            form.ShowDialog();
        }

        private void PrintLecturerDetailsButton_Click(object sender, EventArgs e)
        {
            SearchLecturer_Form form = new SearchLecturer_Form();
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            form.ShowDialog();
        }

        private void PrintTeachingAssistantDetailsButton_Click(object sender, EventArgs e)
        {
            SearchTeachingAssistant_Form form = new SearchTeachingAssistant_Form();
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            form.ShowDialog();
        }

        private void printListOfCourses_button_Click(object sender, EventArgs e)
        {
            PrintAllCourses form = new PrintAllCourses();
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            form.ShowDialog();
        }

        private void printCourseDetails_button_Click(object sender, EventArgs e)
        {
            PrintCourseDetails_Form form = new PrintCourseDetails_Form();
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            form.ShowDialog();
        }

        private void editCourseButton_Click(object sender, EventArgs e)
        {
            EditCourse_Form form = new EditCourse_Form();
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            form.ShowDialog();
        }

        private void editLecturerButton_Click(object sender, EventArgs e)
        {
            DeleteWorker_Form form = new DeleteWorker_Form("Lecturer");
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            form.ShowDialog();
        }

        private void EditTeachingAssistantButton_Click(object sender, EventArgs e)
        {
            DeleteWorker_Form form = new DeleteWorker_Form("TeachingAssistant");
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            form.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Secretary_Form_Load(object sender, EventArgs e)
        {
            if (this.loginForm != null)
                this.loginForm.Hide();
        }
        private void Secretary_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.loginForm.Show();
            this.Dispose();
        }
    }
}
