using SwagLabs.Utility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SwagLabs.StepDefinitions
{
    [Binding]
    public class Hooks
    {
        [AfterScenario]
        public void TearDown(ScenarioContext scenario)
        {

            if (scenario.TestError != null)
            {
                var error = scenario.TestError;
                Console.WriteLine("An error ocurred:" + error.Message);
                Console.WriteLine("It was of type:" + error.GetType().Name);
            }
            Driver.getDriver().Quit();

        }
    }
}
