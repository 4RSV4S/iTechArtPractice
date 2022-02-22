using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Pract12.CalcTests
{
    class CalcTest2
    {
        private IWebDriver Driver;

        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
        }

        [Test]
        public void Test2()
        {
            CalcCaloriesPage page = new CalcCaloriesPage(Driver);
            
            page.OpenCalcCaloriesPage()
                .ChoosePhysicalActivityDegree("5 раз в неделю")
                .EnterAge("35")
                .EnterWeight("85")
                .EnterHeight("185")
                .ClickSubmitBttn();

            Assert.AreEqual("https://www.calc.ru/kalkulyator-kalorii.html", Driver.Url);
            Assert.AreEqual("3028 ккал/день", page.GetDailyCaloriesAmount().Text);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
