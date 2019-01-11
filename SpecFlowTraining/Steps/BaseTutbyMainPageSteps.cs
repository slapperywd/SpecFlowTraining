namespace SpecFlowTraining.Steps
{
    using System;

    using TechTalk.SpecFlow;

    // [Binding]
    public class BaseTutbyMainPageSteps
    {
        // make this method private or protected if the superior class is inherited from base to avoid double method invocation
        // it is better to remove/comment [Binding] attribute upon the class if it is intended to be used as Base
        [BeforeScenario()]
        public void BeforeTutbyScenario()
        {
            Console.WriteLine("Precondition before @tutby scenarios");          
        }
    }
}
