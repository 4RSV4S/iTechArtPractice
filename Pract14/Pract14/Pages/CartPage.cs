using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace Pract14
{
    public class CartPage : BasePage
    {
        private static readonly By Button_ContinueShoppingBy = By.Id("continue-shopping");
        private static readonly By Button_CheckoutBy = By.Id("checkout");
        private static readonly By Div_CartItemBy = By.CssSelector(".cart_list .cart_item");
        public CartPage(IWebDriver driver) : base(driver)
        {
        }
        protected override void OpenPage()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.Navigate().GoToUrl(Configurator.BaseURL + Configurator.CartPage_END_POINT);
        }

        public IWebElement Button_ContinueShopping => Driver.FindElement(Button_ContinueShoppingBy);
        public IWebElement Button_Checkout => Driver.FindElement(Button_CheckoutBy);
        public IEnumerable<IWebElement> ItemList => Driver.FindElements(Div_CartItemBy);
    }
}
