﻿using NUnit.Framework;
using System.Linq;

namespace Pract14
{
    [TestFixture]
    class LoginPageTests : BaseTest
    {
        static User[] ValidUsers =
        {
            Users.StandardUser,
            Users.ProblemUser,
            Users.PerfomanceGlitchUser
        };

        [Test]
        [TestCaseSource(nameof(ValidUsers))]
        public void LogIn_ExistingUser_GoToTheInventoryPage(User user)
        {
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.LogInAs(user.Username, user.Password);
            Assert.AreEqual(Configurator.BaseURL + Configurator.InventoryPage_END_POINT, Driver.Url);
        }

        [Test]
        public void LogIn_LockedUser_ErrorMessageDislpays()
        {
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.LogInAs(Users.LockedOutUser.Username, Configurator.Password);
            string actualErrorMsg = loginPage.Text_ErrorMessage.Text;
            string expectedErrorMsg = "Epic sadface: Sorry, this user has been locked out.";
            Assert.AreEqual(expectedErrorMsg, actualErrorMsg);
        }
        
        [Test]
        public void LogIn_NonExistingUser_ErrorMessageDislpays()
        {
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.LogInAs("wanttologin", "nonexistent");
            string actualErrorMsg = loginPage.Text_ErrorMessage.Text;
            string expectedErrorMsg = "Epic sadface: Username and password do not match any user in this service";
            Assert.AreEqual(expectedErrorMsg, actualErrorMsg);
        }

        [Test]
        public void testtest()
        {
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.LogInAs(Users.StandardUser.Username, Configurator.Password);
            InventoryPage page = new InventoryPage(Driver);
            page.DropDown_ProductSort.SelectByValue("lohi");
            var actualSort = page.GetPricesList();
            var expectedSort = actualSort.OrderByDescending(s => s);
            Assert.IsTrue(expectedSort.SequenceEqual(actualSort));
        }
    }
}