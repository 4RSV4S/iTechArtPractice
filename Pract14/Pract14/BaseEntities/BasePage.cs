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
        protected IWebDriver Driver;
        protected readonly By Button_SidebarBy = By.Id("react-burger-menu-btn");

        protected abstract void OpenPage();

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            OpenPage();
        }

        protected IWebElement Button_Sidebar => Driver.FindElement(Button_SidebarBy);
    }
}
