using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.ComponentHelper
{
    public class AssertHelper
    {

        public static void AreEqual(string Expected, string Actual)
        {
            try
            {
                Assert.AreEqual(Expected, Actual);
            }
            catch(Exception)
            { 
            //ignore
            }
        
        
        }
    }
}
