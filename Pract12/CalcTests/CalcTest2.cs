using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Pract12.CalcTests
{
    class CalcTest2
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Test2()
        {
            CalcCaloriesPage page = new CalcCaloriesPage(driver);
            page.OpenCalcCaloriesPage();
            Assert.AreEqual("https://www.calc.ru/kalkulyator-kalorii.html", driver.Url);
            page.ChoosePhysicalActivityDegree("5 раз в неделю");
            page.EnterAge("35");
            page.EnterWeight("85");
            page.EnterHeight("185");
            page.ClickSubmitBttn();
            Assert.AreEqual("3028 ккал/день", page.GetDailyCaloriesAmount().Text);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
