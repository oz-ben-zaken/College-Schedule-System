using Project_Team_20.EmployeeInterface;
using Project_Team_20.HeadOfDepartmentFolder;
using Project_Team_20.LecturerFolder;
using Project_Team_20.SecretaryFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Team_20.LoginFolder
{
    public abstract class AbstractFactory
    {
        public abstract EmpInterface getEmployee(String type);
    }
}
