using Caio.SwagLabsAutomation.Shared.Models;
using OpenQA.Selenium;

namespace Caio.SwagLabsAutomation.PageObjects
{
    public abstract class Page
    {
        protected readonly IWebDriver Driver;
        protected readonly RootUrl RootUrl;

        public Page(IWebDriver driver, RootUrl rootUrl)
        {
            Driver = driver;
            RootUrl = rootUrl;
        }

        public abstract void GoTo();
    }
}
