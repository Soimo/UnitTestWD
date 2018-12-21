using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestWD.BuisinessLogic
{
    class NewEmployee
    {
        private IWebDriver driver;

        public NewEmployee(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void AddNewEmployee(UnitTestWD.BuisinessObject.Employee employee)
        {
            FormPage FP = new FormPage(driver);
            FP.FillForm(employee.getLastName(), employee.getFirstName(), employee.getPatronymic(), employee.getBirthDate());
        }


    }
}
