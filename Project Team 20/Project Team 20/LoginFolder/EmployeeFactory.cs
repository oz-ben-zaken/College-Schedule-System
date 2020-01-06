using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Team_20.EmployeeInterface;
using Project_Team_20.LecturerFolder;
using Project_Team_20.HeadOfDepartmentFolder;
using Project_Team_20.SecretaryFolder;

namespace Project_Team_20.LoginFolder
{
    public class EmployeeFactory : AbstractFactory
    {
        public override EmpInterface getEmployee(String type)
        {
            if (type == null)
                return null;
            else if (type == "TeachingAssistant")
                return new TeachingAssistant();
            else if (type == "Lecturer")
                return new Lecturer();
            else if (type == "Secretary")
                return new Secretary();
            else if (type == "HeadOfDepartment")
                return HeadOfDepartment.Instance;

            return null;
        }
    }
}
