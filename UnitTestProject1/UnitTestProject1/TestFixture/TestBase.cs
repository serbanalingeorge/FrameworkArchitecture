using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace UnitTestProject1
{
    [TestFixture]
    public class TestBase
    {
        [SetUp]
        public static void StartTest()
        {
            Browser.Setup();
            Pages.Pages.TopNavigation.AcceptPolicy();
        }

        [TearDown]
        public static void EndTest()
        {
            Browser.Close();
        }
        
        
    }
}
