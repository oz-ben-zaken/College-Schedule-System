using Project_Team_20.LecturerFolder;
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
using Project_Team_20.SQL_DataBase;
using Project_Team_20.SecretaryFolder;

namespace Project_Team_20.HeadOfDepartmentFolder
{
    public partial class AddWorker_Form : Form
    {
        public AddWorker_Form()
        {
            InitializeComponent();
        }

        private void FormClosedHandling(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).Close();
            sender = null;
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeachingAssistant teachingAssist = new TeachingAssistant();
            teachingAssist.FirstName = "empty";
            BasicUser temp = (BasicUser)teachingAssist;
            BasicUser_Registration_Form regForm = new BasicUser_Registration_Form(ref temp, true);
            regForm.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            regForm.ShowDialog();

            if (temp != null && temp.FirstName != "empty")
            {
                String tempt = "The new user details: FirstName:" + temp.FirstName + ", lastname:" + temp.LastName + ",password:" + temp.Password;
                MessageBox.Show(tempt);
                SqlConnection connection = SQLConnection.GetSqlConnection();
                HeadOfDepartmentSQL sql = new HeadOfDepartmentSQL(connection);
                sql.AddWorker(temp, "TeachingAssistantTable");
            }
        }

        private void Lecturer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lecturer lecturer = new Lecturer();
            lecturer.FirstName = "empty";
            BasicUser temp = (BasicUser)lecturer;
            BasicUser_Registration_Form regForm = new BasicUser_Registration_Form(ref temp, true);
            regForm.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            regForm.ShowDialog();

            if (temp != null && temp.FirstName != "empty")
            {
                String tempt = "The new user details: FirstName:" + temp.FirstName + ", lastname:" + temp.LastName + ",password:" + temp.Password;
                MessageBox.Show(tempt);
                SqlConnection connection = SQLConnection.GetSqlConnection();
                HeadOfDepartmentSQL sql = new HeadOfDepartmentSQL(connection);
                sql.AddWorker(temp, "LecturerTable");
            }
        }

        private void Secretary_Click(object sender, EventArgs e)
        {
            this.Hide();
            Secretary secretary = new Secretary();
            secretary.FirstName = "empty";
             BasicUser temp = (BasicUser)secretary;
             BasicUser_Registration_Form regForm = new BasicUser_Registration_Form(ref temp, true);
             regForm.FormClosed += new FormClosedEventHandler(FormClosedHandling);
             regForm.ShowDialog();

             if (temp != null && temp.FirstName != "empty")
             {
                 String tempt = "The new user details: FirstName:" + temp.FirstName + ", lastname:" + temp.LastName + ",password:" + temp.Password;
                 MessageBox.Show(tempt);
                 SqlConnection connection = SQLConnection.GetSqlConnection();
                 HeadOfDepartmentSQL sql = new HeadOfDepartmentSQL(connection);
                 sql.AddWorker(temp, "SecretaryTable");
             }
             
        }
    }
}
