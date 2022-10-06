using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace SeleniumQuiz
{
    public class ScrollUpDown: CommonMethods
    {
        By image = By.XPath("//*[@id='header']/div/div/div/div[1]/div/a/img");
        By scrlelement = By.ClassName("footer-widget");
        public ScrollUpDown(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void scrollUpandDown()
        {
            extent.AttachReporter(report);
            ExtentTest test = extent.CreateTest("T7_scroll up and down");

            OpenURL();
            Assert.IsTrue(isElementDisplayed(image));

            //Scroll down
            scroll(scrlelement);
            wait();
            //Scroll up
            scrollUp();
           
            wait();
            extent.Flush();
        }

    }
}
