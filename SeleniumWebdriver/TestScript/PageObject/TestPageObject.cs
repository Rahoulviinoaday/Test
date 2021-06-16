using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.PageObject;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.TestScript.PageObject
{ 
[TestClass]
   public class TestPageObject
    {
    [TestMethod]

    public void TestPageObjectModel()
    {

        NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
        HomePage homepage = new HomePage();
           
            LoginPage loginPage = new LoginPage();
           
            loginPage.Login(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());
          
           // homepage.NavigationToLink();
            CreateWorkspace Newworkspace = new CreateWorkspace();
            Newworkspace.NavigateToWorkspaceform();
            Newworkspace.Createform();

    }

    }
}
