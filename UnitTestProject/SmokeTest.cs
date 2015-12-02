using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTPFramework;
using NUnit.Framework;


namespace UnitTestProject
{
    [TestFixture]
    public class SmokeTestWithNunit : TestBase
    {
        [Test]
        public void NavigateToAboutPage()
        {
             Pages.About.GoTo();
             Browser.IsAt("https://www.google.com/intl/en/about/");
             Assert.IsTrue(Pages.About.aboutmissionText(),"About mission text is missing");
             Assert.IsTrue(Pages.About.aboutgplusText(),"About Gplus text is missing");
            

        }
            

    }
}
