namespace SpecFlowTraining.Steps
{
    using BoDi;

    using NUnit.Framework;

    using OpenQA.Selenium;

    using SpecFlowTraining.Base;

    using TechTalk.SpecFlow;

    [Binding]
    public class ScopedScenariosSteps
    {
        private readonly IWebDriver driver;

        public ScopedScenariosSteps(IObjectContainer objectContainer)
        {
           // this.objectContainer = objectContainer;
            this.driver = objectContainer.Resolve<IWebDriver>();
        }

        [Given(@"I navigate to codewars homepage")]
        public void GivenINavigateToCodewarsHomepage()
        {
            this.driver.Navigate().GoToUrl("https://www.codewars.com/");
        }

        [Then(@"home page title is Train with Programming Challenges/Kata \| Codewars")]
        public void ThenHomePageTitleIsTrainWithProgrammingChallengesKataCodewars()
        {
            Assert.IsTrue(this.driver.Title.Equals("Train with Programming Challenges/Kata | Codewars"));
        }
    }
}
