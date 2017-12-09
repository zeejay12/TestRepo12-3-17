﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*This is our actual test class that will we will be using 
 *
*/

namespace CoreHybridFramwork
{
    [TestFixture]
    public class GmailLogin
    {
        [Test]
        public void DoLogin()
        {
            //webdriver code
            //validate the presence of object

            //hardcode - no
            //read from xls file

            //able to run on different browsers

            //configuration file - locators 
            //driver.FindElement(By.Xpath())
            /*
                        IWebDriver driver = new FirefoxDriver();
                        driver.Url = "https://gmail.com";
                        driver.FindElement(By.XPath("//*[@id='identifierId']")).SendKeys("hello");
                        driver.FindElement(By.XPath("//*[@id=;identifierNext']/div[2]")).Click();
                        */

            GenericKeywords app = new GenericKeywords();
            
            app.OpenBrowser("Mozilla");
            app.Navigate("url");
            app.Input("username_id", "seleniumtraining10");
            app.Click("nextButton_xpath");
            
        }
    }
}
