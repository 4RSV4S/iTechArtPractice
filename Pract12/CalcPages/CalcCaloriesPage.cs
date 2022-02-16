using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace Pract12
{
    public class CalcCaloriesPage
    {
        private IWebDriver Driver;

        public CalcCaloriesPage(IWebDriver driver)
        {
            this.Driver = driver;
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        public void OpenCalcCaloriesPage()
        {
            Driver.Navigate().GoToUrl("https://www.calc.ru/kalkulyator-kalorii.html");
        }
        public void ChoosePhysicalActivityDegree(string degree)
        {
            IWebElement select = Driver.FindElement(By.Name("activity"));
            SelectElement selectElement = new SelectElement(select);
            selectElement.SelectByText(degree);
        }
        public void EnterAge(string age)
        {
            IWebElement ageTextField = Driver.FindElement(By.Name("age"));
            ageTextField.SendKeys(age);
        }
        public void EnterWeight(string weight)
        {
            IWebElement weightTextField = Driver.FindElement(By.Name("weight"));
            weightTextField.SendKeys(weight);
        }
        public void EnterHeight(string height)
        {
            IWebElement heightTextField = Driver.FindElement(By.Name("sm"));
            heightTextField.SendKeys(height);
        }
        public void ClickSubmitBttn()
        {
            IWebElement submitBttn = Driver.FindElement(By.Id("submit"));
            submitBttn.Click();
        }
        public IWebElement GetDailyCaloriesAmount()
        {
            IWebElement caloriesAmount = Driver.FindElement(By.XPath("//*[@class='result']/*/tr[@class='res_row'][2]/td"));
            return caloriesAmount;
        }
    }
}
