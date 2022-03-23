using Caio.SwagLabsAutomation.Shared.Models;
using OpenQA.Selenium;

namespace Caio.SwagLabsAutomation.Specflow.StepDefinitions
{
    [Binding]
    public class Steps
    {
        protected IWebDriver Driver;
        protected RootUrl RootUrl;

        public Steps(IWebDriver driver, RootUrl rootUrl)
        {
            Driver = driver;
            RootUrl = rootUrl;
        }
    }
}