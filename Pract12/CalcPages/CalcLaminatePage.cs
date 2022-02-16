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
    public class CalcLaminatePage
    {
        private IWebDriver Driver;

        public CalcLaminatePage(IWebDriver driver)
        {
            this.Driver = driver;
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public void OpenCalcLaminatePage()
        {
            Driver.Navigate().GoToUrl("https://calc.by/building-calculators/laminate.html");
        }

        public void ChooseLayingMethod(string method)
        {
            IWebElement dropDown = Driver.FindElement(By.Id("laying_method_laminate"));
            SelectElement selectElement = new SelectElement(dropDown);
            selectElement.SelectByText(method);
        }

        public void EnterRoomLength(string length)
        {
            IWebElement textField = Driver.FindElement(By.Id("ln_room_id"));
            textField.Clear();
            textField.SendKeys(length);
        }

        public void EnterRoomWidth(string width)
        {
            IWebElement textField = Driver.FindElement(By.Id("wd_room_id"));
            textField.Clear();
            textField.SendKeys(width);
        }

        public void EnterPanelLength(string length)
        {
            IWebElement textField = Driver.FindElement(By.Id("ln_lam_id"));
            textField.Clear();
            textField.SendKeys(length);
        }
        public void EnterPanelWidth(string width)
        {
            IWebElement textField = Driver.FindElement(By.Id("wd_lam_id"));
            textField.Clear();
            textField.SendKeys(width);
        }

        public void ChooseLayingDirection(string laying)
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
        }

        public void ClickCalculateButton()
        {
            IWebElement calcBttn = Driver.FindElement(By.XPath("//a[text()='Рассчитать']"));
            calcBttn.Click();
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
