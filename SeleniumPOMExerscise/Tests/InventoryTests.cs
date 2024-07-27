namespace SeleniumPOMExerscise.Tests
{
    public class InventoryTests : BaseTests
    {
        [SetUp]
        public void SetUp()
        {
            Login("standard_user", "secret_sauce");
        }

        [Test]
        public void TestInventoryDisplay()
        {
            Assert.That(inventoryPage.IsInventoryDisplayed(), Is.True, "Inventory Page has no items displayed");
        }

        [Test]
        public void TestAddToCartByIndex()
        {
            inventoryPage.AddToCartByIndex(1);

            inventoryPage.ClickCartLink();

            Assert.That(cartPage.IsCartItemDisplyed(), Is.True, "Cart item was not added in the cart");
        }

        [Test]
        public void TestAddToCartByName()
        {
            inventoryPage.AddToCartByName("Sauce Labs Bike Light");

            inventoryPage.ClickCartLink();

            Assert.That(cartPage.IsCartItemDisplyed(), Is.True, "Cart item was not added in the cart");
        }

        [Test]
        public void TestpageTitle()
        {
            Assert.That(inventoryPage.IsPageLoaded(), Is.True, "Inventory page not loaded correctlly");
        }
    }
}
