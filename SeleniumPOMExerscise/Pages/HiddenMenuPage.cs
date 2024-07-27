using OpenQA.Selenium;

namespace SeleniumPOMExerscise.Pages
{
    public class HiddenMenuPage : BasePage
    {
        private readonly By menuButton = By.CssSelector(".bm-burger-button");
        private readonly By logoutButton = By.LinkText("Logout");
        public HiddenMenuPage(IWebDriver driver) : base(driver)
        {
        }

        public void ClickMenuButton()
        {
            Click(menuButton);
        }

        public void ClickLogoutButton()
        {
            Click(logoutButton);
        }

        public bool IsMenuOpen()
        {
            return FindElement(logoutButton).Displayed;
        }
    }
}
