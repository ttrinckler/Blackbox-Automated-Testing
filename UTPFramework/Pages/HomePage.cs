using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace UTPFramework
{
    public class HomePage
    {

        [FindsBy(How = How.Name, Using = "q")]
        private IWebElement SearchBox;
        [FindsBy(How = How.Name, Using = "btnK")]
        private IWebElement SearchBtn;
        [FindsBy(How = How.Name, Using = "btnI")]
        private IWebElement LuckyBtn;
        [FindsBy(How = How.Id, Using = "gsri_a")]
        private IWebElement VoiceBtn;
        public void GoTo()
        {
            Pages.LowerNavigation.Home();
        }

        public void Search()
        {
            //string rnd = RandomStringGenerator.Generate();
            string rnd = "THREE LITTLE BIRDS";
            SearchBox.SendKeys(rnd);
        }
        public void Search(string str)
        {
            SearchBox.SendKeys(str);
            SearchBox.Submit();
        }
    }
}
