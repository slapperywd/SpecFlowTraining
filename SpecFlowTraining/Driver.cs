namespace SpecFlowTraining
{
    using BoDi;

    using OpenQA.Selenium;

    using TechTalk.SpecFlow;

    [Binding]
    public class Driver 
    {
        private  IObjectContainer ObjectContainer { get; set; }

        private Driver(IObjectContainer objectContainer)
        {
            ObjectContainer = objectContainer;
        }

        public Driver()
        {
            
        }

        public IWebDriver GetDriver()
        {
            return ObjectContainer.Resolve<IWebDriver>();
        }
    }
}
