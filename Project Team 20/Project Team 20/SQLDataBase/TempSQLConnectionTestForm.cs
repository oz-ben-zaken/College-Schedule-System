using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Team_20
{
    public partial class TempSQLConnectionTestForm : Form
    {
        public TempSQLConnectionTestForm()
        {
            InitializeComponent();
        }

        private void teachingAssistantTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.teachingAssistantTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectDataBaseDataSet);

        }

        private void TempSQLConnectionTestForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectDataBaseDataSet.TeachingAssistantTable' table. You can move, or remove it, as needed.
            this.teachingAssistantTableTableAdapter.Fill(this.projectDataBaseDataSet.TeachingAssistantTable);

        }
    }
}
