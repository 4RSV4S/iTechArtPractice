using OpenQA.Selenium;
using System.Collections.Generic;

namespace Pract15
{
    public class GooglePlayPage : BasePage
    {
        private readonly By A_MoreLinkBy = By.LinkText("See more");
        private readonly By Div_SimularAppsBy = By.XPath("//div[contains(@class, 'ZmHEEd ')]/div[contains(@class, 'ImZGtf mpg5gc')]");

        public GooglePlayPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement MoreLink => Driver.FindElement(A_MoreLinkBy);
        public IList<IWebElement> SimularAppsList => Driver.FindElements(Div_SimularAppsBy);
    }
}
