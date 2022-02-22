using OpenQA.Selenium;

namespace Pract15
{
    public class AppleStorePage : BasePage
    {
        private readonly By A_MoreLinkBy = By.XPath("//div[contains(@class, 'section__description')]//button");

        public AppleStorePage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement MoreLink => Driver.FindElement(A_MoreLinkBy);
    }
}
