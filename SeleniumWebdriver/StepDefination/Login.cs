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
    public sealed class Login
    {

        #region Given
        [Given(@"user is at login page")]
        public void GivenUserIsAtLoginPage()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
        }
        #endregion

        #region When

        [When(@"the user click on login button")]
        public void WhenTheUserClickOnLoginButton()
        {
            LinkHelper.ClickLink(By.XPath("//*[@class='card-body']/form/div[3]"));
            Thread.Sleep(3000);

        }
        [When(@"the user click on Next button")]
        public void WhenTheUserClickOnNextButton()
        {
            LinkHelper.ClickLink(By.Id("idSIButton9"));
        }
        [When(@"user enter the password(.*)")]
        public void WhenUserEnterThePassword(string p0)
        {
            TextBoxHelper.TypeInTextBox(By.Id("i0118"), ObjectRepository.Config.GetPassword());
            Thread.Sleep(3000);
        }
        [When(@"the user click on Next button2")]
        public void WhenTheUserClickOnNextButton2()
        {
            ButtonHelper.ClickButton(By.XPath("//*[@id='idSIButton9']"));
        }
        [When(@"user click on yes button")]
        public void WhenUserClickOnYesButton()
        {
            ButtonHelper.ClickButton(By.CssSelector("#idSIButton9"));
            Thread.Sleep(2000);
        }
        [When(@"user is click on Create new workspce")]
        public void WhenUserIsClickOnCreateNewWorkspce()
        {
            ObjectRepository.Driver.FindElement(By.XPath("//div[@class='dashboard-widgets']/div[1]")).Click();
        }
        [When(@"User enter the details in form details")]
        public void WhenUserEnterTheDetailsInFormDetails()
        {
            ObjectRepository.Driver.FindElement(By.XPath("//input[@id='workspaceNameInput']")).SendKeys("Automation Workspace 100");
            ObjectRepository.Driver.FindElement(By.XPath("//input[@id='workspaceSubjectInput']")).SendKeys("Automation CaseNumber 100");
            ObjectRepository.Driver.FindElement(By.XPath("//input[@id='workspaceClaimantsInput']")).SendKeys("Automation Claimants John");
            ObjectRepository.Driver.FindElement(By.XPath("//input[@id='workspaceDefendantsInput']")).SendKeys("Automation Claimants John");
        }

        [When(@"click on Create button")]
        public void WhenClickOnCreateButton()
        {
            ObjectRepository.Driver.FindElement(By.XPath("//div[contains(text(),'Create')]")).Click();
        }


        #endregion
        #region
        [Then(@"user is present with name window")]
        public void ThenUserIsPresentWithNameWindow()
        {
            var newWindowHandle = ObjectRepository.Driver.WindowHandles[1];
            Assert.IsTrue(!string.IsNullOrEmpty(newWindowHandle));
            ObjectRepository.Driver.SwitchTo().Window(ObjectRepository.Driver.WindowHandles[1]);
        }
        [Then(@"user enter the email address(.*)")]
        public void ThenUserEnterTheEmailAddress(string p0)
        {
            TextBoxHelper.TypeInTextBox(By.Id("i0116"), ObjectRepository.Config.GetUsername());
        }
       
      
        [Then(@"user is present with confirmation screen")]
        public void ThenUserIsPresentWithConfirmationScreen()
        {
           // ButtonHelper.ClickButton(By.CssSelector("#idSIButton9"));
        }
        

        [Then(@"User should be at home page")]
        public void ThenUserShouldBeAtHomePage()
        {
           
            var dashWindowHandle = ObjectRepository.Driver.WindowHandles[0];
            Assert.IsTrue(!string.IsNullOrEmpty(dashWindowHandle));
            ObjectRepository.Driver.SwitchTo().Window(ObjectRepository.Driver.WindowHandles[0]);
            System.Threading.Thread.Sleep(4000);
            ObjectRepository.Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        
        [Then(@"USer should see the new workspace form")]
        public void ThenUSerShouldSeeTheNewWorkspaceForm()
        {
            var dashWindowHandle = ObjectRepository.Driver.WindowHandles[0];
            Assert.IsTrue(!string.IsNullOrEmpty(dashWindowHandle));
            ObjectRepository.Driver.SwitchTo().Window(ObjectRepository.Driver.WindowHandles[0]);
            System.Threading.Thread.Sleep(4000);
        }
        
        [Then(@"New workspace should be created")]
        public void ThenNewWorkspaceShouldBeCreated()
        {
            //ScenarioContext.Current.Pending();
        }

        [Then(@"USer should be at Home page")]
        public void ThenUSerShouldBeAtHomePage()
        {
           // ScenarioContext.Current.Pending();
        }

        #endregion


    }
}
