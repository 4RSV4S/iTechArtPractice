using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using System.Linq;

namespace Pract15
{
    public class TVPage : BasePage
    {
        private static readonly By CheckBox_AddToComparisonBy = By.XPath("//*[contains(@title,'В сравнени') and not(ancestor::div[@class='schema-product schema-product_children'])]");
        private string END_POINT = "tv";

        public TVPage(IWebDriver driver) : base(driver)
        {
            OpenPage();
        }

        public void OpenPage()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.Navigate().GoToUrl(BaseURL + END_POINT);
        }

        public IList<IWebElement> CheckBoxList => Driver.FindElements(CheckBox_AddToComparisonBy);
    }
}
