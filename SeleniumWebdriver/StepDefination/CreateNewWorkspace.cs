using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.ComponentHelper;
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
    public sealed class CreateNewWorkspace
    {
        [Given(@"user is on Home page")]
        public void GivenUserIsOnHomePage()
        {
            var dashWindowHandle = ObjectRepository.Driver.WindowHandles[0];
            Assert.IsTrue(!string.IsNullOrEmpty(dashWindowHandle));
            ObjectRepository.Driver.SwitchTo().Window(ObjectRepository.Driver.WindowHandles[0]);
            System.Threading.Thread.Sleep(4000);
            ObjectRepository.Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }
        [Given(@"Home page is visible")]
        public void GivenHomePageIsVisible()
        {
            Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//ul[@class='ml-auto navbar-nav']/li[2]")));
        }
        [When(@"user is click on Create new workspce")]
        public void WhenUserIsClickOnCreateNewWorkspce()
        {
            ObjectRepository.Driver.FindElement(By.XPath("//div[@class='dashboard-widgets']/div[1]")).Click();
        }
        [Then(@"User should see the new workspace form")]
        public void ThenUserShouldSeeTheNewWorkspaceForm()
        {
            var dashWindowHandle = ObjectRepository.Driver.WindowHandles[0];
            Assert.IsTrue(!string.IsNullOrEmpty(dashWindowHandle));
            ObjectRepository.Driver.SwitchTo().Window(ObjectRepository.Driver.WindowHandles[0]);
            System.Threading.Thread.Sleep(4000);
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





    }
}
