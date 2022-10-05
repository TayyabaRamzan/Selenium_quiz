using AventStack.ExtentReports.Reporter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumQuiz
{

    public class CommonMethods
    {

        //public ExtentHtmlReporter report = new ExtentHtmlReporter("C://Users//ramzatay//source//repos//DinePartner//reports//" + DateTime.Now.ToString("ddMMyyyy"));
        //public AventStack.ExtentReports.ExtentReports extent = new AventStack.ExtentReports.ExtentReports();

        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IWebDriver driver;
        Actions actions;

        public void startBrowser()
        {
            driver = new ChromeDriver();
        }

        public void closebrowser()
        {
            wait();
            driver.Close();
        }
        public void QuitBrowser()
        {
            wait();
            driver.Quit();
        }
        public void OpenURL()
        {
            driver.Navigate().GoToUrl("https://automationexercise.com/");
            driver.Manage().Window.Maximize();

        }
        public void wait()
        {
            Thread.Sleep(2000);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1000);
        }

        public IWebElement findElement(By locator)
        {

            return driver.FindElement(locator);
        }

        public void click(By locator)
        {
            findElement(locator).Click();
        }
        public void Clear(By locator)
        {

            findElement(locator).Clear();

        }
        public void scroll(By locator)
        {
            IWebElement element = findElement(locator);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }
        public void MovetoNewTab()
        {

            driver.SwitchTo().Window(driver.WindowHandles[1]);

        }
        public void typetext(By locator, string text)
        {
            IWebElement element = findElement(locator);
            element.SendKeys(text);
        }

        public void radioclick(By locator)
        {
            IWebElement element=findElement(locator);
            actions.Click(element).Build().Perform();
        }

       public bool isElementDisplayed(By locator)
        {
            return findElement(locator).Displayed||findElement(locator).Enabled?true:false;

        }
        public void hoverclick(By locator)
        {
            IWebElement element = findElement(locator);
            actions.MoveToElement(element).Build().Perform();
        }
    }
}