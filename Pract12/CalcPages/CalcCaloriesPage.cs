using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

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
        public CalcCaloriesPage OpenCalcCaloriesPage()
        {
            Driver.Navigate().GoToUrl("https://www.calc.ru/kalkulyator-kalorii.html");
            return this;
        }
        public CalcCaloriesPage ChoosePhysicalActivityDegree(string degree)
        {
            IWebElement select = Driver.FindElement(By.Name("activity"));
            SelectElement selectElement = new SelectElement(select);
            selectElement.SelectByText(degree);
            return this;
        }
        public CalcCaloriesPage EnterAge(string age)
        {
            IWebElement ageTextField = Driver.FindElement(By.Name("age"));
            ageTextField.SendKeys(age);
            return this;
        }
        public CalcCaloriesPage EnterWeight(string weight)
        {
            IWebElement weightTextField = Driver.FindElement(By.Name("weight"));
            weightTextField.SendKeys(weight);
            return this;
        }
        public CalcCaloriesPage EnterHeight(string height)
        {
            IWebElement heightTextField = Driver.FindElement(By.Name("sm"));
            heightTextField.SendKeys(height);
            return this;
        }
        public CalcCaloriesPage ClickSubmitBttn()
        {
            IWebElement submitBttn = Driver.FindElement(By.Id("submit"));
            submitBttn.Click();
            return this;
        }
        public IWebElement GetDailyCaloriesAmount()
        {
            IWebElement caloriesAmount = Driver.FindElement(By.XPath("//*[@class='result']/*/tr[@class='res_row'][2]/td"));
            return caloriesAmount;
        }
    }
}
