using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;


namespace E_Commerce_End_to_End_Automation_Framework.Framework.Pages
{
    internal class LogInPage : Form
    {
        private const string PageName = "Log In";

        private ITextBox UsernameField => ElementFactory.GetTextBox(By.Id("user-name"), "Username field");
        private ITextBox PasswordField => ElementFactory.GetTextBox(By.Id("password"), "Password field");
        private IButton LogInButton => ElementFactory.GetButton(By.Id("login-button"), "Log In button");
        private ITextBox LockedUserLoginError => ElementFactory.GetTextBox(By.XPath("//h3[@data-test='error']"), "Locked user login error message");
        public LogInPage() : base(By.XPath(string.Format(LocatorConstants.PreciseTextLocator, PageName)), PageName)
        {
        }

        public void EnterValidUsername(string username)
        {
            UsernameField.ClearAndType(username);
        }

        public void EnterValidPassword(string password)
        {
            PasswordField.ClearAndType(password);
        }

        public void ClickLogInButton()
        {
            LogInButton.Click();
        }

        public string GetLockedUserLoginErrorMessage()
        {
            return LockedUserLoginError.Text;
        }
    }
}