using Project_Team_20.Course_Folder;
using Project_Team_20.HeadOfDepartmentFolder;
using Project_Team_20.LecturerFolder;
using Project_Team_20.SecretaryFolder;
using Project_Team_20.SQL_DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Team_20.LoginFolder
{
    class LoginSQL
    {
        private SqlConnection sqlConnection;
        private SqlDataAdapter adapter;
        private LoginForm loginForm;

        public LoginSQL(LoginForm loginForm) // Constructor
        {
            this.sqlConnection = SQLConnection.GetSqlConnection();
            this.adapter = new SqlDataAdapter();
            this.loginForm = loginForm;
            CourseSQL.LoadAllCoursesAsObjects();
        }

        public void VerifyCredentials(String userName, String password)
        {
            String command = "SELECT * FROM TeachingAssistantTable WHERE username = '" + userName + "' AND password = '" + password + "'";
            command+= "UNION SELECT * FROM LecturerTable WHERE username = '" + userName + "' AND password = '" + password + "'";
            String command2 = "SELECT * FROM SecretaryTable WHERE username = '" + userName + "' AND password = '" + password + "'";
            command2+= "UNION SELECT * FROM HeadOfDepartmentTable WHERE username = '" + userName + "' AND password = '" + password + "'";
            // ADD UNION WITH SECTRETARY AND HEAD OF DEPARTMENT
            DataSet dataSet = new DataSet();
            DataSet dataSet2 = new DataSet();
            try
            {
                adapter.SelectCommand = new SqlCommand(command, sqlConnection);
                adapter.Fill(dataSet);
                adapter.SelectCommand = new SqlCommand(command2, sqlConnection);
                adapter.Fill(dataSet2);
                if (dataSet.Tables[0].Rows.Count == 0 && dataSet2.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Username and/or password are incorrect.\n");
                    return;
                }
                // --------------------------- CHECK THE TYPE OF THE USER -------------------------- //
                // ------------ Check if user is a Lecturer ------------//
                command = "SELECT * FROM LecturerTable WHERE username = '" + userName + "' AND password = '" + password + "'";
                DataSet userTypeDataSet = new DataSet();
                adapter.SelectCommand = new SqlCommand(command, sqlConnection);
                adapter.Fill(userTypeDataSet);
                if ((userTypeDataSet.Tables[0].Rows.Count) > 0)
                {
                    LoginAsLecturer(dataSet);
                }
                // ------------ Check if user is a TeachingAssistant ------------//
                command = "SELECT * FROM TeachingAssistantTable WHERE username = '" + userName + "' AND password = '" + password + "'";
                userTypeDataSet = new DataSet();
                adapter.SelectCommand = new SqlCommand(command, sqlConnection);
                adapter.Fill(userTypeDataSet);
                if ((userTypeDataSet.Tables[0].Rows.Count) > 0)
                {
                    LoginAsTeachingAssistant(dataSet);
                }
                // ------------ Check if user is a Secretary ------------//
                command = "SELECT * FROM SecretaryTable WHERE userName = '" + userName + "' AND password = '" + password + "'";
                userTypeDataSet = new DataSet();
                adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(command, sqlConnection);
                adapter.Fill(userTypeDataSet);
                if ((userTypeDataSet.Tables[0].Rows.Count) > 0)
                {
                    LoginAsSecretary(userTypeDataSet);
                }
                // ------------ Check if user is a Head Of Department ------------//
                command = "SELECT * FROM HeadOfDepartmentTable WHERE userName = '" + userName + "' AND password = '" + password + "'";
                userTypeDataSet = new DataSet();
                adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(command, sqlConnection);
                adapter.Fill(userTypeDataSet);
                if ((userTypeDataSet.Tables[0].Rows.Count) > 0)
                {
                    LoginAsHeadOfDepartment(userTypeDataSet);
                }

            }
            catch (IndexOutOfRangeException e)
            {
                MessageBox.Show("Username and/or password are incorrect.\n");
                e.ToString();
            }
            catch(Exception e)
            {
                MessageBox.Show("The following error occured: " +e.Message);
            }
        }

        public static DateTime ParseDateTimeFromSql(String time)
        {
            String[] split = time.Split(':');
            int hour = 0;
            Int32.TryParse(split[0], out hour);
            int minute = 0;
            Int32.TryParse(split[1], out minute);

            DateTime dateTime = new DateTime(2000,1,1, hour, minute, 1);
            return dateTime;
        }

        public static Days[] ParseDaysToTeachFromSql(String days)
        {
            int counter = 0;
            foreach (char ch in days)
            {
                if (ch != ';')
                    counter++;
            }
            Days[] daysArr = new Days[counter];
            int i = 0;
            foreach(char ch in days)
            {
                if(ch != ';')
                {
                    try
                    {
                        int day = (int)Char.GetNumericValue(ch);
                        switch(day)
                        {
                            case 1:
                                daysArr[i] = Days.Sunday;
                                break;
                            case 2:
                                daysArr[i] = Days.Monday;
                                break;
                            case 3:
                                daysArr[i] = Days.Tuesday;
                                break;
                            case 4:
                                daysArr[i] = Days.Wednesday;
                                break;
                            case 5:
                                daysArr[i] = Days.Thursday;
                                break;
                            case 6:
                                daysArr[i] = Days.Friday;
                                break;
                            case 7:
                                daysArr[i] = Days.Saturday;
                                break;
                        }
                        i++;
                    }
                    catch(Exception e)
                    {
                        e.ToString();
                    }
                    
                }
            }
            return daysArr;
        }

        public static DateTime[] ParseHoursToTeachFromSql(String hours)
        {
            DateTime []dateTime = new DateTime[2];
            String[] split = hours.Split(';');
            dateTime[0] = LoginSQL.ParseDateTimeFromSql(split[0]);
            dateTime[1] = LoginSQL.ParseDateTimeFromSql(split[1]);
            return dateTime;
        }

        public Semester[] ParseSemestersToTeachFromSql(String semesters)
        {
            int counter = 0;
            foreach (char ch in semesters)
            {
                if (ch != ';')
                    counter++;
            }
            Semester[] semestersArr = new Semester[counter];
            int i = 0;
            foreach (char ch in semesters)
            {
                if (ch != ';')
                {
                    try
                    {
                        int semester = (int)Char.GetNumericValue(ch);
                        switch (semester)
                        {
                            case 1:
                                semestersArr[i] = Semester.First;
                                break;
                            case 2:
                                semestersArr[i] = Semester.Second;
                                break;
                            case 3:
                                semestersArr[i] = Semester.Third;
                                break;
                        }
                        i++;
                    }
                    catch (Exception e)
                    {
                        e.ToString();
                    }
                }
            }
            return semestersArr;
        }

        public static Course[] ParseCoursesToTeachFromSql(String courses)
        {
            String[] split = courses.Split(';');
            Course[] coursesToTeach = new Course[split.Length-1];
            int courseId = 0;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            
            for (int i = 0; i < split.Length-1; i++)
            {
                Int32.TryParse(split[i], out courseId);
                DataSet dataSet = new DataSet();
                String command = "SELECT * FROM CourseTable WHERE courseID = '" + courseId + "'";
                sqlDataAdapter.SelectCommand = new SqlCommand(command, SQLConnection.GetSqlConnection());
                sqlDataAdapter.Fill(dataSet);
                
                coursesToTeach[i] = ParseSingleCourse(
                    dataSet.Tables[0].Rows[0].ItemArray[0].ToString(),
                    dataSet.Tables[0].Rows[0].ItemArray[1].ToString(),
                    dataSet.Tables[0].Rows[0].ItemArray[2].ToString(),
                    dataSet.Tables[0].Rows[0].ItemArray[3].ToString());
            }          
            return coursesToTeach;
        }
        public static Course ParseSingleCourse(String courseID,String courseName,String yearTaught,
            String semesterTaught)
        {
            Course newCourse = new Course();
            int coversion = 0;
            Int32.TryParse(courseID, out coversion);
            newCourse.CourseID = coversion;
            newCourse.CourseName = courseName;
            Int32.TryParse(yearTaught, out coversion);
            newCourse.YearTaught = coversion;
            Int32.TryParse(semesterTaught, out coversion);
            if(coversion == 1)
                newCourse.SemesterTaught = Semester.First;
            else if (coversion == 2)
                newCourse.SemesterTaught = Semester.Second;
            else
                newCourse.SemesterTaught = Semester.Third;
            return newCourse;
        }

        public void LoginAsTeachingAssistant(DataSet dataSet)
        {
            //TeachingAssistant teachingAssist = new TeachingAssistant();
            AbstractFactory employeeFactory = FactoryProducer.getFactory("EmployeeFactory");
            TeachingAssistant teachingAssist = (TeachingAssistant)
                employeeFactory.getEmployee("TeachingAssistant");

            teachingAssist = new TeachingAssistant();
            teachingAssist.FirstName = dataSet.Tables[0].Rows[0].ItemArray[0].ToString();
            teachingAssist.LastName = dataSet.Tables[0].Rows[0].ItemArray[1].ToString();
            teachingAssist.Id = dataSet.Tables[0].Rows[0].ItemArray[2].ToString();
            teachingAssist.Age = Convert.ToInt16(dataSet.Tables[0].Rows[0].ItemArray[3].ToString());
            teachingAssist.Username = dataSet.Tables[0].Rows[0].ItemArray[4].ToString();
            teachingAssist.Password = dataSet.Tables[0].Rows[0].ItemArray[5].ToString();
            try
            {
                teachingAssist.CoursesToTeach = ParseCoursesToTeachFromSql(dataSet.Tables[0].Rows[0].ItemArray[6].ToString());
            }
            catch (Exception e) { e.ToString(); }

            try
            {
                teachingAssist.DaysToTeach = ParseDaysToTeachFromSql(dataSet.Tables[0].Rows[0].ItemArray[7].ToString());
            }
            catch (Exception e) { e.ToString(); }
            // -------------------------------------------------------------------
            try
            {
                DateTime[] tempHoursToTeach = ParseHoursToTeachFromSql(dataSet.Tables[0].Rows[0].ItemArray[8].ToString());
                try
                {
                    teachingAssist.HoursToTeach = new DateTime[2];
                }
                catch (Exception e)
                {
                    e.ToString();
                }
                teachingAssist.HoursToTeach[0] = new DateTime(2000, 1, 1, tempHoursToTeach[0].Hour, tempHoursToTeach[0].Minute, 0);
                teachingAssist.HoursToTeach[1] = new DateTime(2000, 1, 1, tempHoursToTeach[1].Hour, tempHoursToTeach[1].Minute, 0);

            }
            catch (Exception e) { e.ToString(); }

            // -------------------------------------------------------------------
            try
            {
                teachingAssist.MinTimeBetweenClasses = Convert.ToInt16(dataSet.Tables[0].Rows[0].ItemArray[9].ToString());
            }
            catch (Exception e) { e.ToString(); }

            try
            {
                teachingAssist.NumOfDaysToTeach = Convert.ToInt16(dataSet.Tables[0].Rows[0].ItemArray[10].ToString());
            }
            catch (Exception e) { e.ToString(); }

            try
            {
                teachingAssist.SemestersToTeach = ParseSemestersToTeachFromSql(dataSet.Tables[0].Rows[0].ItemArray[11].ToString());
            }
            catch (Exception e) { e.ToString(); }

            try
            {
                teachingAssist.OfficeHoursFrom = ParseDateTimeFromSql(dataSet.Tables[0].Rows[0].ItemArray[12].ToString());
            }
            catch (Exception e) { e.ToString(); }

            try
            {
                teachingAssist.OfficeHoursTo = ParseDateTimeFromSql(dataSet.Tables[0].Rows[0].ItemArray[13].ToString());
            }
            catch (Exception e) { e.ToString(); }

            TeachingAssist_Form teachingAssistant_form = new TeachingAssist_Form(ref teachingAssist,this.loginForm);

            teachingAssistant_form.ShowDialog();
            //this.loginForm.Hide();
            
        }
        
        public void LoginAsLecturer(DataSet dataSet)
        {
            //Lecturer lecturer = new Lecturer();
            AbstractFactory employeeFactory = FactoryProducer.getFactory("EmployeeFactory");
            Lecturer lecturer = (Lecturer)employeeFactory.getEmployee("Lecturer");
            lecturer.FirstName = dataSet.Tables[0].Rows[0].ItemArray[0].ToString();
            lecturer.LastName = dataSet.Tables[0].Rows[0].ItemArray[1].ToString();
            lecturer.Id = dataSet.Tables[0].Rows[0].ItemArray[2].ToString();
            lecturer.Age = Convert.ToInt16(dataSet.Tables[0].Rows[0].ItemArray[3].ToString());
            lecturer.Username = dataSet.Tables[0].Rows[0].ItemArray[4].ToString();
            lecturer.Password = dataSet.Tables[0].Rows[0].ItemArray[5].ToString();
            try
            {
                lecturer.CoursesToTeach = ParseCoursesToTeachFromSql(dataSet.Tables[0].Rows[0].ItemArray[6].ToString());
            }
            catch (Exception e) { e.ToString(); }

            try
            {
                lecturer.DaysToTeach = ParseDaysToTeachFromSql(dataSet.Tables[0].Rows[0].ItemArray[7].ToString());
            }
            catch (Exception e) { e.ToString(); }
            // -------------------------------------------------------------------
            try
            {
                DateTime[] tempHoursToTeach = ParseHoursToTeachFromSql(dataSet.Tables[0].Rows[0].ItemArray[8].ToString());
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
            try
            {
                lecturer.MinTimeBetweenClasses = Convert.ToInt16(dataSet.Tables[0].Rows[0].ItemArray[9].ToString());
            }
            catch (Exception e) { e.ToString(); }

            try
            {
                lecturer.NumOfDaysToTeach = Convert.ToInt16(dataSet.Tables[0].Rows[0].ItemArray[10].ToString());
            }
            catch (Exception e) { e.ToString(); }

            try
            {
                lecturer.SemestersToTeach = ParseSemestersToTeachFromSql(dataSet.Tables[0].Rows[0].ItemArray[11].ToString());
            }
            catch (Exception e) { e.ToString(); }

            try
            {
                lecturer.OfficeHoursFrom = ParseDateTimeFromSql(dataSet.Tables[0].Rows[0].ItemArray[12].ToString());
            }
            catch (Exception e) { e.ToString(); }

            try
            {
                lecturer.OfficeHoursTo = ParseDateTimeFromSql(dataSet.Tables[0].Rows[0].ItemArray[13].ToString());
            }
            catch (Exception e) { e.ToString(); }
            TeachingAssistant temp = new TeachingAssistant();
            Lecturer_Form lecturer_form = new Lecturer_Form(ref lecturer, this.loginForm);
            lecturer_form.ShowDialog();       
        }

        public void LoginAsSecretary(DataSet dataSet)
        {
            //SecretaryFolder.Secretary secretary = new SecretaryFolder.Secretary();
            AbstractFactory employeeFactory = FactoryProducer.getFactory("EmployeeFactory");
            Secretary secretary = (Secretary)employeeFactory.getEmployee("Secretary");
            secretary.FirstName = dataSet.Tables[0].Rows[0].ItemArray[0].ToString();
            secretary.LastName = dataSet.Tables[0].Rows[0].ItemArray[1].ToString();
            secretary.Id = dataSet.Tables[0].Rows[0].ItemArray[2].ToString();
            secretary.Age = Convert.ToInt16(dataSet.Tables[0].Rows[0].ItemArray[3].ToString());
            secretary.Username = dataSet.Tables[0].Rows[0].ItemArray[4].ToString();
            secretary.Password = dataSet.Tables[0].Rows[0].ItemArray[5].ToString();
            /*MessageBox.Show("Logged in as Secretary:\n"+
                "Secretary FirstName: " + secretary.FirstName + "\n" +
                "Secretary Last Name: " + secretary.LastName + "\n" +
                "Secretary ID: " + secretary.Id);*/

            Secretary_Form secretary_form = new Secretary_Form(this.loginForm);
            secretary_form.ShowDialog();
        }

        public void LoginAsHeadOfDepartment(DataSet dataSet)
        {
            //HeadOfDepartment headOfDepartment = HeadOfDepartment.Instance;
            AbstractFactory employeeFactory = FactoryProducer.getFactory("EmployeeFactory");
            HeadOfDepartment headOfDepartment = (HeadOfDepartment)employeeFactory.getEmployee(
                "HeadOfDepartment");
            headOfDepartment.FirstName = dataSet.Tables[0].Rows[0].ItemArray[0].ToString();
            headOfDepartment.LastName = dataSet.Tables[0].Rows[0].ItemArray[1].ToString();
            headOfDepartment.Id = dataSet.Tables[0].Rows[0].ItemArray[2].ToString();
            headOfDepartment.Age = Convert.ToInt16(dataSet.Tables[0].Rows[0].ItemArray[3].ToString());
            headOfDepartment.Username = dataSet.Tables[0].Rows[0].ItemArray[4].ToString();
            headOfDepartment.Password = dataSet.Tables[0].Rows[0].ItemArray[5].ToString();
            HeadOfDepartment_Form secretary_form = new HeadOfDepartment_Form(this.loginForm);
            secretary_form.ShowDialog();
        }
    }
}
