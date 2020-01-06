using Project_Team_20.Course_Folder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Team_20.EmployeeInterface
{
    public interface EmpInterface
    {
        // -------------------- Set Functions -------------------- //
        void Set_CoursesToTeach(Course[] courses);
        void Set_DaysToTeach(Days[] days);
        void Set_HourToTeach(DateTime[] hours);
        void Set_MinTimeBetweenClasses(int time);
        void Set_NumOfDaysToTeach(int num);
        void Set_SemestersToTeach(Semester[] semesters);
        void Set_OfficeHoursFrom(DateTime time);
        void Set_OfficeHoursTo(DateTime time);

        // -------------------- Get Functions -------------------- //
        Course[] Get_CoursesToTeach();
        Days[] Get_DaysToTeach();
        DateTime[] Get_HourToTeach();
        int Get_MinTimeBetweenClasses();
        int Get_NumOfDaysToTeach();
        Semester[] Get_SemestersToTeach();
        DateTime Get_OfficeHoursFrom();
        DateTime Get_OfficeHoursTo();
        String Get_ID();
    }
}
