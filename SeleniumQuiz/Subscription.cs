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
    public class Subscription: CommonMethods
    {

        By scrlelement = By.ClassName("footer-widget");
        By subscriptionText = By.ClassName("single-widget");
        By arrow = By.Id("subscribe");
        By email = By.Id("susbscribe_email");

        public Subscription(IWebDriver driver)
        {
            this.driver = driver;
        }

        void enterEmail(string Einput)
        {
            typetext(email, Einput);
        }
        void clickArrow()
        {
            click(arrow);
        }

        public void subscription(string Email)
        {
            extent.AttachReporter(report);
            ExtentTest test = extent.CreateTest("T6_signup with register user");
            UnitTest1.log.Info("step1: Launch the Website ");
            OpenURL();
            UnitTest1.log.Info("Website launched successfully");
            UnitTest1.log.Info("scroll to an elemment");
            scroll(scrlelement);
            UnitTest1.log.Info("element is displayed");
            isElementDisplayed(subscriptionText);
            UnitTest1.log.Info("Enter email address");
            enterEmail(Email);
            UnitTest1.log.Info("click on arrow button");
            clickArrow();
            //isElementDisplayed();
            wait();
            //Taking a full - screen screenshot
            UnitTest1.log.Info("take screenshot and save ");
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile(@".\\Screenshot1.png", ScreenshotImageFormat.Png);
            extent.Flush();
        }
    }
}
