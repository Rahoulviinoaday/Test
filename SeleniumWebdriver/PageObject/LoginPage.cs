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
        private By LoginBtton = By.XPath("//*[@class='card-body']/form/div[3]");
        private By SigninTextBox = By.XPath("//input[@type='email']");
        private By signinNext = By.Id("idSIButton9");
        private By EnterPasswordTextBox = By.XPath("//*[@name='passwd']");
        private By Forgotpassword = By.XPath("//a[@id='idA_PWD_ForgotPassword']");
        private By Singinbutton = By.XPath("//*[@type='submit']");
        private By Staysinginbtn = By.XPath("//*[@id='idSIButton9']"); // this is stay signed in "Yes" Button
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public LoginPage()
        {
        }
        #endregion

        #region Actions
        public void Login()
        {
            ObjectRepository.Driver.FindElement(LoginBtton).Click();
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Thread.Sleep(2000);
            var newWindowHandle = ObjectRepository.Driver.WindowHandles[1];
            Assert.IsTrue(!string.IsNullOrEmpty(newWindowHandle));
            ObjectRepository.Driver.SwitchTo().Window(ObjectRepository.Driver.WindowHandles[1]);
        }
        public void UserName()
        {
          
            ObjectRepository.Driver.FindElement(SigninTextBox).SendKeys("Rahoulviinoaday@fs.co.uk");
        }
        public void ClickNext()
        {
            ObjectRepository.Driver.FindElement(signinNext).Click();
        }
        public void Password()
        {
            ObjectRepository.Driver.FindElement(EnterPasswordTextBox).SendKeys("Rvaishu$25");
            Thread.Sleep(2000);
        }
        public void ClickSignIn()
        {
            ObjectRepository.Driver.FindElement(Singinbutton).Click();
        }
        public void ClickStaySignIn()
        {
            ObjectRepository.Driver.FindElement(Staysinginbtn).Click();
        }
        
        #endregion

        #region Navigation

        public void NavigateToHomepage()
        {
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            var dashWindowHandle = ObjectRepository.Driver.WindowHandles[0];
            Assert.IsTrue(!string.IsNullOrEmpty(dashWindowHandle));
            ObjectRepository.Driver.SwitchTo().Window(ObjectRepository.Driver.WindowHandles[0]);
            //System.Threading.Thread.Sleep(4000);
            ObjectRepository.Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//ul[@class='ml-auto navbar-nav']/li[2]")));
            Assert.AreEqual("Auto-Pagination Software", "Auto-Pagination Software");
            GenericHelper.TakeScreenShot("C:/Automation/Screenshot/Homepage.Jpeg");
           // GenericHelper.TakeScreenShot("HomeScreen");
           // ObjectRepository.Driver.Close();
        }
        #endregion
    }
}
