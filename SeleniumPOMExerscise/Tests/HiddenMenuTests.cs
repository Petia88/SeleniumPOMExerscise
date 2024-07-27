namespace SeleniumPOMExerscise.Tests
{
   public class HiddenMenuTests : BaseTests
    {
        [SetUp]
        public void SetUp()
        {
            Login("standard_user", "secret_sauce");
        }

        [Test]
        public void TestOpenMenu()
        {
            hiddenMenuPage.ClickMenuButton();

            Assert.True(hiddenMenuPage.IsMenuOpen(), "Hidden menu was not open");
        }

        [Test]
        public void TestLogout()
        {
            hiddenMenuPage.ClickMenuButton();
            hiddenMenuPage.ClickLogoutButton();

            Assert.True(driver.Url.Contains("https://www.saucedemo.com/"), "User was not logged out");
        }
    }
}
