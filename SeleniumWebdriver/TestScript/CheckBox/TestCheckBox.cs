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
// This is sample code for check box selection it's not complete for run 
namespace SeleniumWebdriver.TestScript.CheckBox
{
    [TestClass]
    public class TestCheckBox
    {
        [TestMethod]
        public void TestBox()

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

            // Need to write the complete flow for check box selection 
            // ** below is the sample code for checkbox selection its not completed**//
            //Console.WriteLine(CheckBoxHelper.IsCheckBoxChecked(By.Id("KmsiCheckboxField")));
            

        }
    }
}
