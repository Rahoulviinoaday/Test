using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using SeleniumWebdriver.Settings;


namespace SeleniumWebdriver.ComponentHelper
{
   public class GenericHelper
    {
        private static TimeSpan PollingInterval;

        // This method only handle if the locator is unique element is present  
        public static bool IsElementPresent(By Locator)
        {
            try
            {
                return ObjectRepository.Driver.FindElements(Locator).Count == 1;
            }
            catch
            {
                return false;
            }
           
        }
        public static IWebElement GetElement(By Locator)
        {
            if (IsElementPresent(Locator))
                return ObjectRepository.Driver.FindElement(Locator);
            else
                throw new NoSuchElementException("Element Not Found:" + Locator.ToString());
       
        }
        public static void TakeScreenShot(string filename ="HomeScreen")
        {
            Screenshot screen = ObjectRepository.Driver.TakeScreenshot();
            if(filename.Equals("HomeScreen"))
            {
                filename = filename + DateTime.UtcNow.ToString("yyyy-MM-dd-mm-ss") + ".jpeg";
                screen.SaveAsFile(filename,ScreenshotImageFormat.Jpeg);
               
                return;
            }
            screen.SaveAsFile(filename, ScreenshotImageFormat.Jpeg);
        }
        public static bool WaitForWebElement(By locator, TimeSpan timeout)
        {
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            WebDriverWait wait = new WebDriverWait(ObjectRepository.Driver, timeout);
            wait.PollingInterval = TimeSpan.FromMilliseconds(500);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            bool flag = wait.Until(WaitForWebElementFunc(locator));
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(ObjectRepository.Config.GetElementLoadTimeOut());
            return flag;
        }
            public static IWebElement WaitForWebElementInPage(By locator, TimeSpan timeout)
            {
                ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
                WebDriverWait wait = new WebDriverWait(ObjectRepository.Driver, timeout);
                wait.PollingInterval = TimeSpan.FromMilliseconds(500);
                wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
                IWebElement flag = wait.Until(WaitForWebElementFuncInPageFunc(locator));
                ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(ObjectRepository.Config.GetElementLoadTimeOut());
                return flag;
            }

            private static Func<IWebDriver,IWebElement> WaitForWebElementFuncInPageFunc(By locator)
            {

                return ((x) =>
                {
                    if (x.FindElements(locator).Count == 1)
                        return x.FindElement(locator);
                    
                        return null;
                });
            }
        private static Func<IWebDriver, bool> WaitForWebElementFunc(By locator)
        {

            return ((x) =>
            {
                if (x.FindElements(locator).Count == 1)
                    return true;
                else
                    return false;
            });
        }
            public static WebDriverWait GetWebDriverWait(TimeSpan timeout)
            {
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            WebDriverWait wait = new WebDriverWait(ObjectRepository.Driver, timeout);
            {
                PollingInterval = TimeSpan.FromMilliseconds(500);
            };
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            return wait;
        }
        }
    }

