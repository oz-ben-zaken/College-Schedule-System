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
    public partial class PeopleWithAbnormalHours_Form : Form
    {
        private SqlConnection sqlConnection;
        HeadOfDepartmentSQL headOfDepartmentSQL;

        public PeopleWithAbnormalHours_Form(int isIncrease)
        {
            InitializeComponent();
            this.sqlConnection = SQLConnection.GetSqlConnection();
            headOfDepartmentSQL = new HeadOfDepartmentSQL(sqlConnection);
            headOfDepartmentSQL.LoadPeopleWithAbnormalHoursListView(ref this.listView, isIncrease);
        }

        private void resetHours_Button_Click(object sender, EventArgs e)
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
            try
            {
                teachingAssistant.Insert_actualTeachingHours(0, this.listView.SelectedItems[0].SubItems[2].Text, "TeachingAssistantTable");
            }
            catch (Exception)
            { }
            try
            {
                teachingAssistant.Insert_actualTeachingHours(0, this.listView.SelectedItems[0].SubItems[2].Text, "LecturerTable");
            }
            catch (Exception) { }
            
            listView.Clear();
            headOfDepartmentSQL.LoadPeopleWithDerecognitionRequestListView(ref this.listView); 
        }
    }
}
