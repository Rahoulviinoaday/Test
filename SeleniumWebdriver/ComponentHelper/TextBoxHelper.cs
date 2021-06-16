using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.ComponentHelper
{
   public class TextBoxHelper
    {
        private static IWebElement element;
        public static void TypeInTextBox(By Locator,string text)
        {
            element = GenericHelper.GetElement(Locator);
            element.SendKeys(text);
        }

        public static void ClearTextBox(By Locator)
        {
            element = GenericHelper.GetElement(Locator);
            element.Clear();
        }
    }
}
