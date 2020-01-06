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
    public partial class ChooseHoursToTeach : Form
    {
        private EmpInterface employee;
        public ChooseHoursToTeach(ref EmpInterface emp)
        {
            InitializeComponent();
            this.employee = emp;
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            int from_hour, from_minutes, to_hour, to_minutes;
            try
            {
                from_hour = Convert.ToInt32(from_hour_textBox.Text);
                from_minutes = Convert.ToInt32(from_minutes_textBox.Text);
                to_hour = Convert.ToInt32(to_hour_textBox.Text);
                to_minutes = Convert.ToInt32(to_minutes_textBox.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Error, at least one of the values wasn't filled or" +
                    "isn't an integer try again please.");
                err.ToString();
                return;
            }
            if (from_hour < 0 || from_hour > 23 || to_hour < 0 || to_hour > 23 ||
                from_minutes < 0 || from_minutes > 59 || to_minutes < 0 || to_minutes > 59)
            {
                MessageBox.Show("Error, at least one of the values is illegal, try again please.");
                return;
            }
            DateTime from = new DateTime(2000, 10, 3, from_hour,
            from_minutes, 0);
            DateTime to = new DateTime(2000, 10, 3, to_hour,
                to_minutes, 0);

            String errorMessage = "";
            if (from.Hour > to.Hour)
                errorMessage += "\n-To must be higher than From.";
            else
            {
                if (from.Hour < 8)
                    errorMessage += "\n-From-hour must be at least 08:00.";
                else if (from.Hour > 19)
                    errorMessage += "\n-From-hour must be lower than 19:00.";
                if (to.Hour < 9)
                    errorMessage += "\n-To-hour must be at least 09:00.";
                else if (to.Hour > 20)
                    errorMessage += "\n-To-hour must lower than 20:00.";
            }
            if (errorMessage.Length > 1)
            {
                MessageBox.Show("The following errors occured:" + errorMessage);
                return;
            }
            else
            {
                MessageBox.Show("You preferred teaching-hours were saved successfully.");
                //this.teachingAssist.HoursToTeach = null;
                DateTime[] time = null;
                try
                {
                    //this.teachingAssist.HoursToTeach = new DateTime[2];
                    time = new DateTime[2];
                }
                catch(ArgumentOutOfRangeException err)
                {
                    err.ToString();
                }


                //this.teachingAssist.HoursToTeach[0] = new DateTime(2000, 10, 3,
                //    from.Hour, from.Minute, 1);
                //this.teachingAssist.HoursToTeach[1] = new DateTime(2000, 10, 3,
                //    to.Hour, to.Minute, 1);
                if(time != null)
                {
                    time[0] = new DateTime(2000, 10, 3, from.Hour, from.Minute, 1);
                    time[1] = new DateTime(2000, 10, 3, to.Hour, to.Minute, 1);
                    this.employee.Set_HourToTeach(time);
                }


                //this.teachingAssist.HoursToTeach[0] = from;
                //this.teachingAssist.HoursToTeach[1] = to;

                //TeachingAssistantSQL sql = new TeachingAssistantSQL();
                //sql.Insert_HoursToTeach(this.teachingAssist.HoursToTeach, this.teachingAssist.Id);
                this.Dispose();
            }
        }
    }
}
