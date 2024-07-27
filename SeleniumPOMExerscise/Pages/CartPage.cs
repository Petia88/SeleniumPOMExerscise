using OpenQA.Selenium;

namespace SeleniumPOMExerscise.Pages
{
    public class CartPage : BasePage
    {
        private readonly By cartItem = By.CssSelector(".cart_item");
        private readonly By checkoutButton = By.Id("checkout");
        public CartPage(IWebDriver driver) : base(driver)
        {
        }

        public bool IsCartItemDisplyed()
        {
            return FindElement(cartItem).Displayed;
        }

        public void ClickCheckoutButton()
        {
            Click(checkoutButton);
        }
    }
}
