using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Pract15
{
    public abstract class BasePage
    {
        protected string BaseURL = "https://catalog.onliner.by/";
        protected static IWebDriver Driver;

        protected abstract void OpenPage();

        public BasePage(IWebDriver Driver)
        {
            Driver = Driver;
            OpenPage();
        }
    }
}
