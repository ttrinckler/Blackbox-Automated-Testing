using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTPFramework
{
    [TestFixture]
    public class TestBase
    {
        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {
            Browser.Initialize();
        }

        [SetUp]
        public static void SetUp()
        {

        }

        [TearDown]
        public static void TearDown()
        {

        }

        [TestFixtureTearDown]
        public static void TestFixtureTearDown()
        {
            Browser.Close();

            if (TestContext.CurrentContext.Result.Status == TestStatus.Failed)
            {
                Console.WriteLine(TestContext.CurrentContext.Test.FullName);
                Console.WriteLine(TestContext.CurrentContext.Result.Status);
            }

        }
    }
}
