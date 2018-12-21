using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestWD.BuisinessObject;

namespace UnitTestWD.TestData
{
    class EmployeesCreator
    {
        public static Employee createEmployee()
        {
            return new Employee("Ivanov", "Ivan", "Ivanovich", "01011985");
        }
    }
}
