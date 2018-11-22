using System;
using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SpecFlowTraining.Steps
{
    using System.Linq;

    using NUnit.Framework;

    [Binding]
    public class TutbyMainPageSteps : BaseTutbyMainPageSteps
    {
        private IWebDriver driver = new ChromeDriver();

        public TutbyMainPageSteps()
        {
            driver.Manage().Window.Maximize();   
        }

        [Given(@"I navigate to home page")]
        public void GivenINavigateToHomePage()
        {
            driver.Navigate().GoToUrl("https://www.tut.by/");
        }
       
        [Then(@"I verify title is equal to '(.*)'")]
        public void ThenIVerifyTitleIsEqualTo(string homePageTitle)
        {
            Console.WriteLine(Path.GetDirectoryName(new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath));
            Assert.IsTrue(driver.Title.Equals(homePageTitle));
        }

        [Then(@"I verify there is a tab on the header with name (.*)")]
        public void ThenIVerifyThereIsATabOnTheHeaderWithName(string tabName)
        {
            Assert.IsTrue(driver.FindElement(By.XPath(string.Format("//li[@class='topbar__li']/a[text()='{0}']", tabName))).Displayed);           
        }
        
        //[AfterStep]
        //public void AfterStep()
        //{
        //    Console.WriteLine("Step INFO" + ScenarioContext.Current.StepContext.StepInfo.Text);
        //}

        [AfterScenario("tutby, tutby-datadriven")]
        public void AfterScenario()
        {
            driver.Quit();
        }

        //[BeforeScenario]
        //public void BeforeScenario()
        //{
        //    Console.WriteLine($"TAGS COUNT : {ScenarioContext.Current.ScenarioInfo.Tags.Length}");
        //    ScenarioContext.Current.ScenarioInfo.Tags.ToList().ForEach(s => Console.WriteLine(s));
        //}
    }
}
