using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.PageObject;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace SeleniumWebdriver.StepDefination
{
    [Binding]
    public sealed class HomePage
    {
        PageObject.HomePage hPage = new PageObject.HomePage(ObjectRepository.Driver);

        [When(@"User click on Account link")]
        public void WhenUserclickOnAccountLink()
        {
           
            hPage.NavigationToLink();
           
        }
        [Then(@"Account page should be display")]
        public void ThenAccountPageShouldBeDisplay()
        {
            //
        }
        [When(@"User click on helplink link")]
        public void WhenUserClickOnHelplinkLink()
        {
            hPage.HelpLink();
        }
        [Then(@"Help page should be display")]
        public void ThenHelpPageShouldBeDisplay()
        {
            GenericHelper.TakeScreenShot("C:/Automation/Screenshot/Help.Jpeg");
        }
        [When(@"User click on setting link")]
        public void WhenUserClickOnSettingLink()
        {
            hPage.Settinglink();
        }
        [Then(@"Setting page should be display")]
        public void ThenSettingPageShouldBeDisplay()
        {
            GenericHelper.TakeScreenShot("C:/Automation/Screenshot/Setting.Jpeg");
        }
        [When(@"User click on About link")]
        public void WhenUserClickOnAboutLink()
        {
            hPage.About();

        }
        [Then(@"About page should be display")]
        public void ThenAboutPageShouldBeDisplay()
        {
            GenericHelper.TakeScreenShot("C:/Automation/Screenshot/About.Jpeg");
        }
        [When(@"User click on Home link")]
        public void WhenUserClickOnHomeLink()
        {
            hPage.Home();
        }
        [Then(@"Home page should be display")]
        public void ThenHomePageShouldBeDisplay()
        {
            //var dashWindowHandle = ObjectRepository.Driver.WindowHandles[0];
            //Assert.IsTrue(!string.IsNullOrEmpty(dashWindowHandle));
            //ObjectRepository.Driver.SwitchTo().Window(ObjectRepository.Driver.WindowHandles[0]);
            //System.Threading.Thread.Sleep(4000);
            //ObjectRepository.Driver.Manage().Window.Maximize();
            //Thread.Sleep(2000);
        }
        [When(@"User click on Upload link")]
        public void WhenUserClickOnUploadLink()
        {
                 hPage.UploadFilelink();
        }
        [Then(@"User able to select and upload the file")]
        public void ThenUserAbleToSelectAndUploadTheFile()
        {
            hPage.UploadFile();
        }

        [When(@"User click on delete workspace")]
        public void WhenUserClickOnDeleteWorkspace()
        {
            
            hPage.DeleteWSpacelink();
        }

        [Then(@"User should get the confirmation pop up")]
        public void ThenUserShouldGetTheConfirmationPopUp()
        {
            hPage.DeleteWSpacepopup();
        }
        [When(@"User click on Yes button")]
        public void WhenUserClickOnYesButton()
        {
            hPage.DeleteWSpace();
        }
        [Then(@"Workspace should be deleted")]
        public void ThenWorkspaceShouldBeDeleted()
        {
            IWebElement deleterecord = ObjectRepository.Driver.FindElement(By.XPath("//*[@id='pdf-being-processed-container']/div[1]/div[2]/div/div/div/div"));
            Console.WriteLine(deleterecord.Text);
        }

        [When(@"User click on processed medical record")]
        public void WhenUserClickOnProcessedMedicalRecord()
        {
            hPage.AddrecordsWsapce();

        }
        [Then(@"User should get the Add Medical records pop up window")]
        public void ThenUserShouldGetTheAddMedicalRecordsPopUpWindow()
        {
           // hPage.AddWorkspaceClickAddButton();
        }
        [When(@"User select workspace from dropdown")]
        public void WhenUserSelectWorkspaceFromDropdown()
        {
            hPage.AddworkspaceDropdown();
        }
        [When(@"User Click on Add Button")]
        public void WhenUserClickOnAddButton()
        {
            hPage.AddWorkspaceClickAddButton();
        }

        [Then(@"Process medical record should be added in workspace")]
        public void ThenProcessMedicalRecordShouldBeAddedInWorkspace()
        {
           // ScenarioContext.Current.Pending();
        }





    }
}
