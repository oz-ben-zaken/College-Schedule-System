using Project_Team_20.EmployeeInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Team_20.Course_Folder;

namespace Project_Team_20.SecretaryFolder
{
    public class Secretary:BasicUser, EmpInterface
    {
        public Secretary()
        {

        }

        public Course[] Get_CoursesToTeach()
        {
            return null;
        }

        public Days[] Get_DaysToTeach()
        {
            return null;
        }

        public DateTime[] Get_HourToTeach()
        {
            return null;
        }

        public string Get_ID()
        {
            return this.Id;
        }

        public int Get_MinTimeBetweenClasses()
        {
            return -1;
        }

        public int Get_NumOfDaysToTeach()
        {
            return -1;
        }

        public DateTime Get_OfficeHoursFrom()
        {
            return new DateTime();
        }

        public DateTime Get_OfficeHoursTo()
        {
            return new DateTime();
        }

        public Semester[] Get_SemestersToTeach()
        {
            return null;
        }

        public void Set_CoursesToTeach(Course[] courses)
        {
        }

        public void Set_DaysToTeach(Days[] days)
        {
        }

        public void Set_HourToTeach(DateTime[] hours)
        {
        }

        public void Set_MinTimeBetweenClasses(int time)
        {
        }

        public void Set_NumOfDaysToTeach(int num)
        {
        }

        public void Set_OfficeHoursFrom(DateTime time)
        {
        }

        public void Set_OfficeHoursTo(DateTime time)
        {
        }

        public void Set_SemestersToTeach(Semester[] semesters)
        {
        }
    }
}
