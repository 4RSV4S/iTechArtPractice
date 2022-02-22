using OpenQA.Selenium;

namespace Pract15
{
    public class GooglePlayPage : BasePage
    {
        private readonly By A_MoreLinkBy = By.XPath("//*[@id='fcxH9b']/div[4]/c-wiz/div/div[2]/div/aside/c-wiz/c-wiz/c-wiz/div/div[1]/div[2]/a");

        public GooglePlayPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement MoreLink => Driver.FindElement(A_MoreLinkBy);
    }
}
