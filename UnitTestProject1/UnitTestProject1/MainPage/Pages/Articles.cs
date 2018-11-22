namespace UnitTestProject1.Pages
{
    public class Articles
    {
        public void GoTo()
        {
            Pages.TopNavigation.Articles();
        }
        public bool IsAt()
        {
            return Browser.Title.Contains("Software");
        }
    }
}