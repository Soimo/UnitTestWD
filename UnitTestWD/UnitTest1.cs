using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace UnitTestWD
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "C:\\Users\\admin\\Documents\\Training\\html_hw\\index.html";

            IWebElement getButton = driver.FindElement(By.Name("button-create"));
            Assert.AreEqual("Новая анкета", getButton.Text);
            IWebElement createButtonElement = driver.FindElement(By.Name("button-create"));
            createButtonElement.Click();

            IWebElement getLable = driver.FindElement(By.Id("control-9612663"));
            Console.WriteLine(string.Format(getLable.Text));
            Assert.AreEqual("Сотрудник", getLable.Text);

            IWebElement fieldLastName = driver.FindElement(By.Id("text-1543683954933"));
            fieldLastName.SendKeys("Zakharkin");

            IWebElement fieldFirstName = driver.FindElement(By.Id("text-1543683960726"));
            fieldFirstName.SendKeys("Aleksandr");

            IWebElement fieldPatronymic = driver.FindElement(By.Id("text-1543683963925"));
            fieldPatronymic.SendKeys("Aleksandrovich");

            IWebElement fieldBirthDate = driver.FindElement(By.Id("date-1543683967732"));
            fieldBirthDate.SendKeys("01221985");

            IWebElement fieldSelect = driver.FindElement(By.Id("select-1543683974615"));
            fieldSelect.Click();
            fieldSelect.SendKeys("М");
            fieldSelect.SendKeys(Keys.Enter);

            IWebElement checkBox = driver.FindElement(By.Id("checkbox-group-1543684026689-1"));
            checkBox.Click();

            fieldLastName = driver.FindElement(By.Id("text-1543683954933"));
            Assert.AreEqual("Zakharkin", fieldLastName.GetAttribute("value"));

            System.Threading.Thread.Sleep(2000);

            IWebElement buttonSave = driver.FindElement(By.Id("button-1543684046403"));
            buttonSave.Click();

            driver.SwitchTo().Alert().Accept();

            IWebElement getButtonForAssert = driver.FindElement(By.Name("button-create"));
            Assert.AreEqual("Новая анкета", getButtonForAssert.Text);

            driver.Close();
        }
    }
}
