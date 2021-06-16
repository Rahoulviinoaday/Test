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

namespace SeleniumWebdriver.PageObject
{
    public class LoginPage
    {
        #region WebElement
        private By LoginBtton = By.XPath("//button[contains(text(),'Login')]");
        private By SigninTextBox = By.XPath("//*[@id='i0116']");
        private By signinNext = By.Id("idSIButton9");
        private By EnterPasswordTextBox = By.XPath("//*[@name='passwd']");
        private By Forgotpassword = By.XPath("//a[@id='idA_PWD_ForgotPassword']");
        private By Singinbutton = By.XPath("//*[@type='submit']");
        private By Staysinginbtn = By.XPath("//*[@id='idSIButton9']"); // this is stay signed in "Yes" Button
        private By Accountlink = By.LinkText("Account");
        #endregion

        #region Actions
        public void Login(string username,string password)
        {
            ObjectRepository.Driver.FindElement(LoginBtton).Click();
            Thread.Sleep(3000);
            var newWindowHandle = ObjectRepository.Driver.WindowHandles[1];
            Assert.IsTrue(!string.IsNullOrEmpty(newWindowHandle));
            ObjectRepository.Driver.SwitchTo().Window(ObjectRepository.Driver.WindowHandles[1]);
            ObjectRepository.Driver.FindElement(SigninTextBox).SendKeys(username);
            ObjectRepository.Driver.FindElement(signinNext).Click();
            ObjectRepository.Driver.FindElement(EnterPasswordTextBox).SendKeys(password);
            Thread.Sleep(3000);
            ObjectRepository.Driver.FindElement(Singinbutton).Click();
            ObjectRepository.Driver.FindElement(Staysinginbtn).Click();
            Thread.Sleep(2000);
            var dashWindowHandle = ObjectRepository.Driver.WindowHandles[0];
            Assert.IsTrue(!string.IsNullOrEmpty(dashWindowHandle));
            ObjectRepository.Driver.SwitchTo().Window(ObjectRepository.Driver.WindowHandles[0]);
            System.Threading.Thread.Sleep(4000);
            ObjectRepository.Driver.Manage().Window.Maximize();
            Thread.Sleep(5000);

        }
        #endregion

        #region Navigation

        public void NavigateToAccountpage()
        {


            ObjectRepository.Driver.FindElement(Accountlink).Click();
            Thread.Sleep(2000);
            GenericHelper.TakeScreenShot("C:/Automation/Screenshot/Account.Jpeg");
        }
        #endregion
    }
}
