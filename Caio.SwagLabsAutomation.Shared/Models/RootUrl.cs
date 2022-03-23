using TechTalk.SpecFlow;

namespace Caio.SwagLabsAutomation.Shared.Models
{
    public class RootUrl
    {
        public string Url;

        public RootUrl(ScenarioContext scenarioContext)
        {
            Url = scenarioContext.GetBaseUrl();
        }
    }
}
