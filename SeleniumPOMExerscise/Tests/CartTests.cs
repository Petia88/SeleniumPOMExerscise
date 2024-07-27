namespace SeleniumPOMExerscise.Tests
{
    public class CartTests : BaseTests
    {
        [SetUp]
        public void Setup()
        {
            Login("standard_user", "secret_sauce");
            inventoryPage.AddToCartByIndex(1);
            inventoryPage.ClickCartLink();
        }
        [Test]
        public void TestCartItemDisplayed()
        {
            Assert.True(cartPage.IsCartItemDisplyed(), "There were no products in the cart");
        }

        [Test]
        public void TestClickCheckoutButton()
        {
            cartPage.ClickCheckoutButton();

            Assert.True(checkoutPage.IsPageLoaded(), "Not navigate to the checkout page");
        }
    }
}
