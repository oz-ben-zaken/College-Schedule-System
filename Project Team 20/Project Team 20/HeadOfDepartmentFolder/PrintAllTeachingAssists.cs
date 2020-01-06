using Project_Team_20.SQL_DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_Team_20.HeadOfDepartmentFolder
{
    public partial class PrintAllTeachingAssists : Form
    {
        private HeadOfDepartmentSQL headOfDeptSQL;
        
        public PrintAllTeachingAssists()
        {
            InitializeComponent();
            headOfDeptSQL = new HeadOfDepartmentSQL(SQLConnection.GetSqlConnection());

            headOfDeptSQL.printAllTeachingAssistantsInListView(this.listView1);
            listView1.View = View.Details;

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

       
    }
}
