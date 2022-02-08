using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace Pract14
{
    public class InventoryPage : BasePage
    {
        private static readonly By Link_ShoppingCartBy = By.Id("shopping_cart_container");
        private static readonly By DropDown_ProductSortBy = By.ClassName("product_sort_container");
        private static readonly By Div_ItemPricesBy = By.ClassName("inventory_item_price");

        public InventoryPage(IWebDriver driver) : base(driver)
        {
        }
        protected override void OpenPage()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.Navigate().GoToUrl(Configurator.BaseURL + Configurator.InventoryPage_END_POINT);
        }

        public List<double> GetPricesList()
        {
            var priceList = new List<double>();
            foreach (var price in ItemPrices)
            {
                priceList.Add(Convert.ToDouble(price.Text.Replace('$',' ').Replace('.',',')));
            }
            return priceList;
        }

        public IWebElement Link_ShoppingCart => Driver.FindElement(Link_ShoppingCartBy);
        public SelectElement DropDown_ProductSort =>  new SelectElement(Driver.FindElement(DropDown_ProductSortBy));
        public IEnumerable<IWebElement> ItemPrices => Driver.FindElements(Div_ItemPricesBy);
        

    }
}
