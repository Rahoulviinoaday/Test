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
   public class PageObject_APS
    {
    [TestMethod]

    public void TestPageObjectModel()
    {

        NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            HomePage homepage = new HomePage();
            LoginPage login = new LoginPage();
            CreateWorkspace Newworkspace = new CreateWorkspace();
            login.Login();
            login.UserName();
            login.ClickNext();
            login.Password();
            login.ClickSignIn();
            login.ClickStaySignIn();
            login.NavigateToHomepage();
            homepage.NavigationToLink();
            Newworkspace.NavigateToWorkspaceform();
            Newworkspace.Createform();
            homepage.UploadFile();


        }

    }
}
