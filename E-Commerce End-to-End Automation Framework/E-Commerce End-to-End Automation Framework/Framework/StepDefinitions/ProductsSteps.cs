using E_Commerce_End_to_End_Automation_Framework.Framework.Pages;
using TechTalk.SpecFlow;

namespace E_Commerce_End_to_End_Automation_Framework.Framework.StepDefinitions
{
    [Binding]
    internal class ProductsSteps
    {
        ProductsPage productsPage = new();

        [Then(@"I am on products page")]
        public void ThenIShouldSeeTheProductsPage()
        {
            Assert.That(productsPage.IsProductsTitleVisible(), Is.True);
        }

        [When(@"Choose Price \(low to high\) from filter dropdown")]
        public void WhenISelectPriceLowToHighFilter()
        {
            productsPage.SelectPriceLowToHigh();
        }

        [Then(@"I verify products are sorted from Price \(low to high\)")]
        public void ThenIShouldSeeProductsSortedByPriceLowToHigh()
        {
            Assert.That(productsPage.IsSortedByPriceLowToHighSelected(), Is.True);
        }

        [When(@"I add (.*) products to cart")]
        public void AddProductsToCart(int count)
        {
            productsPage.AddFirstNProducts(count);
        }

        [Then(@"Cart should contain (.*) products")]
        public void ThenCartShouldContainProducts(int count)
        {
            productsPage.AssertCartProductCount(count);
        }

        [When(@"I click on cart icon")]
        public void GoToCartPage()
        {
            productsPage.ClickOnCartIcon();
        }
    }
}