using OpenQA.Selenium;

namespace Pract15
{
    public class GooglePlayPage : BasePage
    {
        private readonly By A_MoreLinkBy = By.LinkText("See more");

        public GooglePlayPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement MoreLink => Driver.FindElement(A_MoreLinkBy);
    }
}
