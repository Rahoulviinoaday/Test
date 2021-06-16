using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumWebdriver.TestScript.ScreenShot
{
    [TestClass]
    public class LoginFlow
    {   
        [TestMethod]
        public void DashboardLogin()
        {
            ObjectRepository.Driver.Manage().Timeouts().PageLoad = (TimeSpan.FromSeconds(40));
            LoginFL();
           
            //GenericHelper.TakeScreenShot();
            GenericHelper.TakeScreenShot("HomeScreen.Jpeg");

        }
        public void LoginFL()
        {
            
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());

            LinkHelper.ClickLink(By.TagName("button"));

            // below code is for switch window 
            Thread.Sleep(4000);
        
            var newWindowHandle = ObjectRepository.Driver.WindowHandles[1];
            Assert.IsTrue(!string.IsNullOrEmpty(newWindowHandle));
            ObjectRepository.Driver.SwitchTo().Window(ObjectRepository.Driver.WindowHandles[1]);

            TextBoxHelper.TypeInTextBox(By.Id("i0116"), ObjectRepository.Config.GetUsername());
            LinkHelper.ClickLink(By.Id("idSIButton9"));
            TextBoxHelper.TypeInTextBox(By.Id("i0118"), ObjectRepository.Config.GetPassword());
            Thread.Sleep(3000);
            ButtonHelper.ClickButton(By.XPath("//*[@id='idSIButton9']"));
            ButtonHelper.ClickButton(By.CssSelector("#idSIButton9"));
            //ButtonHelper.ClickButton(By.XPath("//body[1]/div[1]/form[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[3]/div[2]/div[1]/div[1]/div[2]/input[1]"));
            Thread.Sleep(2000);
            var dashWindowHandle = ObjectRepository.Driver.WindowHandles[0];
            Assert.IsTrue(!string.IsNullOrEmpty(dashWindowHandle));
            ObjectRepository.Driver.SwitchTo().Window(ObjectRepository.Driver.WindowHandles[0]);
            System.Threading.Thread.Sleep(4000);
            ObjectRepository.Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }
    }
}
