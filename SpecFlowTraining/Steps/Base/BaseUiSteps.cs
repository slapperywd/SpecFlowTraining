using BoDi;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecFlowTraining.Steps.Base
{
    public class BaseUiSteps : TechTalk.SpecFlow.Steps
    {
        private IObjectContainer _objectContainer;
        
        public BaseUiSteps(IObjectContainer objectContainer)
        {
            this._objectContainer = objectContainer;
        }

        public BaseUiSteps()
        {
            
        }

        public IWebDriver Driver
        {
            get
            {
                this.AssertInitialized();
                return this._objectContainer.Resolve<IWebDriver>("ChromeDriver");
            }
        }
    }
}
