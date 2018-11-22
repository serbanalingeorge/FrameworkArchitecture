using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace UnitTestProject1
{
    [TestFixture]
    public class TestBaseAuthenticatedUser : TestBase
    {
        [SetUp]
        public static void StartTest()
        {
            Pages.Pages.Login.GoTo();
            Pages.Pages.Login.LoginUser();
        }

    }
}
