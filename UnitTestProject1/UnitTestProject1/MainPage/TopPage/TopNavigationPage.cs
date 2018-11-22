using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace UnitTestProject1.Pages
{
    public class TopNavigationPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@class='ut-hamburger']")]
        private IWebElement accessMenu;

        [FindsBy(How = How.XPath, Using = "//*[@ui-sref='article']")]
        private IWebElement articles;

        [FindsBy(How = How.XPath, Using = "//*[@ui-sref='course({track: 1})']")]
        private IWebElement training;

        [FindsBy(How = How.XPath, Using = "//*[@href='/forums?tab=recent-replies&topic_page=1']")]
        private IWebElement forums;

        [FindsBy(How = How.XPath, Using = "//*[@href='/tools']")]
        private IWebElement tools;

        [FindsBy(How = How.XPath, Using = "//*[@ui-sref='project']")]
        private IWebElement projects;

        [FindsBy(How = How.XPath, Using = "//*[@target='_self']")]
        private IWebElement loginUser;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"nav-bar-container\"]")]
        private IWebElement registerUser;

        [FindsBy(How = How.XPath, Using = "//*[@class='btn btn-blue']")]
        private IWebElement acceptPolicyButton;

        public void AccessMenu()
        {
            accessMenu.Click();
        }

        public void Articles()
        {
            articles.Click();
        }

        public void Training()
        {
            training.Click();
        }

        public void Forums()
        {
            forums.Click();
        }

        public void Tools()
        {
            tools.Click();
        }

        public void Projects()
        {
            projects.Click();
        }

        public void Login()
        {
            loginUser.Click();
        }

        public void AcceptPolicy()
        {
            acceptPolicyButton.Click();
        }

        public void RegisterUser()
        {
            registerUser.Click();
        }
    }
}
