using Project_Team_20.EmployeeInterface;
using Project_Team_20.TeachingAssistantFolder.TeachingAsForms;
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
    public partial class ChooseDaysToTeach_Form : Form
    {
        private EmpInterface employee;

        public ChooseDaysToTeach_Form(ref EmpInterface emp)//ref TeachingAssistant teachingAssistant
        {
            this.employee = emp;
            InitializeComponent();
        }

        private void save_Click_1(object sender, EventArgs e)
        {
            Days[] temp = new Days[6];
            int counter = 0;
            if (Sunday.Checked == true)
            {
                temp[counter] = Days.Sunday;
                counter++;
            }
            if (Monday.Checked == true)
            {
                temp[counter] = Days.Monday;
                counter++;
            }
            if (Tuesday.Checked == true)
            {
                temp[counter] = Days.Tuesday;
                counter++;
            }
            if (Wednesday.Checked == true)
            {
                temp[counter] = Days.Wednesday;
                counter++;
            }
            if (Thursday.Checked == true)
            {
                temp[counter] = Days.Thursday;
                counter++;
            }
            if (Friday.Checked == true)
            {
                temp[counter] = Days.Friday;
                counter++;
            }
            if(counter == 0)
            {
                MessageBox.Show("No days were selected, try again please.");
                return;
            }
            if (counter != 5)
            {
                Days[] temp1 = new Days[counter];
                for (int i = 0; i < counter; i++)
                {
                    temp1[i] = temp[i];
                }
                //this.assistant.DaysToTeach = temp1;
                this.employee.Set_DaysToTeach(temp1);
                MessageBox.Show("Your days were saved successfully.");
            }
            else
            {
                //this.assistant.DaysToTeach = temp;
                this.employee.Set_DaysToTeach(temp);
                MessageBox.Show("Your days were saved successfully.");
            }
            this.Close();
        }
    }
}
