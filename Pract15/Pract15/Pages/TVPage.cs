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
        private readonly By A_AppleStoreLinkBy = By.XPath("//div[@id='schema-filter']//a[contains(@href, 'apple')]");
        private readonly By A_GooglePlayLinkBy = By.XPath("//div[@id='schema-filter']//a[contains(@href, 'google')]");
        private readonly By IFrame_GoogleAdsBy = By.Id("google_ads_iframe_/282428283/new_catalog_100x90_2_0");
        private readonly By A_AdLinkBy = By.Id("aw0");
        private readonly By Div_SimularAppsBy = By.XPath("//div[contains(@class, 'ZmHEEd ')]/div[contains(@class, 'ImZGtf mpg5gc')]");
        private string END_POINT = "tv";

        public TVPage(IWebDriver driver) : base(driver)
        {
        }

        public void OpenPage()
        {
            Driver.Navigate().GoToUrl(BaseURL + END_POINT);
        }

        public IList<IWebElement> LabelList => Driver.FindElements(Label_AddToComparisonBy);
        public IList<IWebElement> InputList => Driver.FindElements(Input_AddToComparisonBy);
        public IWebElement Button_Compare => Driver.FindElement(Button_CompareBy);
        public IWebElement AppleStoreLink => Driver.FindElement(A_AppleStoreLinkBy);
        public IWebElement GooglePlayLink => Driver.FindElement(A_GooglePlayLinkBy);
        public IWebElement IFrame_GoogleAds => Driver.FindElement(IFrame_GoogleAdsBy);
        public IWebElement AdLink => Driver.FindElement(A_AdLinkBy);
        public IList<IWebElement> SimularAppsList => Driver.FindElements(Div_SimularAppsBy);
    }
}
