using Project_Team_20.HeadOfDepartmentFolder;
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

namespace Project_Team_20.SecretaryFolder
{
   
    public partial class ExceptionHours_Form : Form
    {
        private SqlConnection sqlConnection;
        HeadOfDepartmentSQL headOfDepartmentSQL;

        public ExceptionHours_Form()
        {
            InitializeComponent();
            this.sqlConnection = SQLConnection.GetSqlConnection();
            headOfDepartmentSQL = new HeadOfDepartmentSQL(sqlConnection);
            headOfDepartmentSQL.LoadAllPeopleInListView(ref this.listView, "TeachingAssistant");
            headOfDepartmentSQL.LoadAllPeopleInListView(ref this.listView, "Lecturer");
        }

        private void choose_Button_Click(object sender, EventArgs e)
        {
            hoursBox.SelectAll();
            if (listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("No worker was selected.");
                return;
            }
            else if (listView.SelectedItems.Count > 1)
            {
                MessageBox.Show("Choose only one worker to add to his hours at the time.");
                return;
            }
            else if (hoursBox.SelectionLength == 0)
            {
                MessageBox.Show("Enter amount of hours to reduce.");
                return;
            }
            else if (hoursBox.Text != "1" && hoursBox.Text != "2" && hoursBox.Text != "3" && hoursBox.Text != "4")
            {
                MessageBox.Show("amount of hours need to be less then 4.");
                return;
            }
            else if (headOfDepartmentSQL.isWorkerHouresChangeable(this.listView.SelectedItems[0].SubItems[2].Text) == false)
            {
                MessageBox.Show(this.listView.SelectedItems[0].SubItems[0].Text + " already have exeption/derecognition of hours.");
                return;
            }
            int hours = int.Parse(hoursBox.Text);
            headOfDepartmentSQL.insertExeptionRequest(this.listView.SelectedItems[0].SubItems[2].Text, hours);
            MessageBox.Show("exeption request\nfor " + this.listView.SelectedItems[0].SubItems[0].Text + " has enterd.");
        }
    }
}
