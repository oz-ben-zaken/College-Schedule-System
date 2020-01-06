using Project_Team_20.SQL_DataBase;
using Project_Team_20.TeachingAssistantFolder.TeachingAsForms;
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
    public partial class DerecognitionOfHours_Form : Form
    {
        private SqlConnection sqlConnection;
        HeadOfDepartmentSQL headOfDepartmentSQL;

        public DerecognitionOfHours_Form()
        {
            InitializeComponent();
            this.sqlConnection = SQLConnection.GetSqlConnection();
            headOfDepartmentSQL = new HeadOfDepartmentSQL(sqlConnection);
            headOfDepartmentSQL.LoadPeopleWithDerecognitionRequestListView(ref this.listView);
        }

        private void choose_Button_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("No request was selected.");
                return;
            }
            else if (listView.SelectedItems.Count > 1)
            {
                MessageBox.Show("Choose only one request at the time.");
                return;
            }
            TeachingAssistantSQL teachingAssistant = new TeachingAssistantSQL();
            teachingAssistant.Insert_actualTeachingHours(int.Parse(this.listView.SelectedItems[0].SubItems[5].Text)*(-1), this.listView.SelectedItems[0].SubItems[2].Text, "TeachingAssistantTable");
            headOfDepartmentSQL.removeRequest(this.listView.SelectedItems[0].SubItems[2].Text);
            listView.Clear();
            headOfDepartmentSQL.LoadPeopleWithDerecognitionRequestListView(ref this.listView);
        }

        private void decline_Buton_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("No request was selected.");
                return;
            }
            else if (listView.SelectedItems.Count > 1)
            {
                MessageBox.Show("Choose only one request at the time.");
                return;
            }
            headOfDepartmentSQL.removeRequest(this.listView.SelectedItems[0].SubItems[2].Text);
            listView.Clear();
            headOfDepartmentSQL.LoadPeopleWithDerecognitionRequestListView(ref this.listView);
        }
    }
}
