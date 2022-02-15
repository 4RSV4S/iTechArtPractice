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

<<<<<<< HEAD
        public void MoveToElement(IWebElement element)
        {
            Actions action = new Actions(Driver);
            action.MoveToElement(element).Click().Build().Perform();
=======
        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            OpenPage();
>>>>>>> 8c4371e21b28f04dcd916cd25945d5013b34fc54
        }
    }
}
