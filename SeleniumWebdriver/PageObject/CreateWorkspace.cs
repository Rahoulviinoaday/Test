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
    public class CreateWorkspace
    {

        #region WebElement

        private By createNewworkspace = By.XPath("//div[@class='dashboard-widgets']/div[1]");
        private By Name = By.XPath("//input[@id='workspaceNameInput']");
        private By Case = By.XPath("//input[@id='workspaceSubjectInput']");
        private By Claiments = By.XPath("//input[@id='workspaceClaimantsInput']");
        private By defedent = By.XPath("//input[@id='workspaceDefendantsInput']");
        private By Create = By.XPath("//div[contains(text(),'Create')]");

        public CreateWorkspace(IWebDriver driver)
        {
            Driver = driver;
        }

        public CreateWorkspace()
        {
        }

        public IWebDriver Driver { get; }

        #endregion

        #region Navigation

        public void NavigateToWorkspaceform()
        {
            ObjectRepository.Driver.FindElement(createNewworkspace).Click();
            Thread.Sleep(3000);
            GenericHelper.TakeScreenShot("C:/Automation/Screenshot/NewForm.Jpeg");
        }

        
        public void Createform()
        {
            ObjectRepository.Driver.FindElement(Name).SendKeys("Automationcase");
            ObjectRepository.Driver.FindElement(Case).SendKeys("Case");
            ObjectRepository.Driver.FindElement(Claiments).SendKeys("Claiments");
            ObjectRepository.Driver.FindElement(defedent).SendKeys("defedent");
            
            
        }
        public void ClickCreate()
        {

            ButtonHelper.ClickButton(Create);
            Thread.Sleep(5000);

        }
        #endregion
    }
}
