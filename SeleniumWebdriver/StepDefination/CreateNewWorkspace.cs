using OpenQA.Selenium;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.PageObject;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SeleniumWebdriver.StepDefination
{
    [Binding]
    public sealed class CreateNewWorkspace
    {

        private CreateWorkspace cPage;

        
        [When(@"User click on new workspace")]
        public void WhenUserClickOnNewWorkspace()
        {           
            cPage = new CreateWorkspace(ObjectRepository.Driver);

            cPage.NavigateToWorkspaceform();
        }

        [Then(@"User should get the new form page")]
        public void ThenUserShouldGetTheNewFormPage()
        {
            GenericHelper.TakeScreenShot("C:/Automation/Screenshot/CreateWS_Form.Jpeg");
        }

        [When(@"User enter the form deatils")]
        public void WhenUserEnterTheFormDeatils()
        {
            cPage.Createform();
        }

        [When(@"Click on create button")]
        public void WhenClickOnCreateButton()
        {
            cPage.ClickCreate();
        }
        [Then(@"New workspace should be created")]
        public void ThenNewWorkspaceShouldBeCreated()
        {
            GenericHelper.TakeScreenShot("C:/Automation/Screenshot/CreateNewworkspace.Jpeg");
        }

    }
}
