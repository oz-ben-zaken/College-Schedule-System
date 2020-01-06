using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Project_Team_20.HeadOfDepartmentFolder;
using Project_Team_20.LecturerFolder;
using Project_Team_20.TeachingAssistantFolder.TeachingAsForms;
using Project_Team_20.SQL_DataBase;
using Project_Team_20.SecretaryFolder;

public enum Days { Sunday = 1, Monday=2, Tuesday=3, Wednesday=4, Thursday=5, Friday=6, Saturday=7 };
namespace Project_Team_20
{
    public partial class TempMainForm : Form
    {
        private TeachingAssist_Form teachingAssistForm;
        private HeadOfDepartment_Form headOfDepartmentForm;
        private Lecturer_Form lecturerForm;

        
        public TempMainForm()
        {
            InitializeComponent();
        }


        private void TeachingAssistant_Menu_Click(object sender, EventArgs e)
        {
            TeachingAssistant temp = new TeachingAssistant();
            this.teachingAssistForm = new TeachingAssist_Form(ref temp,null);
            this.Hide();
            teachingAssistForm.FormClosed += new FormClosedEventHandler(teachingAssistForm_FormClosed);
            teachingAssistForm.ShowDialog();
        }

        private void teachingAssistForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.teachingAssistForm.Close();
            this.teachingAssistForm = null;
            this.Show();
        }


        private void HeadOfDepartment_Menu_Click(object sender, EventArgs e)
        {
            this.headOfDepartmentForm = new HeadOfDepartment_Form(null);
            this.Hide();
            headOfDepartmentForm.FormClosed += new FormClosedEventHandler(headOfDepartmentForm_FormClosed);
            headOfDepartmentForm.ShowDialog();

        }

        private void headOfDepartmentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.headOfDepartmentForm.Close();
            this.headOfDepartmentForm = null;
            this.Show();
        }

        private void TestSQLConnection_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Server=tcp:sce-group20-project.database.windows.net,1433;Database=ProjectDataBase;User ID=Group20@sce-group20-project;Password=gKrt@gyT;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
                try
                {
                    conn.Open();
                    MessageBox.Show("Connection opened successfully.\n");

                    TempSQLConnectionTestForm temp = new TempSQLConnectionTestForm();
                    temp.ShowDialog();
                    /*
                    SqlCommand command;
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataSet ds = new DataSet();
                    int i = 0;
                    string sql = null;

                    sql = "SELECT * FROM TeachingAssistantTable";

                    command = new SqlCommand(sql, conn);
                    adapter.SelectCommand = command;
                    adapter.Fill(ds);
                    adapter.Dispose();
                    command.Dispose();

                    String result = "";
                    for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                    {
                        result+= (ds.Tables[0].Rows[i].ItemArray[0] 
                            + "--" + ds.Tables[0].Rows[i].ItemArray[1] 
                            + "--" + ds.Tables[0].Rows[i].ItemArray[2] 
                            + "--" + ds.Tables[0].Rows[i].ItemArray[3]
                            + "--" + ds.Tables[0].Rows[i].ItemArray[4]
                            + "--" + ds.Tables[0].Rows[i].ItemArray[5]
                            + "\n");

                    }

                    MessageBox.Show(result);
                    MessageBox.Show("Length = " + ds.Tables[0].Rows[0].ItemArray[0].ToString().Length);
                    */
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to open connection, shutting down.\n");
                    ex.GetType();
                    return;
                }
            }
        }

        private void Lecturer_Menu_Click(object sender, EventArgs e)
        {
            Lecturer lecturer = new Lecturer();
            TeachingAssistant teachingAssist = new TeachingAssistant();
            this.lecturerForm = new Lecturer_Form(ref lecturer, null);//, ref teachingAssist);
            this.Hide();
            lecturerForm.FormClosed += new FormClosedEventHandler(lecturerForm_FormClosed);
            lecturerForm.ShowDialog();
        }

        private void lecturerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.lecturerForm.Close();
            this.lecturerForm = null;
            this.Show();
        }



        private void newSql_button_Click(object sender, EventArgs e)
        {
            Boolean isConnected = SQLConnection.InitConnection();
            if (isConnected == true)
                MessageBox.Show("Connected successfully!");
            else
                MessageBox.Show("Error, failed to connect.");

            
            if (isConnected == true)
            {
                SqlConnection temp = SQLConnection.GetSqlConnection();

                TeachingAssistantSQL tempt = new TeachingAssistantSQL();
                //tempt.GetID();


                /*Days[] days = new Days[2];
                days[0] = Days.Sunday;
                days[1] = Days.Thursday;
                tempt.Insert_DaysToTeach(days, "135792468");*/

                /*Semester[] semesters = new Semester[2];
                semesters[0] = Semester.First;
                semesters[1] = Semester.Third;
                tempt.Insert_SemestersToTeach(semesters, "307889402");*/

                /*DateTime[] hoursToTeach = new DateTime[2];
                hoursToTeach[0] = new DateTime(2000,1,1,10,10,0);
                hoursToTeach[0].AddHours(8);
                hoursToTeach[0].AddMinutes(30);
                hoursToTeach[1] = new DateTime(2000, 1, 1, 11, 15, 0);
                hoursToTeach[1].AddHours(13);
                hoursToTeach[1].AddMinutes(45);

                tempt.Insert_HoursToTeach(hoursToTeach, "307889402");*/


                /*int minTimeBetweenClasses = 37;
                tempt.Insert_MinTimeBetweenClasses(minTimeBetweenClasses, "135792468")*/

                /*int numOfDaysToTeach = 5;
                tempt.Insert_NumOfDaysToTeach(numOfDaysToTeach, "307889402");*/


            }
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void Secretary_Menu_Click(object sender, EventArgs e)
        {
            Secretary_Form form = new Secretary_Form(null);
            form.ShowDialog();
        }
    }

}
