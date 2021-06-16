using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumWebdriver.TestScript.HandleDropDown
{
    [TestClass]
    public class DropDownlist
    {
       [TestMethod]
        public void TestList()
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

            // Need to write the complete flow for DropDown  selection 
            // ** below is the sample code for Drope down list selection its not completed**//
            //Console.WriteLine(CheckBoxHelper.IsCheckBoxChecked(By.Id("KmsiCheckboxField")));

            //IWebElement element = ObjectRepository.Driver.FindElement(By.Id(""));
            //SelectElement select = new SelectElement(element);
            //select.SelectByIndex(2);
            //select.SelectByText("Text");
            //select.SelectByValue("normal");
            //// For check the default value user below mehtod 

            //Console.WriteLine("Selected value:{0}", select.SelectedOption.Text);
            //IList<IWebElement>list = select.Options;
            //foreach(IWebElement ele in list)
            //{
            //    Console.WriteLine("Value:{0},Text:{1}", ele.GetAttribute("Value"), ele.Text);
            //}
            //ComboBoxHelper.SelectElement(By.Id(""), 2);
            //foreach(string str in ComboBoxHelper.GetAllItem(By.Id("")))
            //{
            //    Console.WriteLine("Text:{0}", str);
            //}


        }
    }
}
