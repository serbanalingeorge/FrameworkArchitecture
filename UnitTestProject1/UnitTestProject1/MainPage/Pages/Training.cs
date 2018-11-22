using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace UnitTestProject1.Pages
{
    public class Training
    {
        [FindsBy(How = How.XPath, Using = "/html/body/span/div[3]/div[2]/div[2]/div[1]/div/div[2]/div/ul/li[1]/a")]
        private IWebElement courseTrack;

        [FindsBy(How = How.XPath, Using = "/html/body/span/div[3]/div[2]/div[2]/div[1]/div/div[2]/div/ul/li[2]/a")]
        private IWebElement newest;

        [FindsBy(How = How.XPath, Using = "/html/body/span/div[3]/div[2]/div[2]/div[1]/div/div[2]/div/ul/li[3]/a")]
        private IWebElement mostPopularCourses;

        public void GoTo()
        {
            Pages.TopNavigation.Training();
        }
        public bool IsAt()
        {
            return Browser.Title.Contains("Software");
        }

        public void CourseTracksTabGoTo()
        {
            courseTrack.Click();
        }

        public void NewestTabGoTo()
        {
            newest.Click();
        }

        public void MostPopularCoursesTabGoTo()
        {
            mostPopularCourses.Click();
        }
    }
}