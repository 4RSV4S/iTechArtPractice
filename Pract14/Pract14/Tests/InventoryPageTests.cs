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
        public void Sort_Price_CorrectSort(string sortWay)
        {
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.LogInAs(Users.StandardUser);
            InventoryPage inventoryPage = new InventoryPage(Driver);

            inventoryPage.DropDown_ProductSort.SelectByValue(sortWay);

            var actualSort = inventoryPage.GetPricesList();

            if (sortWay == "hilo")
            {
                var expectedSort = actualSort.OrderByDescending(p => p);
                Assert.IsTrue(expectedSort.SequenceEqual(actualSort));
            }
            else if (sortWay == "lohi")
            {
                var expectedSort = actualSort.OrderBy(p => p);
                Assert.IsTrue(expectedSort.SequenceEqual(actualSort));
            }
        }
        
        [Test]
        [TestCase("az")]
        [TestCase("za")]
        public void Sort_Name_CorrectSort(string sortWay)
        {
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.LogInAs(Users.StandardUser);
            InventoryPage inventoryPage = new InventoryPage(Driver);

            inventoryPage.DropDown_ProductSort.SelectByValue(sortWay);

            var actualSort = inventoryPage.GetNamesList();

            if (sortWay == "az")
            {
                var expectedSort = actualSort.OrderBy(n => n);
                Assert.IsTrue(expectedSort.SequenceEqual(actualSort));
            }
            else if (sortWay == "za")
            {
                var expectedSort = actualSort.OrderByDescending(n => n);
                Assert.IsTrue(expectedSort.SequenceEqual(actualSort));
            }
        }
    }
}
