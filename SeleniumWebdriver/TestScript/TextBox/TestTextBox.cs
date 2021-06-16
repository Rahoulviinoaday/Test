using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumWebdriver.TestScript.TextBox
{
    [TestClass]
    public class TestTextBox
    {
        [TestMethod]
        public void TextBox ()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            
            LinkHelper.ClickLink(By.TagName("button"));

            // below code is for switch window 
            Thread.Sleep(4000);
            var newWindowHandle = ObjectRepository.Driver.WindowHandles[1];
            Assert.IsTrue(!string.IsNullOrEmpty(newWindowHandle));
            ObjectRepository.Driver.SwitchTo().Window(ObjectRepository.Driver.WindowHandles[1]);
            //IWebElement ele = ObjectRepository.Driver.FindElement(By.Id("i0116"));
            //ele.SendKeys(ObjectRepository.Config.GetUsername());
            //ele.Clear();
            TextBoxHelper.TypeInTextBox(By.Id("i0116"), ObjectRepository.Config.GetUsername());
            TextBoxHelper.ClearTextBox(By.Id("i0116"));

        }
    }
}
