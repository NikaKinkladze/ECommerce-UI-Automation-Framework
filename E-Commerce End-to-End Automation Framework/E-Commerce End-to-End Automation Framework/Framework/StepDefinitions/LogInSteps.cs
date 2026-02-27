using E_Commerce_End_to_End_Automation_Framework.Framework.Pages;
using TechTalk.SpecFlow;

namespace E_Commerce_End_to_End_Automation_Framework.Framework.StepDefinitions
{
    [Binding]
    internal class LogInSteps
    {
        LogInPage logInPage = new();
        private User user;

        private void LoadValidUser()
        {
            user = TestDataHelper.GetUser("validUser");
        }
        private void lockedUser()
        {
            user = TestDataHelper.GetUser("lockedUser");
        }
        private void InvalidUser()
        {
            user = TestDataHelper.GetUser("invalidUser");
        }

        [Given(@"I input username")]
        public void EnterValidUsernameFor()
        {
            LoadValidUser();
            logInPage.EnterValidUsername(user.Username);
        }

        [Given(@"I input password")]
        public void EnterValidPasswordFor()
        {
            LoadValidUser();
            logInPage.EnterValidPassword(user.Password);
        }

        [Given(@"I click log in button")]
        [When(@"I click log in button")]
        public void ClickLogInButton()
        {
            logInPage.ClickLogInButton();
        }

        [Given(@"I input locked user username")]
        public void LockedUserUsrnameInput()
        {
            lockedUser();
            logInPage.EnterValidUsername(user.Username);
        }

        [Given(@"I input locked user password")]
        public void LockedUserPasswordInput()
        {
            lockedUser();
            logInPage.EnterValidPassword(user.Password);
        }

        [Then(@"I verify locked user error message")]
        public void VerifyLockedUserErrorMessage()
        {
            Assert.That(logInPage.GetLockedUserLoginErrorMessage(), Is.EqualTo("Epic sadface: Sorry, this user has been locked out."));
        }

        [Given(@"I input invalid user usename")]
        public void InputInvalidUserUsename()
        {
            InvalidUser();
            logInPage.EnterValidUsername(user.Username);
        }

        [Given(@"I input invalid user password")]
        public void InputInvalidUserPassword()
        {
            InvalidUser();
            logInPage.EnterValidPassword(user.Password);
        }

        [Then(@"I verify invalid user error message")]
        public void VerifyInvalidUserErrorMessage()
        {
            Assert.That(logInPage.GetLockedUserLoginErrorMessage(), Is.EqualTo("Epic sadface: Username and password do not match any user in this service"));
        }

        [Then(@"I verify empty user error message")]
        public void VerifyEmptyUserErrorMessage()
        {
            Assert.That(logInPage.GetLockedUserLoginErrorMessage(), Is.EqualTo("Epic sadface: Username is required"));
        }

    }
}