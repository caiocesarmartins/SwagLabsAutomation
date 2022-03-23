using OpenQA.Selenium;

namespace TechTalk.SpecFlow
{
    public static class ScenarioContextExtensions
    {
        public static IWebDriver GetDriver(this ScenarioContext scenarioContext) 
            => (IWebDriver)scenarioContext["Driver"];

        public static string GetBaseUrl(this ScenarioContext scenarioContext)
            => (string)scenarioContext["BaseURL"];
    }
}
