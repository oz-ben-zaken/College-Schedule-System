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
    public partial class DeleteWorker_Form : Form
    {
        String job;
        public DeleteWorker_Form(String str)
        {
            job = str;
            InitializeComponent();
            HeadOfDepartmentSQL sql = new HeadOfDepartmentSQL(SQLConnection.GetSqlConnection());
            if (str == "TeachingAssistant")
            {
                this.DeleteWorker_button.Hide();
                sql.LoadAllPeopleInListView(ref this.listView1, "TeachingAssistant");
            }
            else if (str == "Lecturer")
            {
                this.DeleteWorker_button.Hide();
                sql.LoadAllPeopleInListView(ref this.listView1, "Lecturer");
            }
            else if (str == "Delete")
            {
                this.Edit_Worker.Hide();
                sql.LoadAllPeopleInListView(ref this.listView1, "TeachingAssistant");
                sql.LoadAllPeopleInListView(ref this.listView1, "Lecturer");
                //sql.LoadAllPeopleInListView(ref this.listView1, "Secretary");
            }
        }

        private void FormClosedHandling(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).Close();
            sender = null;
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("No worker was selected.");
                return;
            }
            else if (listView1.SelectedItems.Count > 1)
            {
                MessageBox.Show("Choose only one worker to delete at the time.");
                return;
            }
            HeadOfDepartmentSQL headOfDepartmentSql = new HeadOfDepartmentSQL(SQLConnection.GetSqlConnection());
            String ID = listView1.SelectedItems[0].SubItems[2].Text;
            headOfDepartmentSql.DeleteWorker(ID, listView1.SelectedItems[0].SubItems[5].Text);
            listView1.Items.Clear();
            headOfDepartmentSql.LoadAllPeopleInListView(ref this.listView1, "TeachingAssistant");
            headOfDepartmentSql.LoadAllPeopleInListView(ref this.listView1, "Lecturer");
            //sql.LoadAllPeopleInListView(ref this.listView1, "Secretary");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeleteWorker_Form_Load(object sender, EventArgs e)
        {

        }

        private void Edit_Worker_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("No worker was selected.");
                return;
            }
            else if (listView1.SelectedItems.Count > 1)
            {
                MessageBox.Show("Choose only one worker to delete at the time.");
                return;
            }
            HeadOfDepartmentSQL sql = new HeadOfDepartmentSQL(SQLConnection.GetSqlConnection());
            BasicUser temp = new BasicUser();
            temp.FirstName = listView1.SelectedItems[0].SubItems[0].Text;
            temp.LastName = listView1.SelectedItems[0].SubItems[1].Text;
            temp.Id = listView1.SelectedItems[0].SubItems[2].Text;
            temp.Age = int.Parse(listView1.SelectedItems[0].SubItems[3].Text);
            temp.Username = listView1.SelectedItems[0].SubItems[4].Text;
            String id = temp.Id;
            BasicUser_Registration_Form regForm = new BasicUser_Registration_Form(ref temp, false);
            regForm.FormClosed += new FormClosedEventHandler(FormClosedHandling);
            regForm.ShowDialog();
            sql.UpdateWorker(id, job, temp);
            listView1.Items.Clear();
            sql.LoadAllPeopleInListView(ref this.listView1, job);
        }
    }
}
