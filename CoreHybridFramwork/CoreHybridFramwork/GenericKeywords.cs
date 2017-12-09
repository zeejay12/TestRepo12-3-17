using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreHybridFramwork
{
    
    class GenericKeywords
    {
        //open browser
        //navigate
        //click somewhere
        //input the data- type
        //verify Title 
        //verify text

        IWebDriver driver = null;

        public void OpenBrowser(string bType)// which browser
        {
            if (bType.Equals("Mozilla"))
            {
                driver = new FirefoxDriver();
            }
            else if (bType.Equals("Chrome"))
            {
                driver = new ChromeDriver();
            }
            else if (bType.Equals("IE"))
            {
                driver = new InternetExplorerDriver();
            }
        }
        public void Navigate(string urlkey)//which site
        {
            Console.WriteLine("Navigating to " + ConfigurationManager.AppSettings[urlkey]);
            driver.Url = ConfigurationManager.AppSettings[urlkey];
        }
        public void Click(string locatorkey)//which button
        {
            Console.WriteLine("Clicking on " + ConfigurationManager.AppSettings[locatorkey]);
            IWebElement e = GetElement(locatorkey);
            e.Click();
        }
        public void Input(string locatorkey, string data)
        {
            IWebElement e = GetElement(locatorkey);
            e.SendKeys(data);
        }
        public void verifyText(string locatorkey, string expectedText)
        {
            IWebElement e = GetElement(locatorkey);
            string actualText = e.Text;
            Assert.AreEqual(expectedText, actualText);

        }

        /**********utility functions************/

        public IWebElement GetElement(string locatorKey)
        {
            IWebElement e = null;
            try
            {

                if (locatorKey.EndsWith("_id"))
                {
                    e = driver.FindElement(By.Id(ConfigurationManager.AppSettings[locatorKey]));
                }
                else if (locatorKey.EndsWith("_name"))
                {
                    e = driver.FindElement(By.Name(ConfigurationManager.AppSettings[locatorKey]));
                }
                else if (locatorKey.EndsWith("_xpath"))
                {
                    e = driver.FindElement(By.XPath(ConfigurationManager.AppSettings[locatorKey]));
                }
            }
            catch (Exception ex)
            {
                Assert.Fail("Failure in the element extraction" + locatorKey);
            }
            return e;
        }
    }
}
