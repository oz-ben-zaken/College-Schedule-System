using Project_Team_20.EmployeeInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Team_20.LecturerFolder
{
    public enum typeOfLecturer { professor=1,doctor, junior}

    public class Lecturer:TeachingAssistant//, EmpInterface
    {
        typeOfLecturer type;

        public typeOfLecturer typeOfLecturer
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public Lecturer() : this(0) { }
        public Lecturer(typeOfLecturer _type)
        {
            this.type = _type;
        }
        
    }


}
