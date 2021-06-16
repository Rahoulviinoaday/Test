using Microsoft.VisualStudio.TestTools.UnitTesting;
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
using OpenQA.Selenium.Support.UI;
using System.Drawing;

namespace SeleniumWebdriver.TestScript.APS_Scripts
{
    [TestClass]
    public class DeleteRecords
    {
      [TestMethod]
        public void DeleteRecord()
        {
            LoginFlow login = new LoginFlow();
            login.LoginFL();
            BrowserHelper.RefreshPage();
            Thread.Sleep(3000); 
            OpenQA.Selenium.IJavaScriptExecutor js = ObjectRepository.Driver as OpenQA.Selenium.IJavaScriptExecutor;       
            js.ExecuteScript("window.scrollBy(0,200);");
            ButtonHelper.ClickButton(By.XPath("//div[@id='talos-recent-workspaces-card']/div/div[2]/div/div/div[2]/div[3]/div[5]/div //button[@type='button'][1]"));
            Thread.Sleep(3000);
            
            GenericHelper.TakeScreenShot("C:/Automation/Screenshot/AlertPopup.Jpeg");
            
            //Bitmap memoryImage;
            //memoryImage = new System.Drawing.Bitmap(2000, 1500);
            //Size s = new Size(memoryImage.Width, memoryImage.Height);
            //Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            //memoryGraphics.CopyFromScreen(0, 0, 0, 0, s);
            //string str = @"C:\Automation\Screenshot\Screenshot.png";
            //memoryImage.Save(str);

            var text = JavascriptPopHelper.GetPopupText();
            JavascriptPopHelper.ClickOnPopup();
            Console.WriteLine(text);
            ////WebDriverWait wait = new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromSeconds(10));
            //IAlert alert = ObjectRepository.Driver.SwitchTo().Alert();
            //var text = alert.Text;
            //alert.Accept();
           
            
            Thread.Sleep(2000);
            BrowserHelper.RefreshPage();
            
        }

        [TestMethod]

        public void TestConfirmPopup()
        {
            LoginFlow login = new LoginFlow();
            login.LoginFL();
            BrowserHelper.RefreshPage();
            Thread.Sleep(3000);
            OpenQA.Selenium.IJavaScriptExecutor js = ObjectRepository.Driver as OpenQA.Selenium.IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,200);");
            ButtonHelper.ClickButton(By.XPath("//body[1]/div[1]/div[1]/div[1]/main[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[3]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/div[4]/div[1]"));
            Thread.Sleep(3000);
            //IAlert confirm=ObjectRepository.Driver.SwitchTo().Alert();
            //confirm.Accept();
            IWebElement alerttext=ObjectRepository.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div"));
            Console.WriteLine(alerttext.Text);
            ButtonHelper.ClickButton(By.XPath("//button[contains(text(),'Yes')]"));
            IWebElement deleterecord = ObjectRepository.Driver.FindElement(By.XPath("//*[@id='pdf-being-processed-container']/div[1]/div[2]/div/div/div/div"));
            Console.WriteLine(deleterecord.Text);
            





        }
    }
}
