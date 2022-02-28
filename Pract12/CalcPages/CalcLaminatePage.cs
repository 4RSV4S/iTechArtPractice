using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Pract12
{
    public class CalcLaminatePage
    {
        private IWebDriver Driver;

        public CalcLaminatePage(IWebDriver driver)
        {
            this.Driver = driver;
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public CalcLaminatePage OpenCalcLaminatePage()
        {
            Driver.Navigate().GoToUrl("https://calc.by/building-calculators/laminate.html");
            return this;
        }

        public CalcLaminatePage ChooseLayingMethod(string method)
        {
            IWebElement dropDown = Driver.FindElement(By.Id("laying_method_laminate"));
            SelectElement selectElement = new SelectElement(dropDown);
            selectElement.SelectByText(method);
            return this;
        }

        public CalcLaminatePage EnterRoomLength(string length)
        {
            IWebElement textField = Driver.FindElement(By.Id("ln_room_id"));
            textField.Clear();
            textField.SendKeys(length);
            return this;
        }

        public CalcLaminatePage EnterRoomWidth(string width)
        {
            IWebElement textField = Driver.FindElement(By.Id("wd_room_id"));
            textField.Clear();
            textField.SendKeys(width);
            return this;
        }

        public CalcLaminatePage EnterPanelLength(string length)
        {
            IWebElement textField = Driver.FindElement(By.Id("ln_lam_id"));
            textField.Clear();
            textField.SendKeys(length);
            return this;
        }
        public CalcLaminatePage EnterPanelWidth(string width)
        {
            IWebElement textField = Driver.FindElement(By.Id("wd_lam_id"));
            textField.Clear();
            textField.SendKeys(width);
            return this;
        }

        public CalcLaminatePage ChooseLayingDirection(string laying)
        {
            IList <IWebElement> radioBttns = Driver.FindElements(By.CssSelector(".cl-ln-value [type=radio]"));

            switch (laying)
            {
                case "по длине комнаты":
                    radioBttns[0].Click();
                    break;
                case "по ширине комнаты":
                    radioBttns[1].Click();
                    break;
                case "по диагонали 45°":
                    radioBttns[2].Click();
                    break;
                case "по диагонали 135°":
                    radioBttns[3].Click();
                    break;
            }
            return this;
        }

        public CalcLaminatePage ClickCalculateButton()
        {
            IWebElement calcBttn = Driver.FindElement(By.XPath("//a[text()='Рассчитать']"));
            calcBttn.Click();
            return this;
        }

        public IWebElement GetRequiredBoardsNumber()
        {
            IWebElement spanResult = Driver.FindElement(By.XPath("//div[text()='Требуемое количество досок ламината: ']/child::span"));
            return spanResult;
        }

        public IWebElement GetPackagesNumber()
        {
            IWebElement spanResult = Driver.FindElement(By.XPath("//div[text()='Количество упаковок ламината: ']/child::span"));
            return spanResult;
        }
            
    }
}
