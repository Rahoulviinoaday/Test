using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumWebdriver.TestScript.ScreenShot;
using SeleniumWebdriver.Settings;
using SeleniumWebdriver.ComponentHelper;
using OpenQA.Selenium;

namespace SeleniumWebdriver.TestScript.BrowserActions
{
    [TestClass]
    public class TestBrowseractions
    {
        [TestMethod]
        public void TestActions()
        {
            LoginFlow login = new LoginFlow();
            login.LoginFL();
            ObjectRepository.Driver.Manage().Window.Minimize();
            //ObjectRepository.Driver.Manage().Window.Maximize(); //Added this method in Base class so always this method will execute when browser launch 
            ButtonHelper.ClickButton(By.LinkText("Account"));
            //ObjectRepository.Driver.Navigate().Back();
            BrowserHelper.GoBack();

            GenericHelper.TakeScreenShot("HomePage.png");
            //ObjectRepository.Driver.Navigate().Forward();
            BrowserHelper.Forward();
           Console.WriteLine(ObjectRepository.Driver.Title.Contains("Auto"));
            GenericHelper.TakeScreenShot("Account.jpeg");
            ButtonHelper.ClickButton(By.XPath("//header/a[1]/img[1]"));
            BrowserHelper.RefreshPage();
            Console.Write("\nTest Executed \t Successfully Navigate to Home screen ");



        }
    }
}
