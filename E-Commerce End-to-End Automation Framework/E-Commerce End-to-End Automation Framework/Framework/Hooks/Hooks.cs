using Aquality.Selenium.Browsers;
using Aquality.Selenium.Core.Utilities;
using TechTalk.SpecFlow;

namespace E_Commerce_End_to_End_Automation_Framework.Framework
{
    [Binding]
    internal class Hooks
    {
        private readonly Browser browser = AqualityServices.Browser;
        private static readonly JsonSettingsFile settings = new("config.json");

        [BeforeScenario]
        public void setup()
        {
            browser.Maximize();
            browser.GoTo(settings.GetValue<string>("url"));
        }
        [BeforeScenario("SpecialUrl")]
        public void OpenSpecialUrl()
        {
            browser.Maximize();
            browser.GoTo(settings.GetValue<string>("specliaUrl"));
        }

        [AfterScenario]
        public void teardown()
        {
            browser.Quit();
        }
    }
}