using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.PageObject;
using SeleniumWebdriver.Settings;
using System.Threading;
using TechTalk.SpecFlow;

namespace SeleniumWebdriver.StepDefinition
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

        #endregion
        [Given(@"user is on Home page")]
        public void GivenUserIsOnHomePage()
        {

            Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//ul[@class='ml-auto navbar-nav']/li[2]")));
            //var dashWindowHandle = ObjectRepository.Driver.WindowHandles[0];
            //Assert.IsTrue(!string.IsNullOrEmpty(dashWindowHandle));
            //ObjectRepository.Driver.SwitchTo().Window(ObjectRepository.Driver.WindowHandles[0]);
            //System.Threading.Thread.Sleep(4000);
            //ObjectRepository.Driver.Manage().Window.Maximize();
            //Thread.Sleep(2000);
        }

        [Given(@"Home page is visible")]
        public void GivenHomePageIsVisible()
        {
            Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//*[@class='navbar-brand']")));

        }



    }
}