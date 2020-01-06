using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Team_20.LoginFolder
{
    public class FactoryProducer
    {
        public static AbstractFactory getFactory(string type)
        {
            if (type == "EmployeeFactory")
                return new EmployeeFactory();
            return null;
        }
    }
}
