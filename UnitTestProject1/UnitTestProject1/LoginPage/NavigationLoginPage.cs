using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace UnitTestProject1.Pages
{
    public class NavigationLoginPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@href='/activity']")]
        private IWebElement notifications;

        [FindsBy(How = How.XPath, Using = "//*[@href='/messages']")]
        private IWebElement messages;

        [FindsBy(How = How.XPath, Using = "//*[@href='/logout']")]
        private IWebElement logout;

        [FindsBy(How = How.Id, Using = "mainContentActivity")]
        private IWebElement displayTextInsideNotifications;

        [FindsBy(How = How.XPath, Using = "//*[@ui-sref='signup.personal']")]
        private IWebElement joinTestButton;

        public void GoToMessages()
        {
            messages.Click();
        }

        public void GoToNotifications()
        {
            notifications.Click();
        }

        public bool IsAtMessages()
        {
            return Browser.Title.Contains("Messages");
        }

        public bool IsAtNotifications()
        {
            return displayTextInsideNotifications.Displayed;
        }

        public void UserLogout()
        {
            logout.Click();
        }

        public bool IsAtMainPage()
        {
            return joinTestButton.Displayed;
        }

    }
}
