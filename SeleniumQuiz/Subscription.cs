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
            ExtentTest test = extent.CreateTest("T2_verify subscription");


            Program.log.Info("step1: Launch the Website ");
            OpenURL();
            Program.log.Info("Website launched successfully");
            Program.log.Info("scroll to an elemment");
            scroll(scrlelement);
            Program.log.Info("element is displayed");
            
            isElementDisplayed(subscriptionText);
            Program.log.Info("Enter email address");
            enterEmail(Email);
            Program.log.Info("click on arrow button");
            clickArrow();
            //isElementDisplayed();
            wait();
            //Taking a full - screen screenshot
            Program.log.Info("Take screenshot and save ");
            Screenshot();
            //extent.Flush();
        }
    }
}
