using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace Pract14
{
    public class InventoryPage : BasePage
    {
        private readonly By Link_ShoppingCartBy = By.ClassName("shopping_cart_link");
        private readonly By DropDown_ProductSortBy = By.ClassName("product_sort_container");
        private readonly By Div_ItemPricesBy = By.ClassName("inventory_item_price");
        private readonly By Div_ItemNamesBy = By.ClassName("inventory_item_name");

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

        public List<string> GetNamesList()
        {
            var nameList = new List<string>();
            foreach (var name in ItemNames)
            {
                nameList.Add(name.Text);
            }
            return nameList;
        }

        public IWebElement Link_ShoppingCart => Driver.FindElement(Link_ShoppingCartBy);
        public SelectElement DropDown_ProductSort =>  new SelectElement(Driver.FindElement(DropDown_ProductSortBy));
        public IEnumerable<IWebElement> ItemPrices => Driver.FindElements(Div_ItemPricesBy);
        public IEnumerable<IWebElement> ItemNames => Driver.FindElements(Div_ItemNamesBy);
        

    }
}
