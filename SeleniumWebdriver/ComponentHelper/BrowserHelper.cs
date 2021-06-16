using OpenQA.Selenium;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.ComponentHelper
{
    public class BrowserHelper
    {
        public static void BrowserMaximize()
        {
            ObjectRepository.Driver.Manage().Window.Maximize();
        }
        public static void GoBack()
        {

            ObjectRepository.Driver.Navigate().Back();
        }

        public static void Forward()
        {
            ObjectRepository.Driver.Navigate().Forward();

        }
        public static void RefreshPage()
        {
            ObjectRepository.Driver.Navigate().Refresh();
        }
        public static void SwitchToWindow(int index)
        {
            IReadOnlyCollection<string> windows = ObjectRepository.Driver.WindowHandles;
            if(windows.Count< index)
            {
                throw new NoSuchWindowException("Invalid broser window Index"+ index);
            }
            //ObjectRepository.Driver.SwitchTo().Window(windows[index]);
            BrowserMaximize();
        }
    }
}
