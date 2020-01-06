using Project_Team_20.EmployeeInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Team_20.LecturerFolder
{
    public partial class ChangeOfficeHours : TeachingAssistant_Folder.OfficeHours_Form
    {
        public ChangeOfficeHours(ref EmpInterface emp) :
            base(ref emp)
        {
            InitializeComponent();
        }

        private void save_button_Click(object sender, EventArgs e)
        {

        }
    }
}
