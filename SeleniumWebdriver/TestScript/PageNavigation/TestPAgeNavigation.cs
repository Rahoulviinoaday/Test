using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.TestScript.PageNavigation
{
    [TestClass]
    public class TestPAgeNavigation
    {
        [TestMethod]
        public void OpenPage()
        {
            //INavigation page= ObjectRepository.Driver.Navigate();
            //page.GoToUrl(ObjectRepository.Config.GetWebsite());
            //OR we Can user below Method to navigate to browser 
            // ObjectRepository.Driver.Navigate().GoToUrl(ObjectRepository.Config.GetWebsite());
           //OR we can call method as below 
           //* Below method user from Naivagation Helpwe class*
           
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            // Below method can execute along with window helper  
            //Console.WriteLine("Title of Page:{0}",ObjectRepository.Driver.Title);
            // Or we can use below method by using window helper class which is use for window action
            Console.WriteLine("Title of Page:{0}", WindowHelper.GetTitle());

        }
    }
}
