namespace UnitTestProject1.Pages
{
    public class Tools
    {
        public void GoTo()
        {
            Pages.TopNavigation.Tools();
        }
        public bool IsAt()
        {
            return Browser.Title.Contains("Software");
        }
    }
}