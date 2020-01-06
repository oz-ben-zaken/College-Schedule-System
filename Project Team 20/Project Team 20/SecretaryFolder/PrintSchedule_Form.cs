using Project_Team_20.ScheduleFolder;
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
    public partial class PrintSchedule_Form : Form
    {
        public PrintSchedule_Form()
        {
            InitializeComponent();
            ScheduleSQL.LoadSchedulesToListView(ref this.schedule_listView);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
