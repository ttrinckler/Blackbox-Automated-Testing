using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
namespace UTPFramework
{
    public class LowerNavigationBar
    {
        
        [FindsBy(How = How.LinkText, Using = "Advertising")]
        private IWebElement AdvertisingLink;

        [FindsBy(How = How.LinkText, Using = "Business")]
        private IWebElement BusinessLink;

        [FindsBy(How = How.LinkText, Using = "About")]
        private IWebElement AboutLink;

        [FindsBy(How = How.LinkText, Using = "Privacy")]
        private IWebElement PrivacyLink;

        [FindsBy(How = How.LinkText, Using = "Terms")]
        private IWebElement TermsLink;

        [FindsBy(How = How.LinkText, Using = "Settings")]
        private IWebElement SettingsLink;

        [FindsBy(How = How.PartialLinkText, Using = "Use")]
        private IWebElement UseLink;


        public void Advertising()
        {
            AdvertisingLink.Click();
        }
        public void Business()
        {
            BusinessLink.Click();
        }
        public void About()
        {
            AboutLink.Click();
        }
        public void Privacy()
        {
            PrivacyLink.Click();
        }
        public void Terms()
        {
            TermsLink.Click();
        }
        public void Settings()
        {
            SettingsLink.Click();
        }
        public void Use()
        {
            UseLink.Click();
        }
        public void Home()
        {
            Browser.Home();
        }


    }
}
