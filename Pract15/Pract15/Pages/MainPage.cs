using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Pract15
{
    public class MainPage : BasePage
    {
        protected readonly By Input_SearchBy = By.Name("query");
        protected readonly By IFrame_SearchBy = By.XPath("//div[@id='fast-search-modal']//iframe");
        protected readonly By A_SearchResultTitleBy = By.XPath("//a[@class='product__title-link']");
        protected readonly By Input_IFrameSearchBy = By.XPath("//input[@class='search__input']");
        protected readonly By H1_CatalogTitleBy = By.TagName("h1");
        private string URL = "https://onliner.by/";

        public MainPage(IWebDriver driver) : base(driver)
        {
        }
        public void OpenPage()
        {
            Driver.Navigate().GoToUrl(URL);
        }

        public IWebElement Input_Search => Driver.FindElement(Input_SearchBy);
        public IWebElement IFrame_Search => Driver.FindElement(IFrame_SearchBy);
        public IList<IWebElement> A_SearchResultTitleList => Driver.FindElements(A_SearchResultTitleBy);
        public IWebElement Input_IFrameSearch => Driver.FindElement(Input_IFrameSearchBy);
        public IWebElement H1_CatalogTitle => Driver.FindElement(H1_CatalogTitleBy);
    }
}
