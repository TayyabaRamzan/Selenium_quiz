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
    public class AddtoCart: CommonMethods
    {
         By image = By.XPath("//*[@id='header']/div/div/div/div[1]/div/a/img");
        By products = By.XPath("//*[@id='header']/div/div/div/div[2]/div/ul/li[2]/a");
        By text = By.XPath("/html/body/section[2]/div/div/div[2]/div");
        By product1 = By.XPath("(//i[@class='fa fa-shopping-cart'])[2]");
        By continues = By.XPath("//*[@id='cartModal']/div/div/div[3]/button");
        By product2 = By.XPath("(//i[@class='fa fa-shopping-cart'])[4]");
        By product3 = By.XPath("(//i[@class='fa fa-shopping-cart'])[6]");
        By viewCart = By.XPath("//*[@id='cartModal']/div/div/div[2]/p[2]/a/u");
        By verify1 = By.XPath("//*[@id='product-1']/td[2]/h4/a");
        By verify2 = By.XPath("//*[@id='product-2']/td[2]/h4/a");
        public AddtoCart(IWebDriver driver)
        {
            this.driver = driver;
        }

        void clickProduct()
        {
            click(products);
        }
        void addcart()
        {
            click(product1);
        }
        void addcart1()
        {
            click(product2);
        }
        void addcart2()
        {
            click(product3);
        }
        void clickcontinue()
        {
            click(continues);
        }
        void clickViewCart()
        {
            click(viewCart);
        }
        public void AdditemToCart()
        {
            extent.AttachReporter(report);
            ExtentTest test = extent.CreateTest("T4_Add To Cart");

            OpenURL();
            isElementDisplayed(image);
            clickProduct();
            scroll(text);
            addcart();
            wait();
            clickcontinue();
            wait();
            addcart1();
            wait();
            clickcontinue();
            addcart2();
            wait();
            clickViewCart();
            Assert.IsTrue(isElementDisplayed(verify1));
            Assert.IsTrue(isElementDisplayed(verify2));
            //extent.Flush();
            wait();
        }

    }
}
