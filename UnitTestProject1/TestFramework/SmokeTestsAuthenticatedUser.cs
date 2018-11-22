using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using UnitTestProject1;
using UnitTestProject1.Pages;
using Assert = NUnit.Framework.Assert;

namespace TestFramework
{
    [TestClass]
    class SmokeTestsAuthenticatedUser : TestBaseAuthenticatedUser
    {
        [Test]
        public void UserAccessMessages()
        {
            Pages.NavigationLoginPage.GoToMessages();
            Assert.IsTrue(Pages.NavigationLoginPage.IsAtMessages());
        }

        [Test]
        public void UserAccessNotifications()
        {
            Pages.NavigationLoginPage.GoToNotifications();
            Assert.IsTrue(Pages.NavigationLoginPage.IsAtNotifications());
        }

        [Test]
        public void UserLogOut()
        {
            Pages.NavigationLoginPage.UserLogout();
            Assert.IsTrue(Pages.NavigationLoginPage.IsAtMainPage());
        }

      
    }
}
