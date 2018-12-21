using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestWD.BuisinessLogic
{
    class NewForm
    {
        private IWebDriver driver;

        public NewForm(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void addNewForm()
        {
            IndexPage IP = new IndexPage(driver);
            IP.NewForm();

        }

        public void IndexAssertion()
        {
            IndexPage IP = new IndexPage(driver);
            IP.isPresent();
        }

    }
}
