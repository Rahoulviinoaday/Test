using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.TestScript.Button
{
   [TestClass]
    public class HandleButton
    {
        [TestMethod]
        public void TestButton()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            LinkHelper.ClickLink(By.TagName("button"));
            Thread.Sleep(4000);
            var newWindowHandle = ObjectRepository.Driver.WindowHandles[1];
            Assert.IsTrue(!string.IsNullOrEmpty(newWindowHandle));
            ObjectRepository.Driver.SwitchTo().Window(ObjectRepository.Driver.WindowHandles[1]);
            
            TextBoxHelper.TypeInTextBox(By.Id("i0116"), ObjectRepository.Config.GetUsername());
            IWebElement element = ObjectRepository.Driver.FindElement(By.Id("idSIButton9"));
            element.Click();
            Console.WriteLine("Enabled:{0}", ButtonHelper.IsButtonEnabled(By.Id("idSIButton9")));
            Console.WriteLine("Button Text:{0}", ButtonHelper.GetButtonText(By.Id("idSIButton9")));
            ButtonHelper.ClickButton(By.Id("idSIButton9"));

        }
    }
}
