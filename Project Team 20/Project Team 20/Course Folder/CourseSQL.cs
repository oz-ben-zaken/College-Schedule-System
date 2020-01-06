using Project_Team_20.SQL_DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Team_20.Course_Folder
{
    class CourseSQL
    {
        private static Course[] courses;

        public static Boolean LoadCoursesToListView(ref ListView listView)
        {
            listView.Items.Clear();
            listView.FullRowSelect = true;
            SqlConnection sqlConnection = SQLConnection.GetSqlConnection();
            if (sqlConnection == null)
            {
                MessageBox.Show("SQL Connection hasn't been initialized yet.");
                return false;
            }
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM CourseTable", sqlConnection);
            try
            {
                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read() == true)
                {
                    ListViewItem item = new ListViewItem(dataReader["courseID"].ToString());
                    item.SubItems.Add(dataReader["courseName"].ToString());
                    item.SubItems.Add(dataReader["yearTaught"].ToString());
                    item.SubItems.Add(dataReader["SemesterTaught"].ToString());
                    if (Convert.ToInt32(dataReader["isCourseOpen"]) == 1)
                        item.SubItems.Add("True");
                    else
                        item.SubItems.Add("False");
                    //item.SubItems.Add(dataReader["isCourseOpen"].ToString());
                    listView.Items.Add(item);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return true;
        }
        public static Course[] Get_Courses()
        {
            return CourseSQL.courses;
        }

        public static Boolean LoadAllCoursesAsObjects()
        {
            CourseSQL.courses = null;
            SqlConnection sqlConnection = SQLConnection.GetSqlConnection();
            if (sqlConnection == null)
            {
                MessageBox.Show("SQL Connection hasn't been initialized yet.");
                return false;
            }
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM CourseTable", sqlConnection);
            try
            {
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                int i = 0;
                int counter = 0;
                while (dataReader.Read() == true)
                    counter++;
                courses = new Course[counter];
                dataReader.Close();
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read() == true)
                {
                    courses[i] = new Course();
                    courses[i].CourseID = Convert.ToInt32(dataReader["courseID"].ToString());
                    courses[i].CourseName = dataReader["courseName"].ToString();
                    courses[i].YearTaught = Convert.ToInt32(dataReader["yearTaught"].ToString());

                    int semester = Convert.ToInt32(dataReader["SemesterTaught"].ToString());
                    switch(semester)
                    {
                        case 1:
                            courses[i].SemesterTaught = Semester.First;
                            break;
                        case 2:
                            courses[i].SemesterTaught = Semester.Second;
                            break;
                        case 3:
                            courses[i].SemesterTaught = Semester.Third;
                            break;
                        default:
                            courses[i].SemesterTaught = Semester.First;
                            break;
                    }
                    if(Convert.ToInt32(dataReader["isCourseOpen"]) == 1)
                        courses[i].IsOpen = true;
                    else
                        courses[i].IsOpen = false;
                    i++;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return true;
        }
         
        public static void SaveAllCoursesOnClosing()
        {
            if (courses == null)
                return;

            foreach(Course course in courses)
            {
                if(course != null)
                {
                    Insert_CourseName(course.CourseName, course.CourseID);
                    Insert_YearTaught(course.YearTaught, course.CourseID);
                    Insert_SemesterTaught(course.SemesterTaught, course.CourseID);
                    Insert_isCourseOpen(course.IsOpen, course.CourseID);
                }
            }
        }

        public static void Insert_CourseName(String courseName, int courseID)
        {
            SqlConnection connection = SQLConnection.GetSqlConnection();
            if (connection == null)
                return;
            SqlDataAdapter adapter = new SqlDataAdapter();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                adapter.UpdateCommand = connection.CreateCommand();
                adapter.UpdateCommand.CommandText = "UPDATE CourseTable SET courseName = '" + courseName + "' WHERE courseID = '" + courseID + "'";
                adapter.UpdateCommand.ExecuteNonQuery();
            }
            catch (Exception e) { e.ToString(); }
        }

        public static void Insert_YearTaught(int year, int courseID)
        {
            SqlConnection connection = SQLConnection.GetSqlConnection();
            if (connection == null)
                return;
            SqlDataAdapter adapter = new SqlDataAdapter();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                adapter.UpdateCommand = connection.CreateCommand();
                adapter.UpdateCommand.CommandText = "UPDATE CourseTable SET yearTaught = '" + year + "' WHERE courseID = '" + courseID + "'";
                adapter.UpdateCommand.ExecuteNonQuery();
            }
            catch (Exception e) { e.ToString(); }
        }

        public static void Insert_SemesterTaught(Semester semester, int courseID)
        {
            SqlConnection connection = SQLConnection.GetSqlConnection();
            if (connection == null)
                return;
            SqlDataAdapter adapter = new SqlDataAdapter();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                adapter.UpdateCommand = connection.CreateCommand();
                int intSemester = 0;
                if (semester == Semester.First)
                    intSemester = 1;
                else if (semester == Semester.Second)
                    intSemester = 2;
                else
                    intSemester = 3;
                adapter.UpdateCommand.CommandText = "UPDATE CourseTable SET semesterTaught = '" + intSemester + "' WHERE courseID = '" + courseID + "'";
                adapter.UpdateCommand.ExecuteNonQuery();
            }
            catch (Exception e) { e.ToString(); }
        }

        public static void Insert_isCourseOpen(Boolean isOpen, int courseID)
        {
            SqlConnection connection = SQLConnection.GetSqlConnection();
            if (connection == null)
                return;
            SqlDataAdapter adapter = new SqlDataAdapter();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                adapter.UpdateCommand = connection.CreateCommand();
                int open = 0;
                if (isOpen == true)
                    open = 1;
                adapter.UpdateCommand.CommandText = "UPDATE CourseTable SET isCourseOpen = '" + open + "' WHERE courseID = '" + courseID + "'";
                adapter.UpdateCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                //e.ToString();
                MessageBox.Show(e.ToString());
            }
        }
    }
}
