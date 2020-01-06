using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*namespace Project_Team_20.LecturerFolder
{
    public partial class ChooseHoursToWork_Form : TeachingAssistant_Folder.ChooseHoursToWork_Form
    {

        private Lecturer lecturer;

        public ChooseHoursToWork_Form(ref Lecturer user)
        {
            this.lecturer = user;
            InitializeComponent();
        }


        public ChooseHoursToWork_Form()
        {
            InitializeComponent();
        }

        private void HoursToWorkBottom_Click(object sender, EventArgs e)
        {
            int flag = 0;

            //lecturer.HoursToTeach= new DateTime[12];
            if ((SundayFromHour_Form.Text).All(char.IsDigit) && (SundayToHour_Form.Text).All(char.IsDigit) && (SundayToHour_Form.Text) != "" && (SundayFromHour_Form.Text) != "")
            {
                if ((int.Parse(SundayFromHour_Form.Text) < int.Parse(SundayToHour_Form.Text)))
                {
                    //check work hours
                    int n = int.Parse(SundayFromHour_Form.Text);
                    if ((8 <= int.Parse(SundayFromHour_Form.Text) && int.Parse(SundayFromHour_Form.Text) <= 20) && (9 <= int.Parse(SundayToHour_Form.Text) && int.Parse(SundayToHour_Form.Text) <= 21))
                    {
                        //lecturer.HoursToTeach[(int)(Days.Sunday) - 1].AddHours(int.Parse(SundayFromHour_Form.Text));
                        // lecturer.HoursToTeach[(int)(Days.Sunday)].AddHours(int.Parse(SundayFromHour_Form.Text));
                        flag = 1;
                    }
                    else
                    {
                        MessageBox.Show("Wrong entery(ies), try again please.\nWork hours in sunday from 8:00 to 21:00");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Wrong entery(ies), try again please.");
                    return;
                }
            }

            if ((MondayFromHour_Form.Text) != "" && (MondayToHour_Form.Text) != "" && (MondayFromHour_Form.Text).All(char.IsDigit) && (MondayToHour_Form.Text).All(char.IsDigit))
            {
                if ((int.Parse(MondayFromHour_Form.Text) < int.Parse(MondayToHour_Form.Text)))
                {
                    if ((8 <= int.Parse(MondayFromHour_Form.Text) && int.Parse(MondayFromHour_Form.Text) <= 20) && (9 <= int.Parse(MondayToHour_Form.Text) && int.Parse(MondayToHour_Form.Text) <= 21))
                    {
                        //lecturer.HoursToTeach[(int)(Days.Monday) - 1].AddHours(int.Parse(MondayFromHour_Form.Text));
                        //lecturer.HoursToTeach[(int)(Days.Monday)].AddHours(int.Parse(MondayFromHour_Form.Text));
                        flag = 1;
                    }
                    else
                    {
                        MessageBox.Show("Wrong entery(ies), try again please.\nWork hours in monday from 8:00 to 21:00");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Wrong entery(ies), try again please.");
                    return;
                }
            }

            if ((TuesdayFromHour_Form.Text) != "" && (TuesdayToHour_Form.Text) != "" && (TuesdayFromHour_Form.Text).All(char.IsDigit) && (TuesdayToHour_Form.Text).All(char.IsDigit))
            {
                if ((int.Parse(TuesdayFromHour_Form.Text) < int.Parse(TuesdayToHour_Form.Text)))
                {
                    if ((8 <= int.Parse(TuesdayFromHour_Form.Text) && int.Parse(TuesdayFromHour_Form.Text) <= 20) && (9 <= int.Parse(TuesdayToHour_Form.Text) && int.Parse(TuesdayToHour_Form.Text) <= 21))
                    {
                        //lecturer.HoursToTeach[(int)(Days.Tuesday) - 1].AddHours(int.Parse(TuesdayFromHour_Form.Text));
                        //lecturer.HoursToTeach[(int)(Days.Tuesday)].AddHours(int.Parse(TuesdayFromHour_Form.Text));
                        flag = 1;
                    }
                    else
                    {
                        MessageBox.Show("Wrong entery(ies), try again please.\nWork hours in thuesday from 8:00 to 21:00");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Wrong entery(ies), try again please.");
                    return;
                }
            }

            if ((WednesdayFromHour_Form.Text) != "" && (WednesdayToHour_Form.Text) != "" && (WednesdayFromHour_Form.Text).All(char.IsDigit) && (WednesdayToHour_Form.Text).All(char.IsDigit))
            {
                if ((int.Parse(WednesdayFromHour_Form.Text) < int.Parse(WednesdayToHour_Form.Text)))
                {
                    if ((8 <= int.Parse(WednesdayFromHour_Form.Text) && int.Parse(WednesdayFromHour_Form.Text) <= 20) && (9 <= int.Parse(WednesdayToHour_Form.Text) && int.Parse(WednesdayToHour_Form.Text) <= 21))
                    {
                        //lecturer.HoursToTeach[(int)(Days.Wednesday) - 1].AddHours(int.Parse(WednesdayFromHour_Form.Text));
                        //lecturer.HoursToTeach[(int)(Days.Wednesday)].AddHours(int.Parse(WednesdayFromHour_Form.Text));
                        flag = 1;
                    }
                    else
                    {
                        MessageBox.Show("Wrong entery(ies), try again please.\nWork hours in wednesday from 8:00 to 21:00");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Wrong entery(ies), try again please.");
                    return;
                }
            }

            if ((ThursdayFromHour_Form.Text) != "" && (ThursdayToHour_Form.Text) != "" && (ThursdayFromHour_Form.Text).All(char.IsDigit) && (ThursdayToHour_Form.Text).All(char.IsDigit))
            {
                if ((int.Parse(ThursdayFromHour_Form.Text) < int.Parse(ThursdayToHour_Form.Text)))
                {
                    if ((8 <= int.Parse(ThursdayFromHour_Form.Text) && int.Parse(ThursdayFromHour_Form.Text) <= 20) && (9 <= int.Parse(ThursdayToHour_Form.Text) && int.Parse(ThursdayToHour_Form.Text) <= 21))
                    {
                        //lecturer.HoursToTeach[(int)(Days.Thursday) - 1].AddHours(int.Parse(ThursdayFromHour_Form.Text));
                        //lecturer.HoursToTeach[(int)(Days.Thursday)].AddHours(int.Parse(ThursdayFromHour_Form.Text));
                        flag = 1;
                    }
                    else
                    {
                        MessageBox.Show("Wrong entery(ies), try again please.\nWork hours in thursday from 8:00 to 21:00");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Wrong entery(ies), try again please.");
                    return;
                }
            }

            if ((FridayFromHour_Form.Text) != "" && (FridayToHour_Form.Text) != "" && (FridayFromHour_Form.Text).All(char.IsDigit) && (FridayToHour_Form.Text).All(char.IsDigit))
            {
                if ((int.Parse(FridayFromHour_Form.Text) < int.Parse(FridayToHour_Form.Text)))
                {
                    if ((8 <= int.Parse(FridayFromHour_Form.Text) && int.Parse(FridayFromHour_Form.Text) <= 12) && (9 <= int.Parse(FridayToHour_Form.Text) && int.Parse(FridayToHour_Form.Text) <= 13))
                    {
                        //lecturer.HoursToTeach[(int)(Days.Friday) - 1].AddHours(int.Parse(FridayFromHour_Form.Text));
                        //lecturer.HoursToTeach[(int)(Days.Friday)].AddHours(int.Parse(FridayFromHour_Form.Text));
                        flag = 1;
                    }
                    else
                    {
                        MessageBox.Show("Wrong entery(ies), try again please.\nWork hours in friday from 8:00 to 13:00");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Wrong entery(ies), try again please.");
                    return;
                }
            }

            if (flag == 0)//if not choose any day.
            {
                MessageBox.Show("You must select at least one day.");
            }
            else
            {
                MessageBox.Show("Changes saved");
                this.Close();
            }



        }
    
    }
}*/
