using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;

namespace UnitTestProject1.Pages
{
    public static class Pages
    {
        public static Articles Articles => GetPage<Articles>();
        public static Training Training => GetPage<Training>();
        public static Forums Forums => GetPage<Forums>();
        public static Tools Tools => GetPage<Tools>();
        public static Projecs Projecs => GetPage<Projecs>();
        public static Login Login => GetPage<Login>();
        public static TopNavigationPage TopNavigation => GetPage<TopNavigationPage>();
        public static NavigationLoginPage NavigationLoginPage => GetPage<NavigationLoginPage>();
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Browser.Driver, page);
            return page;
        }
    }
}
