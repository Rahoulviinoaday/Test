using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumWebdriver.TestScript.ScreenShot;
using SeleniumWebdriver.Settings;
using SeleniumWebdriver.ComponentHelper;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Interactions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumWebdriver.TestScript.MouseAction
{
    [TestClass]
    public class TestMouseAction

    {
        [TestMethod]
        public void TestContextClik()
        {
            LoginFlow login = new LoginFlow();
            login.LoginFL();
            BrowserHelper.RefreshPage();
            Actions act = new Actions(ObjectRepository.Driver);
            IWebElement ele = ObjectRepository.Driver.FindElement(By.Id("talos-mergezone"));
            act.ContextClick(ele).Build().Perform();
            //below syntax alos we can use for write the action method 
            //IAction iact=act.Build();
            //iact.Perform();
            Thread.Sleep(2000);
        }
        public void DragNDrop()
        {
            LoginFlow login = new LoginFlow();
            login.LoginFL();
            OpenQA.Selenium.IJavaScriptExecutor js = ObjectRepository.Driver as OpenQA.Selenium.IJavaScriptExecutor;
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,700);");
            ObjectRepository.Driver.FindElement(By.XPath("//div[contains(text(),'101ABC')]")).Click();
            Thread.Sleep(6000);
            ButtonHelper.ClickButton(By.XPath("//body/div[@id='root']/div[1]/div[1]/aside[1]/ul[1]/li[1]/a[1]/i[1]"));
            ComponentHelper.TextBoxHelper.ClearTextBox(By.XPath("//div[@class='fv__search-panel-form-container'] //*[@class='fv__search-panel-form-input']"));
            TextBoxHelper.TypeInTextBox(By.XPath("//div[@class='fv__search-panel-form-container'] //*[@class='fv__search-panel-form-input']"),ObjectRepository.Config.SearchText());
            ButtonHelper.ClickButton(By.XPath("//div[@class='fv__search-panel-form-container'] //*[@id='searcher']"));
            Thread.Sleep(3000);
            Actions act = new Actions(ObjectRepository.Driver);
            IWebElement src = ObjectRepository.Driver.FindElement(By.XPath("//*[@id='thumbnail-container']/div/div[1]/div[1]"));
            IWebElement trg = ObjectRepository.Driver.FindElement(By.XPath("//*[@id='workspace-nav-scrollbar']/ul/li[7]/ul/li[1]/a"));
            act.DragAndDrop(src, trg).Build().Perform();
            Thread.Sleep(3000);
        }
        [TestMethod]
        public void TestClicknHold()// This is the dummy code for the Click on hold method we can repleace the url with APS and use the same code for the drag and drop
        {
            NavigationHelper.NavigateToUrl("http://demos.telerik.com/kendo-ui/sortable/index");
            Actions act = new Actions(ObjectRepository.Driver);
            IWebElement ele = ObjectRepository.Driver.FindElement(By.XPath("//ul[@id='sortable-basic']/li[12]"));
            IWebElement tar = ObjectRepository.Driver.FindElement(By.XPath("//ul[@id='sortable-basic']/li[2]/span"));
            act.ClickAndHold(ele).MoveToElement(tar,0,30).Release().Build().Perform();
            Thread.Sleep(10000);
        
        }
        [TestMethod]

        public void TestKeyboard()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            Thread.Sleep(2000);
            Actions act = new Actions(ObjectRepository.Driver);
            //Ctrl+t (opening new tab)
            //act.KeyDown(Keys.LeftControl).SendKeys("t").KeyUp(Keys.LeftControl).Build().Perform();
            //Thread.Sleep(3000);
            //Crt+Shift+a(opening Add ons in browser )
            //act.KeyDown(Keys.LeftControl).KeyDown(Keys.LeftShift).SendKeys("a").KeyUp(Keys.LeftShift).KeyUp(Keys.LeftControl)
            //    .Build().Perform();
            //Thread.Sleep(3000);

            //alt+f+x (Closing the tab)

            act.KeyDown(Keys.LeftAlt).SendKeys("f").SendKeys("x").Build().Perform();
            // shift Key 


            act.KeyDown(Keys.LeftShift).SendKeys("f").SendKeys("x")
                .KeyUp(Keys.LeftShift).Build().Perform();


        }


    }
}
