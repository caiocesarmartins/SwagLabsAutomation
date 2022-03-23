using Caio.SwagLabsAutomation.Shared.Models;
using OpenQA.Selenium;

namespace Caio.SwagLabsAutomation.PageObjects
{
    public class LoginPage : Page
    {
        #region Page Inheritance

        public LoginPage(IWebDriver driver, RootUrl rootUrl) : base(driver, rootUrl)
        {
        }

        public override void GoTo()
            => Driver.Navigate().GoToUrl(RootUrl.Url);

        #endregion

        #region WebElements

        public IWebElement UsernameInput
            => Driver.FindElement(By.Id("user-name"));

        public IWebElement PasswordInput
            => Driver.FindElement(By.Id("password"));

        public IWebElement LoginButton
            => Driver.FindElement(By.Id("login-button"));

        public IWebElement ErrorMessage
            => Driver.FindElement(By.CssSelector("h3[data-test='error']"));

        #endregion
    }
}
