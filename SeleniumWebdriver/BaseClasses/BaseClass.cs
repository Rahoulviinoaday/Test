
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Configuration;
using SeleniumWebdriver.CustomException;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.BaseClasses
{
    [TestClass]
   public class BaseClass
    {
        private static ChromeOptions GetChromeOptions()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("start-maximized");
            
            return option;
        }

        private static FirefoxProfile GetFirefoxoptions()
        {
            FirefoxProfile profile = new FirefoxProfile();
            FirefoxProfileManager manager = new FirefoxProfileManager();
            profile = manager.GetProfile("default");
            return profile;
        }
        private static InternetExplorerOptions GetIEOptions()
        {
            InternetExplorerOptions options = new InternetExplorerOptions();
            options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
            options.EnsureCleanSession = true;
            return options;

        }
        private static IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver(GetChromeOptions());
            return driver;
        }
        private static IWebDriver GetFireFoxDriver()
        {
           IWebDriver driver = new FirefoxDriver();
            return driver;
        }
        private static IWebDriver GetIEDriver()
        {
            IWebDriver driver = new InternetExplorerDriver(GetIEOptions());
            return driver;
        }
        //private static PhantomJSDriver GetPhantomJSDriver()
        //{
        //    GetPhantomJSDriver driver = new PhantomJSDriver();
        //    return driver;

        //}
        [AssemblyInitialize]
        public static void InitWebdriver(TestContext tc)
        {
            ObjectRepository.Config = new AppConfigReader();

            switch (ObjectRepository.Config.GetBrowser())
            {
                case BrowserType.Chrome:
                    ObjectRepository.Driver = GetChromeDriver();
                    break;

                case BrowserType.FireFox:
                    ObjectRepository.Driver = GetFireFoxDriver();
                    break;

                case BrowserType.IExplorer:
                    ObjectRepository.Driver = GetIEDriver();
                    break;
                //case BrowserType.PhantomJs:
                //    ObjectRepository.Driver = GetPhantomJsDriver();
                //    break;

                default:
                    throw new NoSutiableDriverFound("Driver Not Found :" + ObjectRepository.Config.GetBrowser().ToString());
            }
                    NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
                    ObjectRepository.Driver.Manage().Cookies.DeleteAllCookies();
                    ObjectRepository.Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(ObjectRepository.Config.GetPageLoadTimeOut());
                    ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(ObjectRepository.Config.GetElementLoadTimeOut());
                     BrowserHelper.BrowserMaximize();
                    ObjectRepository.Driver.Manage().Cookies.DeleteAllCookies();
           
        }
        [AssemblyCleanup]
        public static void TearDown()
        {
            if (ObjectRepository.Config != null)
            {
               ObjectRepository.Driver.Close();
               ObjectRepository.Driver.Quit();
            }


        }

    }
}
