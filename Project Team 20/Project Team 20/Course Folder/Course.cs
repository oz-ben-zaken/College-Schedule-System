using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Team_20.Course_Folder
{
    public class Course
    {
        private int courseID;
        private String courseName;
        private int yearTaught;
        private Semester semesterTaught;
        private Boolean isOpen;

        // ----------------------------------- Class Properties ----------------------------------- //
        public int CourseID
        {
            get { return this.courseID; }
            set { this.courseID = value; }
        }

        public String CourseName
        {
            get { return this.courseName; }
            set { this.courseName = value; }
        }

        public int YearTaught
        {
            get { return this.yearTaught; }
            set { this.yearTaught = value; }
        }

        public Semester SemesterTaught
        {
            get { return this.semesterTaught; }
            set { this.semesterTaught = value; }
        }

        public Boolean IsOpen
        {
            get { return this.isOpen; }
            set { this.isOpen = value; }
        }

        // ----------------------------------- Class Constructors ----------------------------------- //

        public Course() : this(0, "empty", 0, Semester.First, false) { } // Default Constructor
        public Course(int _courseID, String _courseName, int _yearTaught, Semester _semesterTaught,
            Boolean isOpen) // Custome Constuctor
        {
            this.courseID = _courseID;
            this.courseName = _courseName;
            this.yearTaught = _yearTaught;
            this.semesterTaught = _semesterTaught;
            this.isOpen = isOpen;
        }
    }
}
