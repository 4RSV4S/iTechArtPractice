using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Pract15
{
    public class BaseTest
    {
        protected IWebDriver Driver;
        protected TVPage TVPage;
        protected ComparisonPage ComparisonPage;
        protected WebDriverWait Wait;

        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            TVPage = new TVPage(Driver);
            ComparisonPage = new ComparisonPage(Driver);
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
