using SwagLabs.Pages;
using SwagLabs.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SwagLabs.StepDefinitions
{
    public class ProductSortSteps
    {
        ProductsPage productsPage = new ProductsPage();

        [When(@"User select '(.*)' option in the sort dropdown")]
        public void WhenUserSelectOptionInTheSortDropdown(string option)
        {
            productsPage.selectSortDropDown(option);
        }

        [Then(@"User sees products are sorted in '(.*)' order")]
        public void ThenUserSeesProductsAreSortedInOrder(string option)
        {
            Asserts.assertTrue(productsPage.CheckProductsInOrder(option));
        }

    }
}
