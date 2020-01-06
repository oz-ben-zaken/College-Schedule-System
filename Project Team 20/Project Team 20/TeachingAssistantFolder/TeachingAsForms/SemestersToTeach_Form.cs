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
    public partial class SemestersToTeach_Form : Form
    {
        private EmpInterface employee;
        private Boolean isLecturer;
        public SemestersToTeach_Form(ref EmpInterface emp, Boolean isLecturer)
        {
            InitializeComponent();
            this.employee = emp;
            this.isLecturer = isLecturer;
        }

        private void iTalk_Button_21_Click(object sender, EventArgs e)
        {
            int flag = 0;
            if(isLecturer == false && winter.Checked == true && spring.Checked == true && summer.Checked == true)
            {
                MessageBox.Show("Error, you may only choose 2 semesters, try again please.");
                return;
            }
            if (winter.Checked == true)
                flag++;
            if (spring.Checked == true)
                flag++;
            if (summer.Checked == true)
                flag++;
            if (flag > 1)
            {
                //Save data to teaching assistant
                Semester[] semestersToTeach = new Semester[flag];
                int j = 0;
                if (winter.Checked == true)
                {
                    semestersToTeach[j] = Semester.First;
                    j++;
                }
                if (spring.Checked == true)
                {
                    semestersToTeach[j] = Semester.Second;
                    j++;
                }
                if (summer.Checked == true)
                {
                    semestersToTeach[j] = Semester.Third;
                    j++;
                }
                this.employee.Set_SemestersToTeach(semestersToTeach);

                MessageBox.Show("Semesters saved successfully.");
                this.Close();
            }
            if (flag < 2)
                MessageBox.Show("Wrong entery,you chose less than 2 semesters, try again please.");
        }
    }
}
