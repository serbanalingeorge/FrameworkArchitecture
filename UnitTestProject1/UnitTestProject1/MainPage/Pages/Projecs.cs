using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace UnitTestProject1.Pages
{
    public class Projecs
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='mainContent']")]
        private IWebElement pageTitle;
        public void GoTo()
        {
            Pages.TopNavigation.Projects();
        }
        public bool IsAt()
        {
            return pageTitle.Displayed;
        }
    }
}