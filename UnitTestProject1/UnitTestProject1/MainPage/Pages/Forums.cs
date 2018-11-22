namespace UnitTestProject1.Pages
{
    public class Forums
    {
        public void GoTo()
        {
            Pages.TopNavigation.Forums();
        }
        public bool IsAt()
        {
            return Browser.Title.Contains("Software");
        }
    }
}