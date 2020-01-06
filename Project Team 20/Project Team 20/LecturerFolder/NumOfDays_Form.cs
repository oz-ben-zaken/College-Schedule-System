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
    public partial class NumOfDays_Form : TeachingAssistant_Folder.NumOfDays_Form
    {
        
        public NumOfDays_Form(ref EmpInterface emp):base(ref emp)
        {
            InitializeComponent();
        }

        private void errore_button_Click(object sender, EventArgs e)
        {
            
            if ((textBox1.Text).All(char.IsDigit))
            {

                if (int.Parse(textBox1.Text) > 0 && int.Parse(textBox1.Text)<6)
                {
                    //this.assistant.NumOfDaysToTeach=int.Parse(textBox1.Text);//save data
                    MessageBox.Show("Days saved");
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
