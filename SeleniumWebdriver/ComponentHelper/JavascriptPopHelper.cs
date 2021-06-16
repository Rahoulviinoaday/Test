using OpenQA.Selenium;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.ComponentHelper
{
    public class JavascriptPopHelper
    {
        public static bool IsAlertPopuppresent()
        {
            try
            {
                ObjectRepository.Driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;

            }

        }
        public static string GetPopupText()
        {
            if (!IsAlertPopuppresent())
                return "";
            return ObjectRepository.Driver.SwitchTo().Alert().Text;
        
        }
        public static void ClickOnPopup()
        {
            if (!IsAlertPopuppresent())
                return;
            ObjectRepository.Driver.SwitchTo().Alert().Accept();

        }
        public static void ClickOnCancelPopup()
        {
            if (!IsAlertPopuppresent())
                return;
            ObjectRepository.Driver.SwitchTo().Alert().Dismiss();

        }
        public static void Sendkeys(string text)
        {
            if (!IsAlertPopuppresent())
                return;
            ObjectRepository.Driver.SwitchTo().Alert().SendKeys(text);
        }

    }


    }

