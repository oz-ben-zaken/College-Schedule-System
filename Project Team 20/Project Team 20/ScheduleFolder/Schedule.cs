using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Team_20.ScheduleFolder
{
    class Schedule
    {
        private String workerID;
        private String workerFirstName;
        private String workerLastName;
        private String workerPosition;
        private int courseID;
        private String courseName;
        private DateTime[] hoursToTeach;
        private Days dayToTeach;

        public String WorkerID
        {
            get { return this.workerID; }
            set { this.workerID = value; }
        }

        public String WorkerFirstName
        {
            get { return this.workerFirstName; }
            set { this.workerFirstName = value; }
        }

        public String WorkerLastName
        {
            get { return this.workerLastName; }
            set { this.workerLastName = value; }
        }

        public String WorkerPosition
        {
            get { return this.workerPosition; }
            set { this.workerPosition = value; }
        }

        public int CourseID
        {
            get { return this.courseID; }
            set { this.courseID = value; }
        }

        public DateTime[] HoursToTeach
        {
            get { return this.hoursToTeach; }
            set { this.hoursToTeach = value; }
        }

        public Days DayToTeach
        {
            get { return this.dayToTeach; }
            set { this.dayToTeach = value; }
        }

        public String CourseName
        {
            get { return this.courseName; }
            set { this.courseName = value; }
        }
        public Schedule(String _workerID, String _workerFirstName, String _workerLastName, 
            String _workerPosition, int _courseID, DateTime[] _hoursToTeach, Days _dayToTeach, 
            String _courseName)
        {
            this.workerID = _workerID;
            this.workerFirstName = _workerFirstName;
            this.workerLastName = _workerLastName;
            this.workerPosition = _workerPosition;
            this.courseID = _courseID;
            this.hoursToTeach = _hoursToTeach;
            this.dayToTeach = _dayToTeach;
            this.courseName = _courseName;
        }
         
    }
}
