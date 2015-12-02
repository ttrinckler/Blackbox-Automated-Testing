using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTPFramework
{
     public class AboutPage
    {

        [FindsBy(How = How.LinkText, Using = "About")]
        private IWebElement aboutlink;
        [FindsBy(How = How.CssSelector, Using = "div#about-gplus a")]
        private IWebElement aboutgplus;
        [FindsBy(How = How.XPath, Using = "//div[@id='about-mission']/blockquote")]
        private  IWebElement aboutmission;
        
        public  void GoTo()
        {
            Pages.LowerNavigation.About();
        }

        public  bool aboutmissionText() {
             string str = "Google’s mission is to organize the world’s information and make it universally accessible and useful.";
            return aboutmission.Text.Equals(str);
        }

        public bool aboutgplusText()
        {
            string str = "Follow us on Google+";
            return aboutgplus.Text.Equals(str);
        }
    }

}

