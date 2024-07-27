using SeleniumPOMExerscise.Pages;

namespace SeleniumPOMExerscise.Tests
{
    public class LoginTests : BaseTests
    {
        [Test]
        public void TestLoginWithValidCredentials()
        {
            Login("standard_user", "secret_sauce");

            Assert.That(inventoryPage.IsPageLoaded(), Is.True, "The inventory page is not loaded after successfull login");
        }

        [Test]
        public void TestLoginWithInvalidCredentials()
        {
            Login("invalid_User", "secret_sauce");

            var error = loginPage.GetErrorMessage();

            Assert.That(error.Contains("Username and password do not match any user in this service"), "Error message is not correct");
        }

        [Test]
        public void TestLoginWithLockedUser()
        {
            Login("locked_out_user", "secret_sauce");

            var error = loginPage.GetErrorMessage();

            Assert.That(error.Contains("Sorry, this user has been locked out."), "Error message is not correct");
        }
    }
}
