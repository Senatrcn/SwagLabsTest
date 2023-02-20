using SwagLabs.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SwagLabs.StepDefinitions
{
    [Binding]
    class CheckoutSteps
    {
       private CartPage cartPage = new CartPage();
       private CheckoutPage checkoutPage = new CheckoutPage();

        [When(@"User clicks the checkout button")]
        public void WhenUserClicksTheCheckoutButton()
        {
            cartPage.clicksOnCheckOutButton();
        }

        [Then(@"User sees personal information page")]
        public void ThenUserSeesPersonalInformationPage()
        {
            checkoutPage.verifyCheckoutPage();
        }

        [When(@"User add following details")]
        public void WhenUserAddFollowingDetails(Table informations)
        {
            dynamic data = informations.CreateDynamicInstance();
            checkoutPage.fillInformationForm((string)data.Firstname, (string)data.Lastname, (string)data.Postalcode);
        }

        [When(@"User clicks the continue button")]
        public void WhenUserClicksTheContinueButton()
        {
            checkoutPage.clickContinueButton();
        }

        [Then(@"User sees add information overview")]
        public void ThenUserSeesAddInformationOverview()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"User clicks the finish button")]
        public void WhenUserClicksTheFinishButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"User navigate to complete page")]
        public void ThenUserNavigateToCompletePage()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"User clicks the cancel button")]
        public void WhenUserClicksTheCancelButton()
        {
            checkoutPage.clickCancelButton();
        }


    }
}
