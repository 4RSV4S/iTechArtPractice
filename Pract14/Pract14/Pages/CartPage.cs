using OpenQA.Selenium;
using System;

namespace Pract14.Pages
{
    public class CartPage : BasePage
    {
        private static readonly By Button_ContinueShoppingBy = By.Id("continue-shopping");
        private static readonly By Button_CheckoutBy = By.Id("checkout");
        public CartPage(IWebDriver driver) : base(driver)
        {
        }
        protected override void OpenPage()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.Navigate().GoToUrl(Configurator.BaseURL + Configurator.InventoryPage_END_POINT);
        }

        public IWebElement Button_ContinueShopping = Driver.FindElement(Button_ContinueShoppingBy);
        public IWebElement Button_Checkout = Driver.FindElement(Button_CheckoutBy);
    }
}
