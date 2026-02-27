using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace E_Commerce_End_to_End_Automation_Framework.Framework.Pages
{
    internal class CartPage : Form
    {
        private const string PageName = "Swag Labs";

        private IList<IButton> RemoveButtons => ElementFactory.FindElements<IButton>(By.XPath("//button[contains(@data-test,'remove')]"), "Remove buttons");
        private IButton CheckoutBtn => ElementFactory.GetButton(By.Id("checkout"), "Checkout button");
        public CartPage() : base(By.XPath(string.Format(LocatorConstants.PreciseTextLocator, PageName)), PageName)
        {
        }

        public void RemoveRandomItem()
        {
            var buttons = RemoveButtons;

            if (buttons.Count == 0)
                throw new Exception("No remove buttons found");

            var random = new Random();
            buttons[random.Next(buttons.Count)].Click();
        }

        public void ClickCheckoutButton()
        {
            CheckoutBtn.Click();
        }
    }
}