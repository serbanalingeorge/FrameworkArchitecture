using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using UnitTestProject1;
using UnitTestProject1.Pages;
using Assert = NUnit.Framework.Assert;

namespace TestFramework
{
    [TestClass]
    public class SmokeTests : TestBase
    {
        [Test]
        public void SingIn()
        {
            Pages.Login.GoTo();
            Pages.Login.LoginUser();
            Assert.IsTrue(Pages.Login.IsAt());
        }

        [Test]
        public void SingInRememberMe()
        {
            Pages.Login.GoTo();
            Pages.Login.LoginUserRememberMe();
            Assert.IsTrue(Pages.Login.IsAt());
        }

        [Test]
        public void GoToArticlesPage()
        {
            Pages.Articles.GoTo();
            Assert.IsTrue(Pages.Articles.IsAt());
        }

        [Test]
        public void GoToTrainingPage()
        {
            Pages.Training.GoTo();
            Assert.IsTrue(Pages.Training.IsAt());
        }

        [Test]
        public void GoToForumsPage()
        {
            Pages.Forums.GoTo();
            Assert.IsTrue(Pages.Forums.IsAt());

        }

        [Test]
        public void GoToToolsPage()
        {
            Pages.Tools.GoTo();
            Assert.IsTrue(Pages.Tools.IsAt());

        }

        [Test]
        public void GoToProjectsPage()
        {
            Pages.Projecs.GoTo();
            Assert.IsTrue(Pages.Projecs.IsAt());
        }
    }
}
