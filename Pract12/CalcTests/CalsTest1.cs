using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Pract12
{
    class CalsTest1
    {
        private IWebDriver Driver;

        [SetUp]
        public void SetUp()
        {
            Driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            CalcLaminatePage page = new CalcLaminatePage(Driver);
            page.OpenCalcLaminatePage()
                .ChooseLayingMethod("с использованием отрезанного элемента")
                .EnterRoomLength("500")
                .EnterRoomWidth("400")
                .EnterPanelLength("2000")
                .EnterPanelWidth("200")
                .ChooseLayingDirection("по ширине комнаты")
                .ClickCalculateButton();
            Assert.AreEqual("https://calc.by/building-calculators/laminate.html", Driver.Url);
            Assert.AreEqual("53", page.GetRequiredBoardsNumber().Text);
            Assert.AreEqual("7", page.GetPackagesNumber().Text);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
