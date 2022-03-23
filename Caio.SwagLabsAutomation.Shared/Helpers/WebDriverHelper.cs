using Caio.SwagLabsAutomation.Shared.Enums;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using WebDriverManager;
using WebDriverManager.DriverConfigs;
using WebDriverManager.DriverConfigs.Impl;

namespace Caio.SwagLabsAutomation.Shared.Helpers
{
    public static class WebDriverHelper
    {
        public static IWebDriver GetDriver(string driverTypeAsString)
        {
            var driverType = ResolveDriverType(driverTypeAsString);

            SetUpDriver(driverType);

            return driverType switch
            {
                WebDriverType.CHROME => new ChromeDriver(),
                WebDriverType.FIREFOX => new FirefoxDriver(),
                WebDriverType.EDGE => new EdgeDriver(),
                _ => new ChromeDriver()
            };
        }

        private static void SetUpDriver(WebDriverType driverType)
        {
            IDriverConfig driverConfig = driverType switch
            {
                WebDriverType.CHROME => new ChromeConfig(),
                WebDriverType.FIREFOX => new FirefoxConfig(),
                WebDriverType.EDGE => new EdgeConfig(),
                _ => new ChromeConfig()
            };

            new DriverManager().SetUpDriver(driverConfig);
        }

        private static WebDriverType ResolveDriverType(string typeAsString)
        {
            return Enum.TryParse<WebDriverType>(typeAsString, ignoreCase: true, out var driverType)
                ? driverType
                : WebDriverType.CHROME;
        }
    }
}
