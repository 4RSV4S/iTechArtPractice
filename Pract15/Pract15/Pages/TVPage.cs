using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Pract15
{
    public class TVPage : BasePage
    {
        private static readonly By CheckBox_AddToComparison = By.XPath("//*[@title='В сравнение' and not(ancestor::div[@class='schema-product schema-product_children'])]//*[@type='checkbox']");
        private string END_POINT = "tv";

        public TVPage(IWebDriver driver) : base(driver)
        {
        }

        protected override void OpenPage()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.Navigate().GoToUrl(BaseURL + END_POINT);
        }

        public IEnumerable<IWebElement> CheckBoxList => Driver.FindElements(CheckBox_AddToComparison);
    }
}
