namespace Caio.SwagLabsAutomation.Specflow.Hooks
{
    [Binding]
    public sealed class AfterScenarioHooks
    {
        [AfterScenario]
        public void QuitingWebDriver(ScenarioContext scenarioContext)
        {
            if (scenarioContext.GetDriver() is not null) 
                scenarioContext.GetDriver().Quit();
        }
    }
}