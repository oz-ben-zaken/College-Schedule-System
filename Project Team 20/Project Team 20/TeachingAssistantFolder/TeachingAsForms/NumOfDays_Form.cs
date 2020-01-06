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

namespace Project_Team_20.TeachingAssistant_Folder
{
    public partial class NumOfDays_Form : Form
    {
        private EmpInterface employee;

        public NumOfDays_Form(ref EmpInterface emp)
        {
            InitializeComponent();
            this.employee = emp;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(textBox1.Text.Length == 0)
            {
                MessageBox.Show("No number was entered, try again please.");
                return;
            }
            if ((textBox1.Text).All(char.IsDigit))
            {

                if (int.Parse(textBox1.Text) > 0 && int.Parse(textBox1.Text) < 6)
                {
                    //this.assistant.NumOfDaysToTeach=int.Parse(textBox1.Text);//save data
                    MessageBox.Show("Days saved");
                    this.employee.Set_NumOfDaysToTeach(int.Parse(textBox1.Text));
                    this.Close();
                }
                else
                    MessageBox.Show("Wrong entery, try again please.");
            }
            else
                MessageBox.Show("Wrong entery, try again please.");
        }
    }
}
