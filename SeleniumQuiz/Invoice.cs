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
    public class Invoice: CommonMethods
    {
        By image = By.XPath("//*[@id='header']/div/div/div/div[1]/div/a/img");
        By cartPage = By.XPath("//*[@id='cartModal']/div/div/div[2]/p[1]");
        By login_as_user = By.XPath("//*[@id='header']/div/div/div/div[2]/div/ul/li[10]/a/b");
        By text = By.XPath("/html/body/section[2]/div/div/div[2]/div");

        By scl = By.XPath("//*[@id='cart_items']/div/div[7]/a");
        By viewprod = By.XPath("/html/body/section[2]/div/div/div[2]/div/div[2]/div/div[2]/ul/li/a");
        By additem = By.XPath("/html/body/section/div/div/div[2]/div[2]/div[2]/div/span/button");
        By viewCart = By.XPath("//*[@id='cartModal']/div/div/div[2]/p[2]/a/u");

        By proceedCheckout = By.LinkText("Proceed To Checkout");
        By Register = By.XPath("//*[@id='checkoutModal']/div/div/div[2]/p[2]/a/u");


        
        By signUpButton = By.XPath("//li//a[@href='/login']");
        By name = By.XPath("//*[@id='form']/div/div/div[3]/div/form/input[2]");
        By email = By.XPath("//*[@id='form']/div/div/div[3]/div/form/input[3]");
        By signupbutton = By.XPath("//*[@id='form']/div/div/div[3]/div/form/button");
        By acc_created = By.XPath("//*[@id='form']/div/div/div/h2/b");

        By Mrs = By.Id("id_gender2");
        By pass = By.Id("password");
        By day = By.Id("days");
        By month = By.Id("months");
        By year = By.Id("years");

        By checkbox1 = By.Id("newsletter");
        By checkbox2 = By.Id("newsletter");

        By scrlelement = By.XPath("//p/label[@for='first_name']");
        By scrl2 = By.Id("mobile_number");

        By firstname = By.Id("first_name");
        By lastname = By.Id("last_name");
        By company = By.Id("company");
        By address1 = By.Id("address1");
        By address2 = By.Id("address2");

        By country = By.Id("country");
        By state = By.Id("state");
        By city = By.Id("city");
        By zipCode = By.Id("zipcode");
        By mobile = By.Id("mobile_number");
        By create = By.XPath("//*[@id='form']/div/div/div/div[1]/form/button");
        By continues = By.LinkText("Continue");

        By cart = By.XPath("//*[@id='header'']/div/div/div/div[2]/div/ul/li[3]/a/i");
        By Acc_details = By.XPath("//*[@id='address_delivery']/li[2]");

        By desc = By.XPath("//*[@id='ordermsg']/textarea");

        By name_on_card = By.Name("name_on_card");
        By card_number = By.Name("card_number");
        By cvc = By.Name("cvc");
        By exp_month = By.Name("expiry_month");
        By exp_year = By.Name("expiry-year");
        By P_C_Order = By.Id("submit");
        By orderPlaced = By.XPath("//*[@id='form']/div/div/div/h2/b");


        public Invoice(IWebDriver driver)
        {
            this.driver = driver;
        }

        
        void addproducttocart()
        {
            click(viewprod);
            click(additem);
        }

        void clickViewCart()
        {
            click(viewCart);
        }

        void clickProceedtoCheckout()
        {
            click(proceedCheckout);
        }
        void clickRegister()
        {
            click(Register);
        }
        void signUpClick()
        {

            click(signUpButton);

        }
        void inputName(string N_input)
        {
            typetext(name, N_input);
        }
        void inputEmail(string Einput)
        {
            typetext(email, Einput);
        }

        void signupclick()
        {
            click(signupbutton);

        }


        void selectMrs()
        {
            click(Mrs);
        }

        void inputpass(string Pinput)
        {
            typetext(pass, Pinput);
        }
        void selectday()
        {
            var drop = findElement(day);
            var selectdropdown = new SelectElement(drop);

            selectdropdown.SelectByValue("12");
        }
        void selectmonth()
        {
            var drop = findElement(month);
            var selectdropdown = new SelectElement(drop);

            selectdropdown.SelectByText("December");
        }
        void selectyear()
        {
            var drop = findElement(year);
            var selectdropdown = new SelectElement(drop);

            selectdropdown.SelectByValue("1999");
        }
        void selectcheckbox1()
        {
            click(checkbox1);
        }
        void selectcheckbox2()
        {
            click(checkbox2);
        }

        void enterfirstname(string Finput)
        {
            typetext(firstname, Finput);

        }
        void enterlastname(string Linput)
        {
            typetext(lastname, Linput);

        }
        void entercompany(string Cinput)
        {
            typetext(company, Cinput);

        }
        void enteraddress1(string Ainput)
        {
            typetext(address1, Ainput);

        }
        void enteraddress2(string Ainput)
        {
            typetext(address2, Ainput);

        }
        void entercountry()
        {
            var drop = findElement(country);
            var selectdropdown = new SelectElement(drop);

            selectdropdown.SelectByValue("Canada");


        }
        void enterstate(string Sinput)
        {
            typetext(state, Sinput);

        }
        void enterCity(string cinput)
        {
            typetext(city, cinput);

        }
        void enterZipcode(string Zinput)
        {
            typetext(zipCode, Zinput);

        }
        void enterMobile(string Minput)
        {
            typetext(mobile, Minput);

        }

        void clickcreateAccount()
        {
            click(create);
        }
        void clickContinue()
        {
            click(continues);
        }

        void clickcart()
        {
            click(cart);
        }
        void CommentDescription(string Dinput)
        {
            typetext(desc, Dinput);
        }
        void clickPlaceOrdr()
        {
            click(scl);
        }
        void EnternameOnCard(string Ninput)
        {
            typetext(name_on_card, Ninput);
        }
        void cardnumber(string Card)
        {
            typetext(card_number, Card);
        }
        void entecvc(string Card)
        {
            typetext(cvc, Card);
        }
        void expiryMonth(string Card)
        {
            typetext(exp_month, Card);
        }
        void expiryYear(string Card)
        {
            typetext(exp_year, Card);
        }
        void clickPayandConfirmOder()
        {
            click(P_C_Order);
        }
        


        public void downloadinvoice(string name, string email, string Password, string FirstName, string Lastname, string Company, string Adress1, string Adress2, string State, string City, string zipCode, string mobile)
        {
            extent.AttachReporter(report);
            ExtentTest test = extent.CreateTest("T3_Download invoice ");

            OpenURL();
            Assert.IsTrue(isElementDisplayed(image));
            scroll(text);
            addproducttocart();
            //Add Product to cart
            Assert.IsTrue(isElementDisplayed(cartPage));
            wait();
            clickViewCart();
            clickProceedtoCheckout();
            wait();
            clickRegister();
            inputName(name);
            inputEmail(email);
            signupclick();
            selectMrs();
            inputpass(Password);
            selectday();
            selectmonth();
            selectyear();

            selectcheckbox1();
            selectcheckbox2();
            scroll(scrlelement);

            enterfirstname(FirstName);
            enterlastname(Lastname);
            entercompany(Company);
            enteraddress1(Adress1);
            enteraddress2(Adress2);
            entercountry();
            enterstate(State);
            enterCity(City);
            enterZipcode(zipCode);
            enterMobile(mobile);
            scroll(scrl2);
            clickcreateAccount();

            //Assertion for ' Account created'
            Assert.IsTrue(isElementDisplayed(acc_created));
            clickContinue();

            //Verify Login as username is displayed
            Assert.IsTrue(isElementDisplayed(login_as_user));

            clickcart();
            clickProceedtoCheckout();

            //Verify address details
            Assert.IsTrue(isElementDisplayed(Acc_details));

            CommentDescription("Order is Confirmed");
            
            scroll(scl);
            clickPlaceOrdr();
            EnternameOnCard("tayyaba");
            cardnumber("14352673663637");
            entecvc("234");
            expiryMonth("12");
            expiryYear("2020");
            clickPayandConfirmOder();
            //Verify order is placed
            Assert.IsTrue(isElementDisplayed(orderPlaced));


            extent.Flush();
            wait();
            
        }

    }


}
