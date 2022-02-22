using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using System.Linq;

namespace Pract15
{
    public class TVPage : BasePage
    {
        private readonly By Label_AddToComparisonBy = By.XPath("//*[contains(@title,'В сравнени') and not(ancestor::div[@class='schema-product schema-product_children'])]");
        private readonly By Input_AddToComparisonBy = By.XPath("//*[contains(@title,'В сравнени') and not(ancestor::div[@class='schema-product schema-product_children'])]//input");
        private readonly By Button_CompareBy = By.XPath("//a[contains(@href, 'compare')]");
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

        public IList<IWebElement> LabelList => Driver.FindElements(Label_AddToComparisonBy);
        public IList<IWebElement> InputList => Driver.FindElements(Input_AddToComparisonBy);
        public IWebElement Button_Compare => Driver.FindElement(Button_CompareBy);
    }
}
