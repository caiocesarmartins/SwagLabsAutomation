using BoDi;
using Caio.SwagLabsAutomation.Shared.Helpers;
using Caio.SwagLabsAutomation.Shared.Models;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;

namespace Caio.SwagLabsAutomation.Specflow.Hooks
{
    [Binding]
    public sealed class BeforeScenarioHooks
    {
        #region Initializing

        private readonly IObjectContainer _container;
        private readonly IConfiguration _configuration;
        private readonly ScenarioContext _scenarioContext;

        public BeforeScenarioHooks(IObjectContainer container, ScenarioContext scenarioContext)
        {
            _container = container;

            _configuration = new ConfigurationBuilder().AddJsonFile("RunSettings.json", optional: false, reloadOnChange: true).Build();
            _container.RegisterInstanceAs(_configuration);

            _scenarioContext = scenarioContext;
        }

        #endregion

        #region Dependency Injection

        [BeforeScenario(Order = 1)]
        public void RegisterRunSettings()
        {
            var runSettings = new RunSettings(_configuration);

            _container.RegisterInstanceAs(runSettings);
        }

        [BeforeScenario(Order = 1000)]
        public void RegisterIWebDriver()
        {
            _container.RegisterInstanceAs((IWebDriver)_scenarioContext.GetDriver());
        }

        [BeforeScenario(Order = 1001)]
        public void RegisterRootUrl()
        {
            _container.RegisterInstanceAs(new RootUrl(_scenarioContext));
        }

        #endregion

        #region Populating Scenario Context

        [BeforeScenario(Order = 100)]
        public void SetIWebDriver(RunSettings runSettings)
        {
            _scenarioContext["Driver"] = WebDriverHelper.GetDriver(runSettings.Browser);
        }

        [BeforeScenario(Order = 101)]
        public void SetBaseURL(RunSettings runSettings)
        {
            _scenarioContext["BaseURL"] = runSettings.BaseURL;
        }
        #endregion
    }
}