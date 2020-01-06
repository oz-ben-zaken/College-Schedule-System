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
    public partial class ChooseOfficeHours : TeachingAssistant_Folder.OfficeHours_Form
    {
        private EmpInterface lecturer;

        public ChooseOfficeHours(ref EmpInterface emp) :
            base(ref emp)
        {
            this.lecturer = emp;
            InitializeComponent();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (hour_from.Text == "" || hour_to.Text == "" || minute_from.Text == "" || minute_to.Text == "")
                MessageBox.Show("Wrong entery(ies), try again please.\n Please notice that all of the fields must be full.");
            else if ((hour_from.Text).All(char.IsDigit) && (hour_to.Text).All(char.IsDigit) && (minute_from.Text).All(char.IsDigit) && (minute_to.Text).All(char.IsDigit))
            {
                if (int.Parse(hour_from.Text) < 8 || int.Parse(hour_from.Text) > 22 || int.Parse(hour_to.Text) < 8 || int.Parse(hour_to.Text) > 22 || int.Parse(minute_from.Text) < 0 || int.Parse(minute_from.Text) > 59 || int.Parse(minute_to.Text) < 0 || int.Parse(minute_to.Text) > 59)
                    MessageBox.Show("Wrong entery(ies), try again please.\n Please notice that all of the values are correct.\n(8<=hour<=22,0<=minute<60)");
                else if (int.Parse(hour_from.Text) < int.Parse(hour_to.Text) || (int.Parse(hour_from.Text) == int.Parse(hour_to.Text) && int.Parse(minute_from.Text) < int.Parse(minute_to.Text)))
                {
                    // lecturer.OfficeHoursFrom = new DateTime(0, 0, 0, int.Parse(hour_from.Text), int.Parse(minute_from.Text), 0);
                    // lecturer.OfficeHoursTo = new DateTime(0, 0, 0, int.Parse(hour_to.Text), int.Parse(minute_to.Text), 0);
                    MessageBox.Show("office hours saved");
                    this.Close();
                }
                else
                    MessageBox.Show("Wrong entery(ies), try again please.\n Please notice that the time 'from' need to be less then the time 'to'.");
            }
            else
                MessageBox.Show("Wrong entery(ies), try again please.\n Please notice that you can enter only digits.");
        }
    }
}
