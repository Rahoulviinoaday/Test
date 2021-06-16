using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SeleniumWebdriver.ComponentHelper
{
    public class RedioButtonHelper
    {
        private static IWebElement element;
        public static void ClickRedioButton(By locator)
        {
            element = GenericHelper.GetElement(locator);
            element.Click();

        }
        public static bool IsRedioButtonChecked(By locator)
        {
            element = GenericHelper.GetElement(locator);
            string flag = element.GetAttribute("Checked");

            if (flag == null)
                return false;
            else
                return flag.Equals("true") || flag.Equals("checked");
        }
    }
}
