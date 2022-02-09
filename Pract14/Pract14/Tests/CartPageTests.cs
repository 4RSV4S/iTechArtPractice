using NUnit.Framework;

namespace Pract14
{
    [TestFixture]
    public class CartPageTests : BaseTest
    {
        [Test]
        public void Cart_NoOneItemAdded_CartIsEmpty()
        {
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.LogInAs(Users.StandardUser);
            CartPage cartPage = new CartPage(Driver);

            Assert.IsEmpty(cartPage.ItemList);
        }
    }
}
