using Aquality.Selenium.Browsers;
using E_Commerce_End_to_End_Automation_Framework.Framework.Pages;
using TechTalk.SpecFlow;

namespace E_Commerce_End_to_End_Automation_Framework.Framework.StepDefinitions
{
    [Binding]
    internal class CheckOutSteps
    {
        CheckoutPage checkoutPage = new();
        private User user;
        private void LoadPersonalInfo()
        {
            user = TestDataHelper.GetPersonalInfo();
        }

        [When(@"I click on continue button")]
        public void ClickContinueButtonWithoutFillingTheForm()
        {
            checkoutPage.ContinueCheckout();
        }

        [Then(@"I verify error message is displayed")]
        public void ThenIVerifyErrorMessageIsDisplayed()
        {
            Assert.That(checkoutPage.IsErrorMessageDisplayed(), Is.EqualTo("Error: First Name is required"));
        }

        [When(@"I input first name")]
        public void WhenIInputFirstName()
        {
            LoadPersonalInfo();
            checkoutPage.EnterFirstName(user.FirstName);
        }
        [When(@"I input last name")]
        public void WhenIInputLastName()
        {
            LoadPersonalInfo();
            checkoutPage.EnterLastName(user.LastName);
        }
        [When(@"I input postal code")]
        public void WhenIInputPostalCode()
        {
            LoadPersonalInfo();
            checkoutPage.EnterPostalCode(user.PostalCode);
        }
        [When(@"I click on finish button")]
        public void WhenIClickOnFinishButton()
        {
            checkoutPage.ClickFinishButton();
        }
        [Then(@"I verify order is completed successfully")]
        public void ThenIVerifyOrderIsComplete()
        {
            Assert.That(checkoutPage.GetCompleteHeaderText(), Is.EqualTo("Thank you for your order!"));
        }
        [When(@"I refresh the page")]
        public void WhenIFillInTheCheckoutForm()
        {
            AqualityServices.Browser.Refresh();
        }
        [Then(@"I verify URL is correct")]
        public void ThenIVerifyURLIsCorrect()
        {
            Assert.That(AqualityServices.Browser.Driver.Url, Is.EqualTo("https://www.saucedemo.com/checkout-step-two.html"));
        }
        [Then(@"cart is not empty")]
        public void ThenCartIsNotEmpty()
        {
            Assert.That(AqualityServices.Browser.Driver.Url, Is.EqualTo("https://www.saucedemo.com/checkout-step-two.html"));
        }
    }
}