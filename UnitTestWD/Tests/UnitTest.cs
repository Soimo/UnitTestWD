using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Interactions;
using UnitTestWD.BuisinessLogic;
using UnitTestWD.TestData;
using UnitTestWD.BuisinessObject;


namespace UnitTestWD
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "C:\\Users\\admin\\Documents\\Training\\html_hw\\index.html";

            NewForm NF = new NewForm(driver);
            NF.IndexAssertion();
            NF.addNewForm();

            Employee employee = EmployeesCreator.createEmployee();

            NewEmployee NE = new NewEmployee(driver);
            NE.AddNewEmployee(employee);

            NF.IndexAssertion();

            driver.Close();
        }
    }
}
