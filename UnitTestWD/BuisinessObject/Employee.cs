using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestWD.BuisinessObject
{
    class Employee
    {
        private String lastName;
        private String firstName;
        private String patronymic;
        private String birthDate;

        public Employee(String lastName, String firstName, String patronymic, String birthDate)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.patronymic = patronymic;
            this.birthDate = birthDate;
        }

        public String getLastName()
        {
            return lastName;
        }

        public String getFirstName()
        {
            return firstName;
        }

        public String getPatronymic()
        {
            return patronymic;
        }

        public String getBirthDate()
        {
            return birthDate;
        }
    }
}
