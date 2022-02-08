using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Pract14
{
    [TestFixture]
    public class InventoryPageTests : BaseTest
    {
        [Test]
        [TestCase("hilo")]
        [TestCase("lohi")]
        public void testtest(string sortWay)
        {
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.LogInAs(Users.StandardUser.Username, Configurator.Password);
            InventoryPage page = new InventoryPage(Driver);
            page.DropDown_ProductSort.SelectByValue(sortWay);
            var actualSort = page.GetPricesList();
            if (sortWay == "hilo")
            {
                var expectedSort = actualSort.OrderByDescending(s => s);
                Assert.IsTrue(expectedSort.SequenceEqual(actualSort));
            }
            else if (sortWay == "lohi")
            {
                var expectedSort = actualSort.OrderBy(s => s);
                Assert.IsTrue(expectedSort.SequenceEqual(actualSort));
            }
        }
    }
}
