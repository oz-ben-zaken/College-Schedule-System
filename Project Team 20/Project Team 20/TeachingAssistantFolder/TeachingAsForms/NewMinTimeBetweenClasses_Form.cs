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

namespace Project_Team_20.TeachingAssistantFolder.TeachingAsForms
{
    public partial class NewMinTimeBetweenClasses_Form : Form
    {
        private EmpInterface employee;
        public NewMinTimeBetweenClasses_Form(ref EmpInterface emp)
        {
            InitializeComponent();
            textBox1.Text = hScrollBar1.Value.ToString();
            textBox1.Enabled = false;
            this.employee = emp;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.Text = hScrollBar1.Value.ToString();
        }

        private void save_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your minimum time between classes was saved successfully.");
            this.employee.Set_MinTimeBetweenClasses(hScrollBar1.Value);
            this.Dispose();
        }
    }
}
