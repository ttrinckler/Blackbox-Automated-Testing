using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using System.Configuration;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium.Edge;


namespace UTPFramework
{

    ///<summary></summary>
    public class Browser 
    {
        
        private static IWebDriver webDriver;
          public static void Initialize()
        {

            string StartPage = ConfigurationManager.AppSettings["testsite"];
            webDriver = new FirefoxDriver();
            webDriver.Navigate().GoToUrl(StartPage);
         
        }
        /// <summary>1- Firefox, 2-IE, 3-Chrome, 4- Edge </summary>
        public static void Initialize(int selectedBrowser)
        {
            string StartPage = ConfigurationManager.AppSettings["testsite"];
            switch (selectedBrowser)
            {
                case 1:
                    webDriver = new FirefoxDriver();
                    break;
                case 2:
                    //webDriver = new InternetExplorerDriver();
                    // I dont have it installed. 
                    webDriver = new FirefoxDriver();
                    break;
                case 3:
                    webDriver = new ChromeDriver();
                    break;
                case 4:
                    string edgePath = "Microsoft Web Driver";
                    edgePath = System.IO.Path.Combine(System.Environment.ExpandEnvironmentVariables("%ProgramFiles(x86)%"), edgePath);
                    EdgeOptions options = new EdgeOptions();
                    options.PageLoadStrategy = EdgePageLoadStrategy.Eager;
                    webDriver = new EdgeDriver(edgePath, options);
                    break;
                default:
                    webDriver = new FirefoxDriver();
                    break;
            }


            webDriver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(5));
            webDriver.Navigate().GoToUrl(StartPage);

        }
        public static IWebDriver Driver
        {
            get { return webDriver; }
        }

        public static void Close()
        {
            webDriver.Close();
        }

        public static void Home()
        {
            string StartPage = ConfigurationManager.AppSettings["testsite"];
            webDriver.Navigate().GoToUrl(StartPage);
        }

        public static void IsAt(string url)
        {
            String CurrentURL = webDriver.Url;
            Assert.AreEqual(CurrentURL, url,"The current URL does not match the provided URL");
        }


      
    }
}
