using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using Project_Team_20.SQL_DataBase;
using Project_Team_20.EmployeeInterface;
using Project_Team_20.Course_Folder;
using Project_Team_20.LecturerFolder;
using Project_Team_20.LoginFolder;

namespace Project_Team_20.TeachingAssistantFolder.TeachingAsForms
{
    class TeachingAssistantSQL
    {
        private SqlConnection sqlConnection;
        private SqlDataAdapter adapter;
        public TeachingAssistantSQL() // Constructor
        {
            this.sqlConnection = SQLConnection.GetSqlConnection();
            this.adapter = new SqlDataAdapter();
        }

        public Boolean Insert_DaysToTeach(Days[] days, String id, String table)
        {
            if (this.sqlConnection == null || days == null)
                return false;
            String daysToTeach = (int)days[0] + ";";
            for (int i = 1; i < days.Length; i++)
            {
                daysToTeach += (int)days[i];
                daysToTeach += ';';
            }
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = this.sqlConnection;

                adapter.UpdateCommand = this.sqlConnection.CreateCommand();
                adapter.UpdateCommand.CommandText = "UPDATE " + table + " SET daysToTeach = '"+ daysToTeach + "' WHERE id = '" + id + "'";

                adapter.UpdateCommand.ExecuteNonQuery();          
            }
            catch(Exception e) { e.ToString(); }
            return true;
        }

        public Boolean Insert_SemestersToTeach(Semester[] semesters, String id, String table)
        {
            if (this.sqlConnection == null || semesters == null)
                return false;
            String semestersToTeach = (int)semesters[0] + ";";
            for (int i = 1; i < semesters.Length; i++)
            {
                semestersToTeach += (int)semesters[i];
                semestersToTeach += ';';
            }
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = this.sqlConnection;

                adapter.UpdateCommand = this.sqlConnection.CreateCommand();
                adapter.UpdateCommand.CommandText = "UPDATE " +table+ " SET semestersToTeach = '" + semestersToTeach + "' WHERE id = '" + id + "'";

                adapter.UpdateCommand.ExecuteNonQuery();
            }
            catch (Exception e) { e.ToString(); }
            return true;
        }

        public Boolean Insert_HoursToTeach(DateTime[] hoursToTeach, String id, String table)
        {
            if (this.sqlConnection == null || hoursToTeach == null)
                return false;
            String hours = hoursToTeach[0].Hour + ":"+ hoursToTeach[0].Minute + ";";
            for (int i = 1; i < hoursToTeach.Length; i++)
            {
                hours += hoursToTeach[i].Hour;
                hours += ":";
                hours += hoursToTeach[i].Minute;
                hours += ';';
            }
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = this.sqlConnection;

                adapter.UpdateCommand = this.sqlConnection.CreateCommand();
                adapter.UpdateCommand.CommandText = "UPDATE " + table + " SET hoursToTeach = '" + hours + "' WHERE id = '" + id + "'";

                adapter.UpdateCommand.ExecuteNonQuery();
            }
            catch (Exception e) { e.ToString(); }
            return true;
        }

        public Boolean Insert_MinTimeBetweenClasses(int minTime, String id, String table)
        {
            if (this.sqlConnection == null)
                return false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = this.sqlConnection;

                adapter.UpdateCommand = this.sqlConnection.CreateCommand();
                adapter.UpdateCommand.CommandText = "UPDATE " + table + " SET minTimeBetweenClasses = '" + minTime + "' WHERE id = '" + id + "'";

                adapter.UpdateCommand.ExecuteNonQuery();
            }
            catch (Exception e) { e.ToString(); }
            return true;
        }

        public Boolean Insert_NumOfDaysToTeach(int numOfDays, String id, String table)
        {
            if (this.sqlConnection == null)
                return false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = this.sqlConnection;

                adapter.UpdateCommand = this.sqlConnection.CreateCommand();
                adapter.UpdateCommand.CommandText = "UPDATE " + table + " SET numOfDaysToTeach = '" + numOfDays + "' WHERE id = '" + id + "'";

                adapter.UpdateCommand.ExecuteNonQuery();
            }
            catch (Exception e) { e.ToString(); }
            return true;
        }

        public Boolean Insert_OfficeHours(DateTime officeHoursFrom, 
            DateTime officeHoursTo, String id, String table)
        {
            if (this.sqlConnection == null || officeHoursFrom == null ||
                officeHoursTo == null)
                return false;
            String hoursFrom, hoursTo;
            hoursFrom = officeHoursFrom.Hour + ":" + officeHoursFrom.Minute + ";";
            hoursTo = officeHoursTo.Hour + ":" + officeHoursTo.Minute + ";";
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = this.sqlConnection;

                adapter.UpdateCommand = this.sqlConnection.CreateCommand();

                adapter.UpdateCommand.CommandText = "UPDATE " + table + " SET officeHoursFrom = '" + hoursFrom + "' WHERE id = '" + id + "'";
                adapter.UpdateCommand.ExecuteNonQuery();

                adapter.UpdateCommand.CommandText = "UPDATE " + table + " SET officeHoursTo = '" + hoursTo + "' WHERE id = '" + id + "'";
                adapter.UpdateCommand.ExecuteNonQuery();
            }
            catch (Exception e) { e.ToString(); }
            return true;
        }

        public Boolean Insert_CoursesToTeach(Course[] courses, String id, String table)
        {
            if (this.sqlConnection == null)
                return false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = this.sqlConnection;

                adapter.UpdateCommand = this.sqlConnection.CreateCommand();
                String coursesIDs = "";              
                for(int i = 0; i < courses.Length; i++)
                {
                    coursesIDs += courses[i].CourseID.ToString() + ";";
                }
                adapter.UpdateCommand.CommandText = "UPDATE " + table + " SET coursesToTeach = '" + coursesIDs + "' WHERE id = '" + id + "'";

                adapter.UpdateCommand.ExecuteNonQuery();
            }
            catch (Exception e) { e.ToString(); }
            return true;
        }

        public Boolean Insert_actualTeachingHours(int hoursChange, String id, String table)
        {
            if (this.sqlConnection == null)
                return false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = this.sqlConnection;

                adapter.UpdateCommand = this.sqlConnection.CreateCommand();
                adapter.UpdateCommand.CommandText = "UPDATE " + table + " SET actualTeachingHours = " +( 8 + hoursChange)+ " WHERE id = '" + id + "'";

                adapter.UpdateCommand.ExecuteNonQuery();
            }
            catch (Exception e) { e.ToString(); }
            return true;
        }

        public void UpdateTeachingAssistantOnClosing(TeachingAssistant teachingAssistant)
        {
            if (teachingAssistant == null)
                return;

            // Add update of first name, last name, id, username and password
            // add insert courses to teach

            Insert_DaysToTeach(teachingAssistant.DaysToTeach, teachingAssistant.Id, 
                "TeachingAssistantTable");
            Insert_HoursToTeach(teachingAssistant.HoursToTeach, teachingAssistant.Id,
                "TeachingAssistantTable");
            Insert_MinTimeBetweenClasses(teachingAssistant.MinTimeBetweenClasses, 
                teachingAssistant.Id, "TeachingAssistantTable");
            Insert_NumOfDaysToTeach(teachingAssistant.NumOfDaysToTeach, teachingAssistant.Id,
                "TeachingAssistantTable");
            Insert_SemestersToTeach(teachingAssistant.SemestersToTeach, teachingAssistant.Id,
                "TeachingAssistantTable");
            Insert_OfficeHours(teachingAssistant.OfficeHoursFrom, teachingAssistant.OfficeHoursTo,
                teachingAssistant.Id, "TeachingAssistantTable");
            Insert_CoursesToTeach(teachingAssistant.CoursesToTeach, 
                teachingAssistant.Id, "TeachingAssistantTable");
        }

        public void UpdateOnClosing(EmpInterface employee)
        {
            if (employee == null)
                return;

            // Add update of first name, last name, id, username and password
            // add insert courses to teach

            Insert_DaysToTeach(employee.Get_DaysToTeach(), employee.Get_ID(), "LecturerTable");
            Insert_HoursToTeach(employee.Get_HourToTeach(), employee.Get_ID(), "LecturerTable");
            Insert_MinTimeBetweenClasses(employee.Get_MinTimeBetweenClasses(),
                employee.Get_ID(), "LecturerTable");
            Insert_NumOfDaysToTeach(employee.Get_NumOfDaysToTeach(), employee.Get_ID(),
                "LecturerTable");
            Insert_SemestersToTeach(employee.Get_SemestersToTeach(), employee.Get_ID(), 
                "LecturerTable");
            Insert_OfficeHours(employee.Get_OfficeHoursFrom(), employee.Get_OfficeHoursTo(),
                employee.Get_ID(), "LecturerTable");
            Insert_CoursesToTeach(employee.Get_CoursesToTeach(), employee.Get_ID(), "LecturerTable");
        }

        public TeachingAssistant SearchTeachingAssistant(string searchBy, string value)
        {
            TeachingAssistant teachingAssistant = new TeachingAssistant();
            String command = "SELECT * FROM TeachingAssistantTable WHERE "+ searchBy + " = '" + value + "'";
            DataSet dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            try
            {
                adapter.SelectCommand = new SqlCommand(command, sqlConnection);
                adapter.Fill(dataSet);
                if (dataSet.Tables.Count == 0)
                    return null;

                teachingAssistant.FirstName = dataSet.Tables[0].Rows[0].ItemArray[0].ToString();
                teachingAssistant.LastName = dataSet.Tables[0].Rows[0].ItemArray[1].ToString();
                teachingAssistant.Id = dataSet.Tables[0].Rows[0].ItemArray[2].ToString();
                teachingAssistant.Age = Convert.ToInt32(dataSet.Tables[0].Rows[0].ItemArray[3].ToString());
                teachingAssistant.Username = dataSet.Tables[0].Rows[0].ItemArray[4].ToString();
                teachingAssistant.Password = dataSet.Tables[0].Rows[0].ItemArray[5].ToString();
                teachingAssistant.CoursesToTeach = LoginSQL.ParseCoursesToTeachFromSql(
                    dataSet.Tables[0].Rows[0].ItemArray[6].ToString());
                teachingAssistant.DaysToTeach = LoginSQL.ParseDaysToTeachFromSql(
                 dataSet.Tables[0].Rows[0].ItemArray[7].ToString());

                // -------------------------------------------------------------------
                try
                {
                    DateTime[] tempHoursToTeach = LoginSQL.ParseHoursToTeachFromSql(
                        dataSet.Tables[0].Rows[0].ItemArray[8].ToString());
                    try
                    {
                        teachingAssistant.HoursToTeach = new DateTime[2];
                    }
                    catch (Exception e)
                    {
                        e.ToString();
                    }
                    teachingAssistant.HoursToTeach[0] = new DateTime(2000, 1, 1, tempHoursToTeach[0].Hour, tempHoursToTeach[0].Minute, 0);
                    teachingAssistant.HoursToTeach[1] = new DateTime(2000, 1, 1, tempHoursToTeach[1].Hour, tempHoursToTeach[1].Minute, 0);

                }
                catch (Exception e) { e.ToString(); }

                // -------------------------------------------------------------------
            }
            catch (Exception e)
            {
                e.ToString();
                return null;
            }
            return teachingAssistant;
        }

        public Lecturer SearchLecturer(string searchBy, string value)
        {
            Lecturer lecturer = new Lecturer();
            String command = "SELECT * FROM LecturerTable WHERE " + searchBy + " = '" + value + "'";
            DataSet dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            try
            {
                adapter.SelectCommand = new SqlCommand(command, sqlConnection);
                adapter.Fill(dataSet);
                if (dataSet.Tables.Count == 0)
                    return null;

                lecturer.FirstName = dataSet.Tables[0].Rows[0].ItemArray[0].ToString();
                lecturer.LastName = dataSet.Tables[0].Rows[0].ItemArray[1].ToString();
                lecturer.Id = dataSet.Tables[0].Rows[0].ItemArray[2].ToString();
                lecturer.Age = Convert.ToInt32(dataSet.Tables[0].Rows[0].ItemArray[3].ToString());
                lecturer.Username = dataSet.Tables[0].Rows[0].ItemArray[4].ToString();
                lecturer.Password = dataSet.Tables[0].Rows[0].ItemArray[5].ToString();
                lecturer.CoursesToTeach = LoginSQL.ParseCoursesToTeachFromSql(
                    dataSet.Tables[0].Rows[0].ItemArray[6].ToString());
                lecturer.DaysToTeach = LoginSQL.ParseDaysToTeachFromSql(
                    dataSet.Tables[0].Rows[0].ItemArray[7].ToString());

                // -------------------------------------------------------------------
                try
                {
                    DateTime[] tempHoursToTeach = LoginSQL.ParseHoursToTeachFromSql(
                        dataSet.Tables[0].Rows[0].ItemArray[8].ToString());
                    try
                    {
                        lecturer.HoursToTeach = new DateTime[2];
                    }
                    catch (Exception e)
                    {
                        e.ToString();
                    }
                    lecturer.HoursToTeach[0] = new DateTime(2000, 1, 1, tempHoursToTeach[0].Hour, tempHoursToTeach[0].Minute, 0);
                    lecturer.HoursToTeach[1] = new DateTime(2000, 1, 1, tempHoursToTeach[1].Hour, tempHoursToTeach[1].Minute, 0);

                }
                catch (Exception e) { e.ToString(); }

                // -------------------------------------------------------------------
            }
            catch (Exception e)
            {
                e.ToString();
                return null;
            }
            return lecturer;
        }
    }
}
