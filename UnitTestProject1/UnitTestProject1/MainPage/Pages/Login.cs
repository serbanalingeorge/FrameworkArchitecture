using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace UnitTestProject1.Pages
{
    public class Login
    {
        private string _email = "serbanalingeorge@yahoo.com";
        private string _password = "Eustiuasta23";

        [FindsBy(How = How.Id, Using = "username")]
        private IWebElement emailAddressTextField;

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement passwordTextField;

        [FindsBy(How = How.Id, Using = "rememberMe")]
        private IWebElement rememberMeButton;

        [FindsBy(How = How.Id, Using = "kc-login")]
        private IWebElement loginButton;

        [FindsBy(How = How.ClassName, Using = "home-welcome")]
        private IWebElement welcomeUserMessage;

        public void GoTo()
        {
            Pages.TopNavigation.Login();
        }
        public bool IsAt()
        {
            return welcomeUserMessage.Displayed;
        }

        public void InputYourEmail(string email)
        {
            emailAddressTextField.SendKeys(email);
        }

        public void InputYourPassword(string password)
        {
            passwordTextField.SendKeys(password);
        }

        public void ClickLogin()
        {
            loginButton.Click();
        }

        public void ClickRememberMe()
        {
            rememberMeButton.Click();
        }

        public void LoginUser()
        {
            InputYourEmail(_email);
            InputYourPassword(_password);
            ClickLogin();
        }
        public void LoginUserRememberMe()
        {
            InputYourEmail(_email);
            InputYourPassword(_password);
            ClickRememberMe();
            ClickLogin();
        }
    }
}