using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;
using System.Threading;

namespace SeleniumWebdriver.TestScript.RedioButton
{
    [TestClass]
   public class HandleRedioButton

    {
        [TestMethod]
        public void TestRedio()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());

            LinkHelper.ClickLink(By.TagName("button"));

            // below code is for switch window 
            Thread.Sleep(4000);
            var newWindowHandle = ObjectRepository.Driver.WindowHandles[1];
            Assert.IsTrue(!string.IsNullOrEmpty(newWindowHandle));
            ObjectRepository.Driver.SwitchTo().Window(ObjectRepository.Driver.WindowHandles[1]);

            TextBoxHelper.TypeInTextBox(By.Id("i0116"), ObjectRepository.Config.GetUsername());
            TextBoxHelper.ClearTextBox(By.Id("i0116"));

            // Need to write the complete flow for redio button selection 
            // ** below is the sample code for checkbox selection its not completed**//
            //Console.WriteLine(CheckBoxHelper.IsCheckBoxChecked(By.Id("KmsiCheckboxField")));
           // Console.WriteLine("Selected:{0}", RedioButtonHelper.IsRedioButtonChecked(By.Id("PAss the locator ")));


        }
    }
}
