using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;
using SeleniumWebdriver.TestScript.ScreenShot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumWebdriver.TestScript.MultipleBrowserWindow
{
    [TestClass]
    public class TestMultipleBrowserWindow
    {
        [TestMethod]
        public void MultipleBrowserWindow()
        {
            LoginFlow login = new LoginFlow();
            login.LoginFL();
            ButtonHelper.ClickButton(By.LinkText("Account"));
            GenericHelper.TakeScreenShot("C:/Automation/Screenshot/AccountPage.jpeg");
            BrowserHelper.GoBack();
            ButtonHelper.ClickButton(By.XPath("//*[@id='root']/div/div/div/div/ul/li[3]/a"));
            Thread.Sleep(3000);
            GenericHelper.TakeScreenShot("C:/Automation/Screenshot/HelpScreen.jpeg");
            ButtonHelper.ClickButton(By.XPath("//*[@id='headingTwo']/h5/button"));
            GenericHelper.TakeScreenShot("C:/Automation/Screenshot/Question2.jpeg");
            ButtonHelper.ClickButton(By.XPath("//*[@id='root']/div/div/div/div/ul/li[4]/a"));
            Thread.Sleep(2000);
            GenericHelper.TakeScreenShot("C:/Automation/Screenshot/Setting.Jpeg");
            ButtonHelper.ClickButton(By.LinkText("About"));
            GenericHelper.TakeScreenShot("AboutPage.jpeg");

        }

        [TestMethod]
        public void TestFrame()
        {
            LoginFlow login = new LoginFlow();
            login.LoginFL();
            //Belwo code is for the Switch between frame by locating frame ID in webelement, we can use frame index number for find the  correct frame  
            ObjectRepository.Driver.SwitchTo().Frame(ObjectRepository.Driver.FindElement(By.Id("pass the frame id here")));
            ButtonHelper.ClickButton(By.Id("Passthe Button ld/xpath"));
            // if You wan to come back on the out side the frame use below method to come out and continue execution 
            ObjectRepository.Driver.SwitchTo().DefaultContent();

        }
    }
}
