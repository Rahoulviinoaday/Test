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
    public sealed class LogFlow
    {
        private LoginPage lPage;
        [When(@"User enter login details")]
        public void WhenUserEnterLoginDetails()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            ObjectRepository.Driver.Manage().Cookies.DeleteAllCookies();
            lPage = new LoginPage(ObjectRepository.Driver);
            lPage.Login();
            
            lPage.UserName();
            lPage.ClickNext(); lPage.Password();
            lPage.ClickSignIn();
            lPage.ClickStaySignIn();
           
        }
        [Then(@"User is present navigate to Home page")]
        public void ThenUserIsPresentNavigateToHomePage()
        {
            lPage.NavigateToHomepage();
        }



    }
}
