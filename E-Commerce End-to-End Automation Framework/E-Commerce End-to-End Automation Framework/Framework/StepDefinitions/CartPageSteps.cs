using E_Commerce_End_to_End_Automation_Framework.Framework.Pages;
using TechTalk.SpecFlow;

namespace E_Commerce_End_to_End_Automation_Framework.Framework.StepDefinitions
{
    [Binding]
    internal class CartPageSteps
    {
        CartPage cartPage = new();
        ProductsPage productsPage = new();

        [When(@"I remove random item from cart")]
        public void RemoveRandomItemFromCart()
        {
            cartPage.RemoveRandomItem();
        }

        [When(@"I click on checkout button")]
        public void ClickCheckoutButton()
        {
            cartPage.ClickCheckoutButton();
        }
    }
}
