using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumWebdriver.PageObject
{
    public class HomePage
    {
        #region WebElement
       
        private By Uploadfile = By.XPath("//div[@class='dashboard-widgets']/div[3]");
        private By Accountlink = By.LinkText("Account");
        private By helplink = By.LinkText("Help");
        private By Settingslink = By.LinkText("Settings");
        private By Aboutlink = By.LinkText("About");
        private By HomeLink = By.LinkText("Home");
        private By Logoutlink = By.XPath("//ul[@class='ml-auto navbar-nav']/li[2]/div/button[4]");
        private By DeleteWorkspace = By.XPath("//div[@id='talos-recent-workspaces-card']/div/div[2]/div/div/div[2]/div[3]/div[5]/div //button[@type='button'][1]");
        private By DeleteWorkspaceYesButton = By.XPath("//div[@class='modal-content']/div[2] //button[@type='button'][2]");
        private By DeleteWorkspaceCancelButton = By.XPath("//div[@class='modal-content']/div[2] //button[@type='button'][1]");
        private By DeleteWorkspacePopUp = By.XPath("//div[@class='modal-content']/div/div");
        private By AddRecordstoWorkspace = By.XPath("//div[@id='talos-processed-pdf-card']/div/div/div[2]/div/div/div[2]/div/div[1]");

        private By AddWorkspaceDropdown = By.Id("workspaceInput");
        private By AddRecordstoWorkspaceAddButton = By.XPath("//div[contains(text(),'Add')]");
        private IWebDriver driver;
        //public HomePage(IWebDriver driver)
        //{
        //    //this.driver = driver;
        //}

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public HomePage()
        {
        }
        #endregion

        #region Navigation
        public void NavigationToLink()

        {
            ButtonHelper.ClickButton(Accountlink);
            Thread.Sleep(2000);
            GenericHelper.TakeScreenShot("C:/Automation/Screenshot/Account.Jpeg");
        }
        public void HelpLink()
        {
            ButtonHelper.ClickButton(helplink);
            Thread.Sleep(2000);
            GenericHelper.TakeScreenShot("C:/Automation/Screenshot/Help.Jpeg");
        }
        public void Settinglink()
        {
            ButtonHelper.ClickButton(Settingslink);
            Thread.Sleep(2000);
            GenericHelper.TakeScreenShot("C:/Automation/Screenshot/Setting.Jpeg");
        }
        public void About()
        { 
            ButtonHelper.ClickButton(Aboutlink);
            Thread.Sleep(2000);
            GenericHelper.TakeScreenShot("C:/Automation/Screenshot/About.Jpeg");
        }
        public void Home()
        {          
            ButtonHelper.ClickButton(HomeLink);
            var dashWindowHandle = ObjectRepository.Driver.WindowHandles[0];
            Assert.IsTrue(!string.IsNullOrEmpty(dashWindowHandle));
            ObjectRepository.Driver.SwitchTo().Window(ObjectRepository.Driver.WindowHandles[0]);
            System.Threading.Thread.Sleep(4000);
            ObjectRepository.Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//ul[@class='ml-auto navbar-nav']/li[2]")));
            GenericHelper.TakeScreenShot("C:/Automation/Screenshot/Homepage.Jpeg");
           

        }
        #endregion
        public void UploadFilelink()
        {
            ButtonHelper.ClickButton(Uploadfile);
           
        }
        public void UploadFile ()
        {
            ProcessStartInfo processinfo = new ProcessStartInfo();
            processinfo.FileName = @"C:\AutoIT\FileUpload.exe";
            processinfo.Arguments = @"C:\AutoIT\Test_File_10_Pages.pdf";
            Process process = Process.Start(processinfo);
            process.WaitForExit();
            process.Close();
            Console.WriteLine("\nThis is File upload code Executed successfully");
            Thread.Sleep(10000);
           // ObjectRepository.Driver.Close();

        }
        public void DeleteWSpacelink()
        {
            ObjectRepository.Driver.Navigate().Refresh();
            OpenQA.Selenium.IJavaScriptExecutor js = ObjectRepository.Driver as OpenQA.Selenium.IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,1800);");
            Thread.Sleep(5000);
            js.ExecuteScript("window.scrollBy(0,1800);");
            Thread.Sleep(5000);
            ObjectRepository.Driver.FindElement(By.XPath("//div[@id='talos-recent-workspaces-card']/div/div[2]/div/div/div[2]/div[3]/div[5]/div //button[@type='button'][1]")).Click();
            //ButtonHelper.ClickButton(DeleteWorkspace);

        }
        public void DeleteWSpace()
        {
            Thread.Sleep(3000);
            ButtonHelper.ClickButton(DeleteWorkspaceYesButton);
          
        }

        public void DeleteWSpacepopup()
        {
            IWebElement alerttext = ObjectRepository.Driver.FindElement(By.XPath("//div[@class='modal-content']/div/div"));
            Console.WriteLine(alerttext.Text);
        }
        public void AddrecordsWsapce()
        {
            
            ObjectRepository.Driver.Navigate().Refresh();
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            OpenQA.Selenium.IJavaScriptExecutor js = ObjectRepository.Driver as OpenQA.Selenium.IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,300);");
            Thread.Sleep(5000);
            ObjectRepository.Driver.FindElement(By.XPath("//div[@id='talos-processed-pdf-card']/div/div/div[2]/div/div/div[2]/div/div[1]")).Click();

            //ButtonHelper.ClickButton(AddRecordstoWorkspace);

        }
        public void AddworkspaceDropdown()
        {
          
           ButtonHelper.ClickButton(AddWorkspaceDropdown);
            var option = driver.FindElement(By.Id("workspaceInput"));
            var selectElement = new SelectElement(option);
            Thread.Sleep(2000);
            selectElement.SelectByIndex(3);

        }
        public void AddWorkspaceClickAddButton()
        {

            ButtonHelper.ClickButton(AddRecordstoWorkspaceAddButton);

        }
    }
}
