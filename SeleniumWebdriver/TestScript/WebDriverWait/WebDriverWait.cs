using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumWebdriver.Settings;
using SeleniumWebdriver.ComponentHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Threading;

namespace OpenQA.Selenium.Support.UI
{
    [TestClass]
    public class WebDriverWait1
    {
   
        [TestMethod]
        public void TestWait()
        {
            //Belwo code is for the Pageload Time out wait method 
            //ObjectRepository.Driver.Manage().Timeouts().PageLoad =(TimeSpan.FromSeconds(40));
            // Below code is for the Implicit wait method 
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait=(TimeSpan.FromSeconds(4));
            NavigationHelper.NavigateToUrl("https://aps.stg.fs.co.uk/");

        }
        [TestMethod]
        public void TestDynamicWait()
        {
            NavigationHelper.NavigateToUrl("https://aps.stg.fs.co.uk/");
            ObjectRepository.Driver.Manage().Timeouts().PageLoad=TimeSpan.FromSeconds(30);
            WebDriverWait wait = new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromSeconds(50));
            wait.PollingInterval = TimeSpan.FromMilliseconds(250);
            wait.Timeout = TimeSpan.FromSeconds(40);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            //Console.WriteLine(wait.Until(waitforTitle()));
           IWebElement element= wait.Until(waitforElememt());
            element.Click();

            // GenericHelper.WaitForWebElement(By.CssSelector(""), TimeSpan.FromSeconds(50));
            // IWebElement ele= GenericHelper.WaitForWebElementInPage(By.CssSelector(""), TimeSpan.FromSeconds(50));



            Thread.Sleep(4000);
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            var newWindowHandle = ObjectRepository.Driver.WindowHandles[1];
            Assert.IsTrue(!string.IsNullOrEmpty(newWindowHandle));
            ObjectRepository.Driver.SwitchTo().Window(ObjectRepository.Driver.WindowHandles[1]);

            TextBoxHelper.TypeInTextBox(By.Id("i0116"), ObjectRepository.Config.GetUsername());
            LinkHelper.ClickLink(By.Id("idSIButton9"));
            TextBoxHelper.TypeInTextBox(By.Id("i0118"), ObjectRepository.Config.GetPassword());
            Thread.Sleep(2000);
            ButtonHelper.ClickButton(By.XPath("//*[@id='idSIButton9']"));
            ButtonHelper.ClickButton(By.CssSelector("#idSIButton9"));
            //ButtonHelper.ClickButton(By.XPath("//body[1]/div[1]/form[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[3]/div[2]/div[1]/div[1]/div[2]/input[1]"));
            ObjectRepository.Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            //ButtonHelper.ClickButton(By.XPath("//*[@id='root']/div/div/div/div/ul/li[3]/a"));
            //ObjectRepository.Driver.Manage().Timeouts().PageLoad=TimeSpan.FromSeconds(30);
            //GenericHelper.TakeScreenShot("Helpscreen.jpeg");

        }
        [TestMethod]
        [Obsolete]
        public void TextExpCondition() 
        
        {
            NavigationHelper.NavigateToUrl("https://aps.stg.fs.co.uk/");
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            WebDriverWait wait = new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromSeconds(50));
            wait.PollingInterval = TimeSpan.FromMilliseconds(250);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            Console.WriteLine("Title:{0}",wait.Until(ExpectedConditions.TitleContains("Online")));
            //wait.Until(ExpectedConditions.ElementExists(By.XPath("//body/div[1]/div[1]/div[3]/div[2]/form[1]"))).SendKeys("HTML");
           // ButtonHelper.ClickButton(By.XPath("//*[@type='submit']"));


        }

        private Func<IWebDriver,bool> waitfortheloginbutton()
        {
            return ((x) =>
            {
                Console.WriteLine("Waiting for Login Button");
                return x.FindElements(By.XPath("//button[contains(text(),'Login')]")).Count == 1;
            });
        }

        private Func<IWebDriver,IWebElement> waitforElememt()
        {
            return ((x) =>
             {
                 Console.WriteLine("Waiting for Element");
                 if (x.FindElements(By.XPath("//button[contains(text(),'Login')]")).Count == 1)
                return x.FindElement(By.XPath("//button[contains(text(),'Login')]"));
                return null;

             });


        }
    }
}
