using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Pract15
{
    public class ComparisonPage : BasePage
    {
        private static readonly By Button_CompareBy = By.XPath("//a[contains(@href, 'compare')]");
        public ComparisonPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement Button_Compare = Driver.FindElement(Button_CompareBy);
    }
}
