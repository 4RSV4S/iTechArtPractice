using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Pract14
{
    public abstract class BasePage
    {
        protected static IWebDriver Driver;

        protected abstract void OpenPage();

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            OpenPage();
        }
    }
}
