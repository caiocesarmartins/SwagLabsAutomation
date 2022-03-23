using Caio.SwagLabsAutomation.Shared.Models;
using OpenQA.Selenium;

namespace Caio.SwagLabsAutomation.PageObjects
{
    public class ProductsPage : Page
    {
        #region Page Inheritance

        public ProductsPage(IWebDriver driver, RootUrl rootUrl) : base(driver, rootUrl)
        {
        }

        public override void GoTo()
        {
            Driver.Navigate().GoToUrl("inventory.html");
        }

        #endregion

        #region WebElements

        public IWebElement Header
            => Driver.FindElement(By.CssSelector("#header_container .title"));

        #endregion
    }
}
