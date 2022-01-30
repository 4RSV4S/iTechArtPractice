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
        private IWebDriver driver;

        public CalcCaloriesPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void OpenCalcCaloriesPage()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("https://www.calc.ru/kalkulyator-kalorii.html");
        }
        public void ChoosePhysicalActivityDegree(string degree)
        {
            IWebElement select = driver.FindElement(By.Name("activity"));
            SelectElement selectElement = new SelectElement(select);
            selectElement.SelectByText(degree);
        }
        public void EnterAge(string age)
        {
            IWebElement ageTextField = driver.FindElement(By.Name("age"));
            ageTextField.SendKeys(age);
        }
        public void EnterWeight(string weight)
        {
            IWebElement weightTextField = driver.FindElement(By.Name("weight"));
            weightTextField.SendKeys(weight);
        }
        public void EnterHeight(string height)
        {
            IWebElement heightTextField = driver.FindElement(By.Name("sm"));
            heightTextField.SendKeys(height);
        }
        public void ClickSubmitBttn()
        {
            IWebElement submitBttn = driver.FindElement(By.Id("submit"));
            submitBttn.Click();
        }
        public IWebElement GetDailyCaloriesAmount()
        {
            IWebElement caloriesAmount = driver.FindElement(By.XPath("//span[contains(text(), 'чтобы вес не менялся')]/ancestor::tr[@class='res_row']/following-sibling::tr/td"));
            return caloriesAmount;
        }
    }
}
