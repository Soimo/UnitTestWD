using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;


namespace UnitTestWD
{
    class IndexPage
    {
        public IndexPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "button-create")]
        private IWebElement newFormButton;
        
        public void NewForm()
        {
            newFormButton.Click(); 
        }

        public void isPresent()
        {
            Assert.IsNotNull(newFormButton);
        }
    }
}
