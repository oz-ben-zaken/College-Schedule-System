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
//using System.Data;

namespace Project_Team_20.HeadOfDepartmentFolder
{
    public partial class HeadOfDepartment_Form : Form
    {
        private LoginForm loginForm;
        public HeadOfDepartment_Form(LoginForm loginForm)
        {
            this.loginForm = loginForm;
            InitializeComponent();
        }

        private void FormClosedHandling(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).Close();
            sender = null;
            this.Show();
        }

        private void HeadOfDepartmentForm_Load(object sender, EventArgs e)
        {
            if (this.loginForm != null)
                this.loginForm.Hide();
        }

        private void PrintLecturers_button_Click(object sender, EventArgs e)
        {
            PrintAllLecturer printLecturerForm = new PrintAllLecturer();
            this.Hide();
            printLecturerForm.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            printLecturerForm.ShowDialog();
        }

        private void deleteWorker_button_Click(object sender, EventArgs e)
        {
            DeleteWorker_Form DeleteWorker = new DeleteWorker_Form("Delete");
            this.Hide();
            DeleteWorker.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            DeleteWorker.ShowDialog();
        }

        private void addWorker_button_Click(object sender, EventArgs e)
        {
            AddWorker_Form AddWorker = new AddWorker_Form();
            this.Hide();
            AddWorker.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            AddWorker.ShowDialog();
        }

        private void createClass_button_Click(object sender, EventArgs e)
        {
            AddCourse_Form addCourseForm = new AddCourse_Form();
            this.Hide();
            addCourseForm.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            addCourseForm.ShowDialog();
        }

        private void deleteClass_button_Click(object sender, EventArgs e)
        {
            DeleteCourse_Form deleteCourseForm = new DeleteCourse_Form();
            this.Hide();
            deleteCourseForm.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            deleteCourseForm.ShowDialog();
        }

        private void PrintTeachingAssistants_button_Click(object sender, EventArgs e)
        {
            PrintAllTeachingAssists printTeachingAssistsForm = new PrintAllTeachingAssists();
            this.Hide();
            printTeachingAssistsForm.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            printTeachingAssistsForm.ShowDialog();
        }

        private void PrintCoursesButton_Click(object sender, EventArgs e)
        {
            PrintAllCourses printCourses = new PrintAllCourses();
            this.Hide();
            printCourses.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            printCourses.ShowDialog();
        }

        private void PrintCoursesButton_Click_1(object sender, EventArgs e)
        {
            PrintAllCourses printCourses = new PrintAllCourses();
            this.Hide();
            printCourses.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            printCourses.ShowDialog();
        }

        private void editLecturer_button_Click(object sender, EventArgs e)
        {
            DeleteWorker_Form DeleteWorker = new DeleteWorker_Form("Lecturer");
            this.Hide();
            DeleteWorker.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            DeleteWorker.ShowDialog();
        }

        private void editTeachingAssistant_button_Click(object sender, EventArgs e)
        {
            DeleteWorker_Form DeleteWorker = new DeleteWorker_Form("TeachingAssistant");
            this.Hide();
            DeleteWorker.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            DeleteWorker.ShowDialog();
        }

        private void derecognitionHoursButton_Click(object sender, EventArgs e)
        {
            DerecognitionOfHours_Form form = new DerecognitionOfHours_Form();
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            form.ShowDialog();
        }

        private void InlayTeachingAssistantButton_Click(object sender, EventArgs e)
        {
            ExeptionOfHours_Form form = new ExeptionOfHours_Form();
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            form.ShowDialog();
        }

        //Cancellation of exeption Hours
        private void InlayLecturerButton_Click(object sender, EventArgs e)
        {
            PeopleWithAbnormalHours_Form  form = new PeopleWithAbnormalHours_Form(1);
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            form.ShowDialog();
        }

        private void EditClass_button_Click(object sender, EventArgs e)
        {
            EditCourse_Form editCourseForm = new EditCourse_Form();
            this.Hide();
            editCourseForm.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            editCourseForm.ShowDialog();
        }

        private void PrintTeachingAssistants_button_Click_1(object sender, EventArgs e)
        {
            PrintAllTeachingAssists printTeachingAssistsForm = new PrintAllTeachingAssists();
            this.Hide();
            printTeachingAssistsForm.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            printTeachingAssistsForm.ShowDialog();
        }

        private void PrintClasses_button_Click(object sender, EventArgs e)
        {
            PrintAllCourses printCourses = new PrintAllCourses();
            this.Hide();
            printCourses.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            printCourses.ShowDialog();
        }

        //abort derecognition of hours
        private void exceptionHoursButton_Click(object sender, EventArgs e)
        {
            PeopleWithAbnormalHours_Form form = new PeopleWithAbnormalHours_Form(0);
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            form.ShowDialog();
        }

        /*
                    AddCourse_Form addCourseForm = new AddCourse_Form();
            this.Hide();
            addCourseForm.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            addCourseForm.Show();
        */

        private void HeadOfDepartment_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.loginForm.Show();
            this.Dispose();
        }
    }
}
