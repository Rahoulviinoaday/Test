using SeleniumWebdriver.Interfaces;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.Configuration
{
    public class AppConfigReader : IConfig
    {
        public BrowserType GetBrowser()
        {
            string browser = System.Configuration.ConfigurationManager.AppSettings.Get(AppConfigKeys.Browser);
            return (BrowserType)Enum.Parse(typeof(BrowserType), browser);
        }

        public int GetElementLoadTimeOut()
        {
            string timeout = System.Configuration.ConfigurationManager.AppSettings.Get(AppConfigKeys.ElementLoadTimeOut);
            if (timeout == null)
                return 30;
            return Convert.ToInt32(timeout);
        }

        public int GetPageLoadTimeOut()
        {
           string timeout= System.Configuration.ConfigurationManager.AppSettings.Get(AppConfigKeys.PageLoadTimeOut);
            if (timeout == null)
                return 30;
            return Convert.ToInt32(timeout);

        }

        public string GetPassword()
        {
            return System.Configuration.ConfigurationManager.AppSettings.Get(AppConfigKeys.Password);
        }

        public string GetUsername()
        {
            return System.Configuration.ConfigurationManager.AppSettings.Get(AppConfigKeys.Username);
        }

        public string GetWebsite()
        {
            return System.Configuration.ConfigurationManager.AppSettings.Get(AppConfigKeys.Website);
        }

        public string SearchText()
        {
            return System.Configuration.ConfigurationManager.AppSettings.Get(AppConfigKeys.SearchText);
        }
    }
}
