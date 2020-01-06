using Project_Team_20.Course_Folder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Team_20.EmployeeInterface;
namespace Project_Team_20
{
    
    public enum Semester { First = 1, Second = 2, Third = 3}
    public class TeachingAssistant:BasicUser,EmpInterface // Inherits from BasicUser class
    {
        private const int sizeArrayHours = 12;
        private Course[] coursesToTeach;
        private Days[] daysToTeach;
        private DateTime[] hoursToTeach;
        private int minTimeBetweenClasses; // In minutes
        private int numOfDaysToTeach;
        private Semester[] semestersToTeach;
        private DateTime officeHoursFrom;
        private DateTime officeHoursTo;



        // ------------------------------------------ Class Properties ------------------------------------------ //
        public Course[] CoursesToTeach
        {
            get { return this.coursesToTeach; }
            set { this.coursesToTeach = value; }
        }
        public Days[] DaysToTeach
        {
            get { return this.daysToTeach; }
            set
            {
                if (value != null)
                {
                    this.daysToTeach = new Days[value.Length];
                    for (int i = 0; i < value.Length; i++)
                        this.daysToTeach[i] = value[i];
                }
                else
                    this.daysToTeach = null;
            }
        }
        public DateTime[] HoursToTeach
        {
            get { return this.hoursToTeach; }
            set
            {
                if (value != null)
                {
                    this.hoursToTeach = new DateTime[value.Length];
                    for (int i = 0; i < value.Length; i++)
                        this.hoursToTeach[i] = new DateTime(0, 0, 0, value[i].Hour, value[i].Minute, 0);
                }
                else
                    this.hoursToTeach = null;
            }
        }

        public int MinTimeBetweenClasses
        {
            get { return this.minTimeBetweenClasses; }
            set { this.minTimeBetweenClasses = value; }
        }

        public int NumOfDaysToTeach
        {
            get { return this.numOfDaysToTeach; }
            set { this.numOfDaysToTeach = value; }
        }

        public Semester[] SemestersToTeach
        {
            get { return this.semestersToTeach; }
            set
            {
                if (value != null)
                {
                    this.semestersToTeach = new Semester[value.Length];
                    for (int i = 0; i < value.Length; i++)
                        this.semestersToTeach[i] = value[i];
                }
                else
                    this.semestersToTeach = null;
            }
        }

        public DateTime OfficeHoursFrom
        {
            get { return this.officeHoursFrom; }
            set
            {
                if (value != null)
                {
                    this.officeHoursFrom = value;
                }
                else
                    this.officeHoursFrom = new DateTime();
            }
        }

        public DateTime OfficeHoursTo
        {
            get { return this.officeHoursTo; }
            set
            {
                if (value != null)
                {
                    this.officeHoursTo = value;
                }
                else
                    this.officeHoursTo = new DateTime();
            }
        }
        // ------------------------------------------ Class Constructors ------------------------------------------ //

        // Default Constructor - calls the custom constructor with default parameters
        public TeachingAssistant() : this(null, null, null, 0, null, null, null, null,
            null, 0, 0, null, new DateTime(0), new DateTime(0)) { }
        public TeachingAssistant(string _firstName, string _lastName, string _id, 
            int _age, string _userName, string _password
            , Course[] _coursesToTeach, Days[] _daysToTeach, DateTime[] _hoursToTeach,
            int _minTimeBetweenClasses, int _numOfDaysToTeach, 
            Semester[] _semestersToTeach, DateTime _officeHoursFrom, DateTime _officeHoursTo) 
            : base(_firstName, _lastName, _id, _age, _userName, _password)
        {
            this.CoursesToTeach = _coursesToTeach;
            this.DaysToTeach = _daysToTeach;
            this.HoursToTeach = _hoursToTeach;
            this.MinTimeBetweenClasses = _minTimeBetweenClasses;
            this.NumOfDaysToTeach = _numOfDaysToTeach;
            this.SemestersToTeach = _semestersToTeach;
            this.OfficeHoursFrom = _officeHoursFrom;
            this.OfficeHoursTo = _officeHoursTo;
        }

        // ---------------------------- Employee Interface Implementation -------------------- //
        // ----------------------------- Set Functions ----------------------------- //
        void EmpInterface.Set_CoursesToTeach(Course[] courses)
        {
            this.CoursesToTeach = courses;
        }

        void EmpInterface.Set_DaysToTeach(Days[] days)
        {
            this.DaysToTeach = days;
        }

        void EmpInterface.Set_HourToTeach(DateTime[] hours)
        {
            this.hoursToTeach = hours;
        }

        void EmpInterface.Set_MinTimeBetweenClasses(int time)
        {
            this.MinTimeBetweenClasses = time;
        }

        void EmpInterface.Set_NumOfDaysToTeach(int num)
        {
            this.NumOfDaysToTeach = num;
        }

        void EmpInterface.Set_SemestersToTeach(Semester[] semesters)
        {
            this.SemestersToTeach = semesters;
        }

        void EmpInterface.Set_OfficeHoursFrom(DateTime time)
        {
            this.OfficeHoursFrom = time;
        }

        void EmpInterface.Set_OfficeHoursTo(DateTime time)
        {
            this.OfficeHoursTo = time;
        }

        // ----------------------------- Get Functions ----------------------------- //
        Course[] EmpInterface.Get_CoursesToTeach()
        {
            return this.CoursesToTeach;
        }
        Days[] EmpInterface.Get_DaysToTeach()
        {
            return this.DaysToTeach;
        }
        DateTime[] EmpInterface.Get_HourToTeach()
        {
            return this.HoursToTeach;
        }
        int EmpInterface.Get_MinTimeBetweenClasses()
        {
            return this.MinTimeBetweenClasses;
        }
        int EmpInterface.Get_NumOfDaysToTeach()
        {
            return this.NumOfDaysToTeach;
        }
        Semester[] EmpInterface.Get_SemestersToTeach()
        {
            return this.SemestersToTeach;
        }
        DateTime EmpInterface.Get_OfficeHoursFrom()
        {
            return this.OfficeHoursFrom;
        }
        DateTime EmpInterface.Get_OfficeHoursTo()
        {
            return this.OfficeHoursTo;
        }

        String EmpInterface.Get_ID()
        {
            return this.Id;
        }

        // ------------------------------------------ Class Functions ------------------------------------------ //
    }
}
