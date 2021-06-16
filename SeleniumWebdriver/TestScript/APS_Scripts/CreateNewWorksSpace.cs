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

namespace SeleniumWebdriver.TestScript.ScreenShot
{
    [TestClass]
    public class CreateNewWorksSpace
    {
        [TestMethod]
        public void NewWorkSpace()
        {
            LoginFlow login = new LoginFlow();
            login.LoginFL();
            // Create new workspace flow
            Thread.Sleep(2000);
            ObjectRepository.Driver.FindElement(By.XPath("//div[@class='dashboard-widgets']/div[1]")).Click();

            var dashWindowHandle = ObjectRepository.Driver.WindowHandles[0];
            Assert.IsTrue(!string.IsNullOrEmpty(dashWindowHandle));
            ObjectRepository.Driver.SwitchTo().Window(ObjectRepository.Driver.WindowHandles[0]);
            System.Threading.Thread.Sleep(4000);
            ObjectRepository.Driver.FindElement(By.XPath("//input[@id='workspaceNameInput']")).SendKeys("Automation Workspace 100");
            ObjectRepository.Driver.FindElement(By.XPath("//input[@id='workspaceSubjectInput']")).SendKeys("Automation CaseNumber 100");
            ObjectRepository.Driver.FindElement(By.XPath("//input[@id='workspaceClaimantsInput']")).SendKeys("Automation Claimants John");

            ObjectRepository.Driver.FindElement(By.XPath("//input[@id='workspaceDefendantsInput']")).SendKeys("Automation Claimants John");
            GenericHelper.TakeScreenShot("CreateWS_Form.jpeg");
            //GenericHelper.TakeScreenShot();
            ObjectRepository.Driver.FindElement(By.XPath("//div[contains(text(),'Create')]")).Click();
            GenericHelper.TakeScreenShot();
            GenericHelper.TakeScreenShot("CreateNewWorkspace.Jpeg");
            Console.Write("\nTest Executed \t Successfully created new workspace ");

        }
    }
}
