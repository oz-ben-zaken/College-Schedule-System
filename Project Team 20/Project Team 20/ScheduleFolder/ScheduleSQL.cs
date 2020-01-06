using Project_Team_20.LoginFolder;
using Project_Team_20.SQL_DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Team_20.ScheduleFolder
{
    class ScheduleSQL
    {
        private SqlConnection sqlConnection;
        private SqlDataAdapter adapter;
        public ScheduleSQL()
        {
            this.sqlConnection = SQLConnection.GetSqlConnection();
            adapter = new SqlDataAdapter(); 
        }

        public void SaveScheduleToSQL(Schedule schedule)
        {
            try
            {
                String hoursToTeach = schedule.HoursToTeach[0].Hour.ToString() + ":";
                hoursToTeach+= schedule.HoursToTeach[0].Minute.ToString() + ";";
                hoursToTeach+= schedule.HoursToTeach[1].Hour.ToString() + ":";
                hoursToTeach+= schedule.HoursToTeach[1].Minute.ToString() + ";";
                String dayToTeach = Convert.ToString((int)schedule.DayToTeach);
                String str = "INSERT INTO ScheduleTable VALUES('" + schedule.WorkerID + "','" + schedule.WorkerFirstName + "','" + schedule.WorkerLastName + "','" + schedule.WorkerPosition + "',"+ schedule.CourseID+ ",'"+ schedule.CourseName+ "','"+ hoursToTeach + "','" + dayToTeach + "')";
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.InsertCommand = new SqlCommand(str, this.sqlConnection);
                if (adapter.InsertCommand.ExecuteNonQuery() > 0)
                    MessageBox.Show("Added Schedule Successfully.");
            }
            catch (Exception e) { MessageBox.Show(e.ToString()); }
        }
        public static Boolean SearchSchedule(String workerID)
        {
            SqlConnection sqlConnection = SQLConnection.GetSqlConnection();
            String command = "SELECT * FROM ScheduleTable WHERE workerID = '" + workerID + "'";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            try
            {
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                int i = 0;
                int counter = 0;
                while (dataReader.Read() == true)
                    counter++;
                Schedule[] schedule = new Schedule[counter];
                dataReader.Close();
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read() == true)
                {                
                    String workerid = dataReader["workerID"].ToString();
                    String workerFirstName = dataReader["workerFirstName"].ToString();
                    String workerlastName = dataReader["workerLastName"].ToString();
                    String workerPosition = dataReader["workerPosition"].ToString();
                    int courseID = Convert.ToInt32(dataReader["courseID"].ToString());
                    String courseName = dataReader["courseName"].ToString();
                    String hoursToTeachStr = dataReader["hoursToTeach"].ToString();
                    DateTime[] hoursToTeach = LoginSQL.ParseHoursToTeachFromSql(hoursToTeachStr);
                    String dayToTeachInt = dataReader["dayToTeach"].ToString();
                    Days[] dayToTeach = LoginSQL.ParseDaysToTeachFromSql(dayToTeachInt);
                    schedule[i] = new Schedule(workerid, workerFirstName, workerlastName,
                    workerPosition, courseID, hoursToTeach, dayToTeach[0], courseName);
                    i++;
                }

                String msg = "Schedule:\n";
                for (int j = 0; j < schedule.Length; j++)
                {
                    msg += "Course ID: " + schedule[j].CourseID + "\n" +
                    "Course Name: " + schedule[j].CourseName + "\n" +
                    "Hours To Teach: " +
                    "From " + schedule[j].HoursToTeach[0].ToShortTimeString() +
                    " To " + schedule[j].HoursToTeach[1].ToShortTimeString() + "\n" +
                    "Day To Teach: " + schedule[j].DayToTeach + "\n\n";
                 }
                MessageBox.Show(msg);

            }
            catch (Exception e)
            {
                e.ToString();
                return false;
            }
            return true;
        }
        /*public static Boolean SearchSchedule(String workerID)
        {
            SqlConnection sqlConnection = SQLConnection.GetSqlConnection();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();
            String command = "SELECT * FROM ScheduleTable WHERE workerID = '" + workerID + "'";

            try
            {
                adapter.SelectCommand = new SqlCommand(command, sqlConnection);
                adapter.Fill(dataSet);
                if (dataSet.Tables.Count == 0)
                    return false;

                String workerid = dataSet.Tables[0].Rows[0].ItemArray[0].ToString();
                String workerFirstName = dataSet.Tables[0].Rows[0].ItemArray[1].ToString();
                String workerlastName = dataSet.Tables[0].Rows[0].ItemArray[2].ToString();
                String workerPosition = dataSet.Tables[0].Rows[0].ItemArray[3].ToString();
                int courseID = Convert.ToInt32(dataSet.Tables[0].Rows[0].ItemArray[4].ToString());
                String courseName = dataSet.Tables[0].Rows[0].ItemArray[5].ToString();

                String hoursToTeachStr = dataSet.Tables[0].Rows[0].ItemArray[6].ToString();
                DateTime[] hoursToTeach = LoginSQL.ParseHoursToTeachFromSql(hoursToTeachStr);

                String dayToTeachInt = dataSet.Tables[0].Rows[0].ItemArray[7].ToString();
                Days[] dayToTeach = LoginSQL.ParseDaysToTeachFromSql(dayToTeachInt);

                Schedule schedule = new Schedule(workerid, workerFirstName, workerlastName,
                    workerPosition, courseID, hoursToTeach, dayToTeach[0], courseName);

                MessageBox.Show("Schedule:\n" + 
                    "Course ID: " + schedule.CourseID + "\n" +
                    "Course Name: " + schedule.CourseName + "\n" +
                    "Hours To Teach: " +
                    "From " + schedule.HoursToTeach[0].ToShortTimeString() + 
                    " To " + schedule.HoursToTeach[1].ToShortTimeString() + "\n" +
                    "Day To Teach: " + schedule.DayToTeach);

            }
            catch (Exception e)
            {
                e.ToString();
                return false;
            }
            return true;
        }*/

        public static Boolean LoadSchedulesToListView(ref ListView listView)
        {
            listView.Items.Clear();
            listView.FullRowSelect = true;
            SqlConnection sqlConnection = SQLConnection.GetSqlConnection();
            if (sqlConnection == null)
            {
                MessageBox.Show("SQL Connection hasn't been initialized yet.");
                return false;
            }
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM ScheduleTable", sqlConnection);
            try
            {
                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read() == true)
                {
                    ListViewItem item = new ListViewItem(dataReader["workerID"].ToString());
                    item.SubItems.Add(dataReader["workerFirstName"].ToString());
                    item.SubItems.Add(dataReader["workerLastName"].ToString());
                    item.SubItems.Add(dataReader["WorkerPosition"].ToString());
                    item.SubItems.Add(dataReader["courseID"].ToString());
                    item.SubItems.Add(dataReader["courseName"].ToString());
                    item.SubItems.Add(dataReader["hoursToTeach"].ToString());
                    item.SubItems.Add(dataReader["dayToTeach"].ToString());
                    listView.Items.Add(item);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return true;
        }
    }
}
