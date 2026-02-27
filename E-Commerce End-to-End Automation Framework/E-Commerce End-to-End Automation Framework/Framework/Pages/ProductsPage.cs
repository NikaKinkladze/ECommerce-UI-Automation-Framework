using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace E_Commerce_End_to_End_Automation_Framework.Framework.Pages
{
    internal class ProductsPage : Form
    {
        private const string PageName = "Swag Labs";
        private ILabel ProductHeader => ElementFactory.GetLabel(By.CssSelector("[data-test='title']"), "Products title");
        private IComboBox Filter => ElementFactory.GetComboBox(By.CssSelector("[data-test='product-sort-container']"), "filter dropdown");
        private IList<IButton> AddToCartButtons => ElementFactory.FindElements<IButton>(By.CssSelector("button[data-test^='add-to-cart']"), "Add to cart buttons");
        private ILabel CartBadge => ElementFactory.GetLabel(By.CssSelector("[data-test='shopping-cart-badge']"), "Cart badge");
        private IButton CartIcon => ElementFactory.GetButton(By.Id("shopping_cart_container"), "Cart icon");

        public ProductsPage() : base(By.XPath(string.Format(LocatorConstants.PreciseTextLocator, PageName)), PageName)
        {
        }

        public bool IsProductsTitleVisible()
        {
            return ProductHeader.State.IsDisplayed;
        }

        public void SelectPriceLowToHigh()
        {
            Filter.SelectByValue("lohi");
        }

        public bool IsSortedByPriceLowToHighSelected()
        {
            return Filter.SelectedValue.Equals("lohi");
        }

        public void AddFirstNProducts(int count)
        {
            for (int i = 0; i < count; i++)
            {
                AddToCartButtons[i].Click();
            }
        }

        public void AssertCartProductCount(int expectedCount)
        {
            var actualCount = int.Parse(CartBadge.Text);

            Assert.That(actualCount, Is.EqualTo(expectedCount), $"Cart product count should be {expectedCount}");
        }

        public void ClickOnCartIcon()
        {
            CartIcon.Click();
        }
    }
}