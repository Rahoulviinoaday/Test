using OpenQA.Selenium;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumWebdriver.PageObject
{
    public class HomePage
    {
        #region WebElement
        private By createNewworkspace = By.XPath("//*[@id='root']/div/div/main/div/div/div/div[1]/div[1]/div[1]");
        private By Uploadfile = By.Id("talos-dropzone");
        private By Accountlink = By.LinkText("Account");
        private By helplink = By.LinkText("Help");
        private By Settingslink = By.LinkText("Settings");
        private By Aboutlink = By.LinkText("About");
        private By Logoutlink = By.LinkText("Logout");
        #endregion

        #region Actions
        public void NewWorkspace(string text)
        {
            ObjectRepository.Driver.FindElement(createNewworkspace).Click();

        }

        #endregion
        #region Navigation
        public void NavigationToLink()
        
        {

            ObjectRepository.Driver.FindElement(Accountlink).Click();
            Thread.Sleep(2000);
            GenericHelper.TakeScreenShot("C:/Automation/Screenshot/Account.Jpeg");
            ObjectRepository.Driver.FindElement(helplink).Click();
            Thread.Sleep(2000);
            GenericHelper.TakeScreenShot("C:/Automation/Screenshot/Help.Jpeg");
            ObjectRepository.Driver.FindElement(Settingslink).Click();
            Thread.Sleep(2000);
            GenericHelper.TakeScreenShot("C:/Automation/Screenshot/Setting.Jpeg");
            ObjectRepository.Driver.FindElement(Aboutlink).Click();
            Thread.Sleep(2000);
            GenericHelper.TakeScreenShot("C:/Automation/Screenshot/About.Jpeg");
        }
        #endregion

    }
}
