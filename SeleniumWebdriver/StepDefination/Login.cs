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
    public sealed class Login
    {
        [Given(@"user is on Home page")]
        public void GivenUserIsOnHomePage()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
        }

        [Given(@"Home page is visible")]
        public void GivenHomePageIsVisible()
        {
           // ScenarioContext.Current.Pending();
        }

        [Given(@"user is at login page")]
        public void GivenUserIsAtLoginPage()
        {
            //ScenarioContext.Current.Pending();
        }

        [When(@"the user click on login button")]
        public void WhenTheUserClickOnLoginButton()
        {
            LinkHelper.ClickLink(By.XPath("//*[@class='card-body']/form/div[3]"));
            Thread.Sleep(3000);

        }

        [Then(@"user is present with name window")]
        public void ThenUserIsPresentWithNameWindow()
        {
            var newWindowHandle = ObjectRepository.Driver.WindowHandles[1];
            Assert.IsTrue(!string.IsNullOrEmpty(newWindowHandle));
            ObjectRepository.Driver.SwitchTo().Window(ObjectRepository.Driver.WindowHandles[1]);
        }

        [Then(@"user enter the email address (.*)")]
        public void ThenUserEnterTheEmailAddress(string p0)
        {
            TextBoxHelper.TypeInTextBox(By.Id("i0116"), ObjectRepository.Config.GetUsername());
        }

        [When(@"the user click on Next button")]
        public void WhenTheUserClickOnNextButton()
        {
            LinkHelper.ClickLink(By.Id("idSIButton9"));
        }

        [When(@"user enter the password (.*)")]
        public void WhenUserEnterThePassword(string p0)
        {
            TextBoxHelper.TypeInTextBox(By.Id("i0118"), ObjectRepository.Config.GetPassword());
            Thread.Sleep(3000);
        }

        [When(@"the user click on step button")]
        public void WhenTheUserClickOnStepButton()
        {
            ScenarioContext.Current.Pending();
        }


        //[When(@"the user click on step button")]
        //public void WhenTheUserClickOnstepButton()
        //{
        //    ButtonHelper.ClickButton(By.XPath("//*[@id='idSIButton9']"));
        //}


        [Then(@"user is present with confirmation screen")]
        public void ThenUserIsPresentWithConfirmationScreen()
        {
            // ButtonHelper.ClickButton(By.CssSelector("#idSIButton9"));
        }

        [When(@"user click on yes button")]
        public void WhenUserClickOnYesButton()
        {
            ButtonHelper.ClickButton(By.CssSelector("#idSIButton9"));
            Thread.Sleep(2000);
        }
        [Then(@"User should be at home page")]
        public void ThenUserShouldBeAtHomePage()
        {
            Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//ul[@class='ml-auto navbar-nav']/li[2]")));
        }

    

    }
}
