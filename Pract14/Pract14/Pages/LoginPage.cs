using OpenQA.Selenium;
using System;

namespace Pract14
{
    public class LoginPage : BasePage
    {
        private readonly By Input_UsernameBy = By.Id("user-name");
        private readonly By Input_PasswordBy = By.Id("password");
        private readonly By Button_LogInBy = By.Id("login-button");
        private readonly By Text_ErrorMessageBy = By.XPath("//*[@class='error-message-container error']/h3[@data-test='error']");

        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        protected override void OpenPage()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.Navigate().GoToUrl(Configurator.BaseURL + Configurator.LoginPage_END_POINT);
        }

        public void LogInAs(string username, string password)
        {
            Input_Username.SendKeys(username);
            Input_Password.SendKeys(password);
            Button_LogIn.Click();
        }
        public void LogInAs(User user)
        {
            Input_Username.SendKeys(user.Username);
            Input_Password.SendKeys(user.Password);
            Button_LogIn.Click();
        }

        public IWebElement Input_Username => Driver.FindElement(Input_UsernameBy);
        public IWebElement Input_Password => Driver.FindElement(Input_PasswordBy);
        public IWebElement Button_LogIn => Driver.FindElement(Button_LogInBy);
        public IWebElement Text_ErrorMessage => Driver.FindElement(Text_ErrorMessageBy);
    }
}
