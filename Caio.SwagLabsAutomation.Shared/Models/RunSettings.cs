using Microsoft.Extensions.Configuration;

namespace Caio.SwagLabsAutomation.Shared.Models
{
    public class RunSettings
    {
        public string Browser { get; private set; }

        public string BaseURL { get; private set; }

        public RunSettings(IConfiguration configuration)
        {
            Browser = configuration.GetValue<string>("Browser");
            BaseURL = configuration.GetValue<string>("BaseURL");
        }
    }
}
