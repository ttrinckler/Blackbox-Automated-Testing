using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using UTPFramework;

namespace UnitTestProject
{
    [TestClass]
    public class TestWithVSTestTools
    {
        [TestInitialize]
        public void Initialize()
        {
            Browser.Initialize(3);
        }
        //[TestMethod]
        //public void AbleToSearch()
        //{
        //    Pages.Home.Search("perritos");
        //}

        [TestCleanup]
        public void Cleanup()
        {
            Browser.Close();
        }

    }
}
