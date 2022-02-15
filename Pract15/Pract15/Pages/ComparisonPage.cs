using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Pract15
{
    public class ComparisonPage : BasePage
    {
        private static readonly By Button_CompareBy = By.XPath("//a[contains(@href, 'compare')]");
        private static readonly By Span_Cell_ScreenВiagonalBy = By.XPath("//td[span[contains(text(), 'Диагональ экрана')]]/div");
        public ComparisonPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement Button_Compare => Driver.FindElement(Button_CompareBy);
        public IWebElement Span_Cell_ScreenВiagonal => Driver.FindElement(Span_Cell_ScreenВiagonalBy);
    }
}
