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
        protected GooglePlayPage GooglePlayPage;
        protected AppleStorePage AppleStorePage;
        protected MainPage MainPage;   

        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            TVPage = new TVPage(Driver);
            ComparisonPage = new ComparisonPage(Driver);
            GooglePlayPage = new GooglePlayPage(Driver);
            AppleStorePage = new AppleStorePage(Driver);
            MainPage = new MainPage(Driver);   
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
