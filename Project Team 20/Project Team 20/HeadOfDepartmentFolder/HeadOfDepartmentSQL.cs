using Project_Team_20.SQL_DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Team_20.Course_Folder;

namespace Project_Team_20.HeadOfDepartmentFolder
{
    class HeadOfDepartmentSQL
    {
        private SqlConnection sqlConnection;
        private SqlDataAdapter adapter;

        public HeadOfDepartmentSQL(SqlConnection sqlConn)
        {
            this.sqlConnection = sqlConn;
            this.adapter = new SqlDataAdapter();
        }

        public Boolean AddNewCourse(Course_Folder.Course newCourse)
        {
            if (newCourse == null)
                return false;

            try
            {
                String str = "INSERT INTO CourseTable VALUES(" + (newCourse.CourseID + 1) + ",'" + newCourse.CourseName + "'," + newCourse.YearTaught + "," + (int)newCourse.SemesterTaught + ",0)";
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.InsertCommand = new SqlCommand(str, this.sqlConnection);
                if (adapter.InsertCommand.ExecuteNonQuery() > 0)
                    MessageBox.Show("Added Course Successfully.");
            }
            catch (Exception e) { MessageBox.Show(e.ToString()); }
            return true;
        }

        public int GetLastAddedCourseID()
        {
            DataSet dataSet = new DataSet();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = this.sqlConnection;

                adapter.SelectCommand = this.sqlConnection.CreateCommand();
                // Get the last courseID that was added to the table so the next added course will get the following ID
                adapter.SelectCommand.CommandText = "SELECT TOP 1 courseID FROM CourseTable ORDER BY courseID DESC";
                adapter.Fill(dataSet);

                int id;
                try
                {
                    id = (int)dataSet.Tables[0].Rows[0].ItemArray[0];
                }
                catch (Exception e)
                {
                    e.ToString();
                    return -1;
                }
                return id;
            }
            catch (Exception e)
            {
                e.ToString();
                return -1;
            }
        }

        public void UpdateCourse(Course course)
        {
            if (course == null)
                return;
            try
            {
                int semesterTaught = Convert.ToInt16(course.SemesterTaught);
                String str = "UPDATE CourseTable SET courseName='" + course.CourseName + "', yearTaught=" + course.YearTaught + ",SemesterTaught=" + semesterTaught + " WHERE courseID=" + course.CourseID;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.InsertCommand = new SqlCommand(str, this.sqlConnection);
                if (adapter.InsertCommand.ExecuteNonQuery() > 0)
                    MessageBox.Show("Updated Course Successfully.");
            }
            catch (Exception e) { MessageBox.Show(e.ToString()); }
        }

        // delete from tablename where id = 
        public Boolean DeleteCourse(int courseID)
        {
            SqlConnection connection = SQLConnection.GetSqlConnection();
            if (connection == null)
                return false;
            try
            {
                String str = "DELETE FROM CourseTable WHERE courseID = '" + courseID + "'";
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.DeleteCommand = connection.CreateCommand();
                adapter.DeleteCommand.CommandText = str;
                if (adapter.DeleteCommand.ExecuteNonQuery() > 0)
                    MessageBox.Show("Deleted Course Successfully.");

            }
            catch (Exception e) { MessageBox.Show("The following error occured:\n" + e.ToString()); }
            return true;
        }

        /*public bool LoadAllTeachingAssistantsInListView(ref ListView listView)
        {
            listView = new ListView();
            listView.Items.Clear();
            listView.FullRowSelect = true;
            SqlConnection sqlConnection = SQLConnection.GetSqlConnection();
            if (sqlConnection == null)
            {
                MessageBox.Show("SQL Connection hasn't been initialized yet.");
                return false;
            }
            SqlCommand sqlCommand = new SqlCommand("SELECT firstName,lastName,id,age,userName FROM TeachingAssistantTable", sqlConnection);
            try
            {
                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read() == true)
                {
                    ListViewItem item = new ListViewItem(dataReader["firstName"].ToString());
                    item.SubItems.Add(dataReader["lastName"].ToString());
                    item.SubItems.Add(dataReader["id"].ToString());
                    item.SubItems.Add(dataReader["age"].ToString());
                    item.SubItems.Add(dataReader["username"].ToString());
                    listView.Items.Add(item);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return true;
        }*/

        public bool LoadAllPeopleInListView(ref ListView listView, String job)
        {
            String str = "SELECT * FROM " + job + "Table";
            SqlCommand cmd = new SqlCommand(str, SQLConnection.GetSqlConnection());

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    populateLV(ref listView, row[0].ToString(), row[1].ToString(), row[2].ToString(),
                        row[3].ToString(), row[4].ToString(), job);
                }

                dataTable.Rows.Clear();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return true;
        }

        private void populateLV(ref ListView listView, String firstName, String lastName, String id, String age, String userName, String job)
        {
            listView.FullRowSelect = true;
            String[] row = { firstName, lastName, id, age, userName, job };
            ListViewItem listViewItem = new ListViewItem(row[0]);
            for (int i = 1; i < row.Length; i++)
                listViewItem.SubItems.Add(row[i]);
            //  MessageBox.Show("TESTTTT:\n" +
            //      "first name = " + firstName +
            //      "\nlast name = " + lastName +
            //      "\nid = " + id +
            //      "\nage = " + age + "\n user name = " + userName);
            listView.Items.Add(listViewItem);
        }

        public void LoadPeopleWithDerecognitionRequestListView(ref ListView listView)
        {
            listView.FullRowSelect = true;
            SqlCommand sqlCommand = new SqlCommand("SELECT firstName,lastName,id,age,userName FROM TeachingAssistantTable", sqlConnection);
            SqlCommand cmd = new SqlCommand("SELECT * FROM HoursRequestTable WHERE increase=" + 0, sqlConnection);
            try
            {
                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                while (dataReader.Read() == true)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        if (dataReader["id"].ToString() == row[0].ToString())
                        {
                            ListViewItem item = new ListViewItem(dataReader["firstName"].ToString());
                            item.SubItems.Add(dataReader["lastName"].ToString());
                            item.SubItems.Add(dataReader["id"].ToString());
                            item.SubItems.Add(dataReader["age"].ToString());
                            item.SubItems.Add(dataReader["username"].ToString());
                            item.SubItems.Add(row[1].ToString());
                            listView.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void LoadPeopleWithExeptionRequestListView(ref ListView listView)
        {
            listView.FullRowSelect = true;
            SqlCommand sqlCommand = new SqlCommand("SELECT firstName,lastName,id,age,userName FROM TeachingAssistantTable UNION ALL SELECT firstName,lastName,id,age,userName FROM LecturerTable", sqlConnection);
            SqlCommand cmd = new SqlCommand("SELECT * FROM HoursRequestTable WHERE increase=" + 1, sqlConnection);
            try
            {
                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                while (dataReader.Read() == true)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        if (dataReader["id"].ToString() == row[0].ToString())
                        {
                            ListViewItem item = new ListViewItem(dataReader["firstName"].ToString());
                            item.SubItems.Add(dataReader["lastName"].ToString());
                            item.SubItems.Add(dataReader["id"].ToString());
                            item.SubItems.Add(dataReader["age"].ToString());
                            item.SubItems.Add(dataReader["username"].ToString());
                            item.SubItems.Add(row[1].ToString());
                            listView.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void LoadPeopleWithAbnormalHoursListView(ref ListView listView,int isIncrease)
        {
            listView.FullRowSelect = true;
            SqlCommand sqlCommand;
            if (isIncrease == 1)
                sqlCommand = new SqlCommand("SELECT firstName,lastName,id,age,userName,actualTeachingHours FROM TeachingAssistantTable WHERE actualTeachingHours > 8 UNION ALL SELECT firstName,lastName,id,age,userName,actualTeachingHours FROM LecturerTable WHERE actualTeachingHours >" + 8, sqlConnection);
            else
                sqlCommand = new SqlCommand("SELECT firstName,lastName,id,age,userName,actualTeachingHours FROM TeachingAssistantTable WHERE actualTeachingHours < 8", sqlConnection);
            try
            {
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read() == true)
                {
                    ListViewItem item = new ListViewItem(dataReader["firstName"].ToString());
                    item.SubItems.Add(dataReader["lastName"].ToString());
                    item.SubItems.Add(dataReader["id"].ToString());
                    item.SubItems.Add(dataReader["age"].ToString());
                    item.SubItems.Add(dataReader["username"].ToString());
                    item.SubItems.Add(dataReader["actualTeachingHours"].ToString());
                    listView.Items.Add(item);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void printAllTeachingAssistantsInListView(ListView listView)
        {
            listView.Items.Clear();
            String str = "SELECT * FROM TeachingAssistantTable";
            SqlCommand cmd = new SqlCommand(str, SQLConnection.GetSqlConnection());

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    DataRow dr = dataTable.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr[0].ToString());
                    listitem.SubItems.Add(dr[1].ToString());
                    listitem.SubItems.Add(dr[2].ToString());
                    listitem.SubItems.Add(dr[3].ToString());
                    listitem.SubItems.Add(dr[4].ToString());


                    listView.Items.Add(listitem);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void printAllLecturerListView(ListView listView)
        {
            listView.Items.Clear();
            String str = "SELECT * FROM LecturerTable";
            SqlCommand cmd = new SqlCommand(str, SQLConnection.GetSqlConnection());

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    DataRow dr = dataTable.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr[0].ToString());
                    listitem.SubItems.Add(dr[1].ToString());
                    listitem.SubItems.Add(dr[2].ToString());
                    listitem.SubItems.Add(dr[3].ToString());
                    listitem.SubItems.Add(dr[4].ToString());


                    listView.Items.Add(listitem);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /*  public void printAllCourses(ListView listView)
          {
              listView.Items.Clear();
              DataSet dataSet = new DataSet();

              String str = "SELECT * FROM CourseTable";
              SqlCommand cmd = new SqlCommand(str, SQLConnection.GetSqlConnection());

              try
              {
                  SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                 //DataTable dataTable = new DataTable();
                  adapter.Fill(dataSet);

                  for (int i=0;i<dataSet.Tables.Count; i++)
                  {
                      DataRow dr = dataSet.Tables[0].Rows[i];
                      ListViewItem listitem = new ListViewItem(dr[0].ToString());
                      listitem.SubItems.Add(dr[1].ToString());
                      listitem.SubItems.Add(dr[2].ToString());
                      listitem.SubItems.Add(dr[3].ToString());

                      listView.Items.Add(listitem);
                  }
              }
              catch (Exception e)
              {
                  MessageBox.Show(e.Message);
              } 
          }  */

        public Boolean AddWorker(BasicUser user, String table)
        {
            if (user == null)
                return false;

            try
            {
                String str;
                if (table != "SecretaryTable")
                {
                    str = "INSERT INTO " + table + " VALUES('" + user.FirstName + "','" + user.LastName + "','" + user.Id + "'," + user.Age + ",'" + user.Username + "','" + user.Password + "'";
                    str += "," + 0 + "," + 0 + "," + 0 + "," + 0 + "," + 0 + "," + 0 + "," + 0 + "," + 0 + "," + 8 + ")";
                }
                else
                    str = "INSERT INTO " + table + " VALUES('" + user.FirstName + "','" + user.LastName + "','" + user.Id + "'," + user.Age + ",'" + user.Username + "','" + user.Password + "')";
                SqlCommand sqlComm = new SqlCommand();
                sqlComm = sqlConnection.CreateCommand();
                sqlComm.CommandText = str;
                sqlComm.ExecuteNonQuery();
            }
            catch (Exception e) { MessageBox.Show(e.ToString()); }
            return true;
        }

        public Boolean UpdateWorker(String id, String job, BasicUser updatedUser)
        {
            try
            {
                String str = "UPDATE " + job + "Table SET firstName='" + updatedUser.FirstName + "',lastName='" + updatedUser.LastName + "',id='" + updatedUser.Id + "',age=" + updatedUser.Age + ", userName='" + updatedUser.Username + "',password='" + updatedUser.Password + "' WHERE id='" + id + "'";
                SqlCommand sqlComm = new SqlCommand();
                sqlComm = sqlConnection.CreateCommand();
                sqlComm.CommandText = str;
                sqlComm.ExecuteNonQuery();
            }
            catch (Exception e) { MessageBox.Show(e.ToString()); }
            return true;
        }

        public Boolean DeleteWorker(String id, String job)
        {
            SqlConnection connection = SQLConnection.GetSqlConnection();
            if (connection == null)
                return false;
            try
            {
                String str = "DELETE FROM " + job + "Table WHERE id = '" + id + "'";
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.DeleteCommand = connection.CreateCommand();
                adapter.DeleteCommand.CommandText = str;
                if (adapter.DeleteCommand.ExecuteNonQuery() > 0)
                    MessageBox.Show("Deleted Worker Successfully.");

            }
            catch (Exception e) { MessageBox.Show("The following error occured:\n" + e.ToString()); }
            return true;
        }

        public Boolean isWorkerHouresChangeable(string id)
        {
            int hours;
            String str = "SELECT actualTeachingHours FROM TeachingAssistantTable WHERE id='" + id + "' UNION ALL SELECT actualTeachingHours FROM LecturerTable WHERE id='" + id + "'";
            SqlCommand cmd = new SqlCommand(str, SQLConnection.GetSqlConnection());

            String str1 = "SELECT * FROM HoursRequestTable WHERE workerId='" + id + "'";
            SqlCommand cmd1 = new SqlCommand(str1, SQLConnection.GetSqlConnection());

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                hours = (int)dataTable.Rows[0][0];
                if (hours != 8)
                    return false;
                adapter = new SqlDataAdapter(cmd1);
                dataTable.Clear();
                adapter.Fill(dataTable);
                if (dataTable.Rows.Count != 0)
                    return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return true;
        }

        internal void insertDerecognitionRequest(string id, int hours)
        {
            try
            {
                String str = "INSERT INTO HoursRequestTable VALUES('" + id + "'," + hours + "," + 0 + ")";
                SqlCommand sqlComm = new SqlCommand();
                sqlComm = sqlConnection.CreateCommand();
                sqlComm.CommandText = str;
                sqlComm.ExecuteNonQuery();
            }
            catch (Exception e) { MessageBox.Show(e.ToString()); }
        }

        internal void insertExeptionRequest(string id, int hours)
        {
            try
            {
                String str = "INSERT INTO HoursRequestTable VALUES('" + id + "'," + hours + "," + 1 + ")";
                SqlCommand sqlComm = new SqlCommand();
                sqlComm = sqlConnection.CreateCommand();
                sqlComm.CommandText = str;
                sqlComm.ExecuteNonQuery();
            }
            catch (Exception e) { MessageBox.Show(e.ToString()); }
        }

        internal void removeRequest(string id)
        {
            try
            {
                String str = "DELETE FROM HoursRequestTable WHERE workerID='" + id + "'";
                SqlCommand sqlComm = new SqlCommand();
                sqlComm = sqlConnection.CreateCommand();
                sqlComm.CommandText = str;
                sqlComm.ExecuteNonQuery();
            }
            catch (Exception e) { MessageBox.Show(e.ToString()); }
        }

        public static Boolean DoesIdExists(String id)
        {
            SqlConnection sqlConnection = SQLConnection.GetSqlConnection();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();

            String command = "SELECT (id) FROM TeachingAssistantTable ";
            command += "UNION SELECT (id) FROM LecturerTable ";
            command += "UNION SELECT (id) FROM SecretaryTable ";
            command += "UNION SELECT (id) FROM HeadOfDepartmentTable ";

            try
            {
                adapter.SelectCommand = new SqlCommand(command, sqlConnection);
                adapter.Fill(dataSet);
                if (dataSet.Tables[0].Rows.Count == 0)
                    return false;

                for(int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    if (id == dataSet.Tables[0].Rows[i].ItemArray[0].ToString())
                        return true;
                } 
            }
            catch (Exception e)
            {
                e.ToString();
            }
            return false;
        }
    }
}
