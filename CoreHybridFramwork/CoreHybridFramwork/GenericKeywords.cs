﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
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


        public void openBrowser(string bType)// which browser
        {

        }
        public void navigate(string url)//which site
        {
            driver.Url = url;
        }
        public void click(string locator)//which button
        {
            driver.FindElement().Click;
        }
        public void input(string locator, string data)//
        {

        }
        public void verifyText(string locator, string expectedText)
        {

        }
    }
}
