using SpecFlowTraining.Steps.Base;

namespace SpecFlowTraining.Steps
{
    using BoDi;

    using NUnit.Framework;

    using TechTalk.SpecFlow;

    [Binding]
    public class ScopedScenariosSteps : BaseUiSteps
    {
        public ScopedScenariosSteps(IObjectContainer objectContainer) : base(objectContainer)
        {
        }

        [Given(@"I navigate to codewars homepage")]
        public void GivenINavigateToCodewarsHomepage()
        {
            Driver.Navigate().GoToUrl("https://www.codewars.com/");
        }

        [Then(@"home page title is Train with Programming Challenges/Kata \| Codewars")]
        public void ThenHomePageTitleIsTrainWithProgrammingChallengesKataCodewars()
        {
            Assert.IsTrue(Driver.Title.Equals("Train with Programming Challenges/Kata | Codewars"));
        }
    }
}
