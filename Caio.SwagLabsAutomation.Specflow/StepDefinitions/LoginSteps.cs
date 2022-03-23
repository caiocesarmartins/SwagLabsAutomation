using Caio.SwagLabsAutomation.PageObjects;
using Caio.SwagLabsAutomation.Shared.Models;
using OpenQA.Selenium;

namespace Caio.SwagLabsAutomation.Specflow.StepDefinitions
{
    [Binding]
    public sealed class LoginSteps : Steps
    {
        private readonly LoginPage _loginPage;

        public LoginSteps(IWebDriver driver, RootUrl rootUrl, LoginPage loginPage) : base(driver, rootUrl)
        {
            _loginPage = loginPage;
        }

        [Given(@"I am in the login page")]
        public void GivenIAmInTheLoginPage()
        {
            _loginPage.GoTo();
        }

        [Given(@"I have filled the login form with '([^']*)' as username and '([^']*)' as password")]
        public void GivenIHaveFilledTheLoginFormWithAsUsernameAndAsPassword(string username, string password)
        {
            _loginPage.UsernameInput.SendKeys(username);
            _loginPage.PasswordInput.SendKeys(password);
        }

        [When(@"I submit the login form")]
        public void WhenISubmitTheLoginForm()
        {
            _loginPage.LoginButton.Click();
        }

        [Then(@"I am in the Login page")]
        public void ThenIAmInTheLoginPage()
        {
            Driver.Url.Should().Be(RootUrl.Url);
        }

        [Then(@"the error ""([^""]*)"" is shown")]
        public void ThenTheErrorIsShown(string errorMessage)
        {
            _loginPage.ErrorMessage.Text.Should().Contain("Epic sadface: Username is required");
        }
    }
}