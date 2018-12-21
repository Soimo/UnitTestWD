using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Interactions;


namespace UnitTestWD
{
    class FormPage
    {
        IWebDriver driver;
        public FormPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.Id, Using = "control-9612663")]
        private IWebElement lable; //Лейбл "Сотрудник" по которому делаем ассерт, что страница открылась

        [FindsBy(How = How.Id, Using = "text-1543683954933")]
        private IWebElement lastName; //Поле "Фамилия"

        [FindsBy(How = How.Id, Using = "text-1543683960726")]
        private IWebElement firstName; //Поле "Имя"

        [FindsBy(How = How.Id, Using = "text-1543683963925")]
        private IWebElement patronymic; //Поле "Отчество"

        [FindsBy(How = How.Id, Using = "date-1543683967732")]
        private IWebElement birthDate; //Поле "Дата рождения"

        [FindsBy(How = How.Id, Using = "select-1543683974615")]
        public IWebElement gender; //Список "Пол"

        [FindsBy(How = How.Id, Using = "checkbox-group-1543684026689-1")]
        private IWebElement csharpSkill; //Чек-бокс "C#"

        [FindsBy(How = How.Id, Using = "button-1543684046403")]
        public IWebElement saveButton; //Кнопка "Сохранить"

        public void FillForm(String lName, String fName, String pName, String BDate) //Заполняем форму
        {
            lastName.SendKeys(lName);
            firstName.SendKeys(fName);
            patronymic.SendKeys(pName);
            birthDate.SendKeys(BDate);
            new Actions(driver).Click(gender).SendKeys(gender, "М").SendKeys(gender, Keys.Enter).Build().Perform();
            csharpSkill.Click();
            Assert.AreEqual(lName, isFilled());
            System.Threading.Thread.Sleep(2000);
            saveButton.Click();
            driver.SwitchTo().Alert().Accept();
        }

        public void FormOpenedAssertion() //Метод проверяет, что открыта страница ввода дааных сотрудника
        {
            Assert.AreEqual("Сотрудник", lable);
        }

        public void FillFormAssertion(UnitTestWD.BuisinessObject.Employee employee) //Метод для ассерта заполнения формы
        {
            Assert.AreEqual(employee.getLastName(), isFilled());
        }

        public String isFilled() //Метод, получающий значение из заполненного поля, по которому делаем ассерт (чтобы было с чем сравнивать)
        {
            return lastName.GetAttribute("value");
        }
    }
}
