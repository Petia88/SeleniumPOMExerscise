namespace SeleniumPOMExerscise.Tests
{
    public class CheckoutTests : BaseTests
    {
        [SetUp]
        public void Setup()
        {
            Login("standard_user", "secret_sauce");
            inventoryPage.AddToCartByIndex(1);
            inventoryPage.ClickCartLink();
            cartPage.ClickCheckoutButton();
        }

        [Test]
        public void TestCheckoutPageLoaded()
        {
            Assert.True(checkoutPage.IsPageLoaded(), "Checkout page not loaded");
        }

        [Test]
        public void TestContinueToNextStep()
        {
            checkoutPage.EnterFirstName("Petia");
            checkoutPage.EnterLastName("Bogdanova");
            checkoutPage.EnterPostalCode("1000");
            checkoutPage.ClickContinueButton();

            Assert.That(driver.Url.Contains("checkout-step-two.html"), Is.True, "Not navigated to the correct checkout");
        }

        [Test]
        public void TestCompleteOrder()
        {
            checkoutPage.EnterFirstName("Petia");
            checkoutPage.EnterLastName("Bogdanova");
            checkoutPage.EnterPostalCode("1000");
            checkoutPage.ClickContinueButton();
            checkoutPage.ClickFinishButton();

            Assert.True(checkoutPage.IsCheckoutComplete(), "Checkout was not completed");
        }
    }
}
