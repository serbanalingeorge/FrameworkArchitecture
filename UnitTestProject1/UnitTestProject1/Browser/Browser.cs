using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace UnitTestProject1
{
    public class Browser
    {
        private static string baseUrl = "https://www.utest.com/";

        private static IWebDriver _driver;

        public static string Title => _driver.Title;

        public static IWebDriver Driver => _driver;

        public static void Setup()
        {
            /*ChromeOptions option = new ChromeOptions();
            option.AddArguments("headless");*/
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            _driver.Manage().Window.FullScreen();
            _driver.Navigate().GoToUrl(baseUrl);

        }


        public static void Close()
        {
            _driver.Quit();
        }
    }
}
