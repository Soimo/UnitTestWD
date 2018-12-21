using System;
using TechTalk.SpecFlow;
using UnitTestWD.BuisinessLogic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using UnitTestWD.BuisinessObject;

namespace UnitTestWD.Steps
{
    [Binding]
    public class FillFormSteps
    {

        private static IWebDriver driver;
        private static Employee employee;

        [Given(@"Index page ""(.*)"" is opened")]
        public void GivenIndexPageIsOpened(string url)
        {
            driver = new ChromeDriver();
            driver.Url = url;
        }

        [Given(@"I assert button New Form is present")]
        public void GivenIAssertButtonNewFormIsPresent()
        {
            new NewForm(driver).IndexAssertion();
        }

        [When(@"I press New Form button")]
        public void WhenIPressNewFormButton()
        {
            new NewForm(driver).addNewForm();
        }

        [When(@"I fill new Form")]
        public void WhenIFillNewForm()
        {
            new NewEmployee(driver).AddNewEmployee(employee);
        }

        [Then(@"Form page is filled")]
        public void ThenFormPageIsFilled()
        {
            new FormPage(driver).FillFormAssertion(employee);
        }
    }
}
