using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace E_Commerce_End_to_End_Automation_Framework.Framework.Pages
{
    internal class CheckoutPage : Form
    {
        private const string PageName = "Swag Labs";

        private IButton ContinueBtn => ElementFactory.GetButton(By.Id("continue"), "Continue button");
        private ILabel ErrorMessage => ElementFactory.GetLabel(By.CssSelector("[data-test='error']"), "Checkout error message");
        private ITextBox FirstNameField => ElementFactory.GetTextBox(By.Id("first-name"), "First name field");
        private ITextBox LastNameField => ElementFactory.GetTextBox(By.Id("last-name"), "Last name field");
        private ITextBox PostalCodeField => ElementFactory.GetTextBox(By.Id("postal-code"), "Postal code field");
        private IButton FinishBtn => ElementFactory.GetButton(By.Id("finish"), "Finish button");
        private ILabel CompleteHeader => ElementFactory.GetLabel(By.CssSelector("[data-test='complete-header']"), "Complete order header");
        public CheckoutPage() : base(By.XPath(string.Format(LocatorConstants.PreciseTextLocator, PageName)), PageName)
        {
        }

        public void ContinueCheckout()
        {
            ContinueBtn.Click();
        }

        public string IsErrorMessageDisplayed()
        {
            return ErrorMessage.Text;
        }

        public void EnterFirstName(string firstName)
        {
            FirstNameField.ClearAndType(firstName);
        }
        public void EnterLastName(string lastName)
        {
            LastNameField.ClearAndType(lastName);
        }
        public void EnterPostalCode(string postalCode)
        {
            PostalCodeField.ClearAndType(postalCode);
        }
        public void ClickFinishButton()
        {
            FinishBtn.Click();
        }
        public string GetCompleteHeaderText()
        {
            return CompleteHeader.Text;
        }
    }
}