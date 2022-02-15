using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Pract15
{
    public abstract class BasePage
    {
        protected string BaseURL = "https://catalog.onliner.by/";
        protected static IWebDriver Driver;

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public void MoveToElement(IWebElement element)
        {
            Actions action = new Actions(Driver);
            action.MoveToElement(element).Click().Build().Perform();
        }
    }
}
