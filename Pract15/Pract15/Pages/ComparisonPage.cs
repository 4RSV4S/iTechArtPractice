using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Pract15
{
    public class ComparisonPage : BasePage
    {
        private readonly By Td_Cell_ScreenDiagonalBy = By.XPath("//td[span[contains(text(), 'Диагональ экрана')] and @class='product-table__cell']");
        private readonly By Span_Cell_ScreenDiagonalBy = By.XPath("//td[span[contains(text(), 'Диагональ экрана')]]//div/span");
        private readonly By Div_TableTippBy = By.CssSelector("#productTableTip > div");
        private readonly By A_DeleteBy = By.XPath("//*[@id='product-table']//div//a[contains(@title, 'Удалить') and not(ancestor::td)]");

        public ComparisonPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement Span_Cell_ScreenDiagonal => Driver.FindElement(Span_Cell_ScreenDiagonalBy);
        public IWebElement Td_Cell_ScreenDiagonal => Driver.FindElement(Td_Cell_ScreenDiagonalBy);
        public IWebElement Div_TableTip => Driver.FindElement(Div_TableTippBy);
        public IList<IWebElement> A_DeleteList => Driver.FindElements(A_DeleteBy);
    }
}
