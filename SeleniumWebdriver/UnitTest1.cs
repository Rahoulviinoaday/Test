using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using SeleniumWebdriver.Configuration;

namespace SeleniumWebdriver
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Interfaces.IConfig config = new AppConfigReader();
            //Console.WriteLine("Browser  : {0}", config.GetBrowser());
            //Console.WriteLine("Username : {0}", config.GetUsername());
            //Console.WriteLine("Password : {0}", config.GetPassword());
            Console.WriteLine("Test");
            





            //Console.WriteLine(ConfigurationManager.AppSettings.Get("Browser"));
            //Console.WriteLine(ConfigurationManager.AppSettings.Get("Username"));
            //Console.WriteLine(ConfigurationManager.AppSettings.Get("Password"));
            //Console.WriteLine((int)BrowserType.Chrome);
            //Console.WriteLine((int)BrowserType.FireFox);
        }
        /* IWebDriver driver = new ChromeDriver();
                    driver.Navigate().GoToUrl("https://aps.stg.fs.co.uk/"); // this will open the web page
                    //driver.Close(); //this will close the browser session
                    //driver.Quit(); // this will stop the webdriver*/
    }
}
