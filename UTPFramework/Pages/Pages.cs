using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace UTPFramework
{
    public static class Pages
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Browser.Driver, page);
            return page;
        }
        public static AdvertisingPage Advertising
        {
            get
            {
                return GetPage<AdvertisingPage>();
            }
        }
        public static BusinessPage Business
        {
            get
            {
                return GetPage<BusinessPage>();
            }
        }

        public static AboutPage About
        {
            get
            {
                return GetPage<AboutPage>();
            }
        }

        public static PrivacyPage Privacy
        {
            get
            {
                return GetPage<PrivacyPage>();
            }
        }

        public static TermsPage Terms
        {
            get
            {
                return GetPage<TermsPage>();
            }
        }
        public static SettingsPage Settings
        {
            get
            {
                return GetPage<SettingsPage>();
            }
        }
        public static UsePage Use
        {
            get
            {
                return GetPage<UsePage>();
            }
        }

        public static HomePage Home
        {
            get
            {
                return GetPage<HomePage>();
            }
        }
        public static LowerNavigationBar LowerNavigation
        {
            get
            {
                return GetPage<LowerNavigationBar>();
            }
        }
    }
}
