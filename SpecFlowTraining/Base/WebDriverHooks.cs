namespace SpecFlowTraining.Base
{
    using System;

    using BoDi;

    using NUnit.Framework;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;

    using TechTalk.SpecFlow;

    [Binding]
    public class WebDriverHooks
    {
        private readonly IObjectContainer objectContainer;

        public WebDriverHooks(IObjectContainer objectContainer)
        {
            this.objectContainer = objectContainer;
        }

        private IWebDriver SetupWebDriver()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            //options.AddArgument("--disable-notifications");
            return new ChromeDriver(options);
        }

        [BeforeScenario("Ui")]
        public void BeforeScenario()
        {
            Console.WriteLine("Setting up a web driver ... ");
            var webdriver = SetupWebDriver();
            objectContainer.RegisterInstanceAs(webdriver);
        }

        [AfterScenario("Ui")]
        public void AfterScenario()
        {
            Console.WriteLine("Closing a web driver ... ");
            var webDriver = this.objectContainer.Resolve<IWebDriver>();

            // Output any screenshots or log dumps etc

            webDriver.Quit();
            webDriver.Dispose();
        }
    }
}
