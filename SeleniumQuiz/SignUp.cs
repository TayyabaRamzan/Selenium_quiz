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

    public class SignUp : CommonMethods
    {


        By image = By.XPath("//*[@id='header']/div/div/div/div[1]/div/a/img");
        By newuser = By.XPath("//*[@id='form']/div/div/div[3]/div/h2");
        By acc_info = By.XPath("//*[@id='form']/div/div/div/div[1]/h2/b");
        By acc_created = By.XPath("//*[@id='form']/div/div/div/h2/b");
        By login_as_user = By.XPath("//*[@id='header']/div/div/div/div[2]/div/ul/li[10]/a/b");

        By signUpButton = By.XPath("//li//a[@href='/login']");
        By name = By.XPath("//*[@id='form']/div/div/div[3]/div/form/input[2]");
        By email = By.XPath("//*[@id='form']/div/div/div[3]/div/form/input[3]");
        By signupbutton = By.XPath("//*[@id='form']/div/div/div[3]/div/form/button");
        
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
        By message = By.XPath("//*[@id='form']/div/div/div[3]/div/form/p");
        public SignUp(IWebDriver driver)
        {
            this.driver = driver;
        }


        #region 
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
        #endregion

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

        public void signup(string name, string email,string Password, string FirstName, string Lastname, string Company, string Adress1, string Adress2, string State, string City, string zipCode, string mobile)
        {
            extent.AttachReporter(report);
            ExtentTest test = extent.CreateTest("T1_Register User");

            //Program.log.Info("Launch the Website ");
            OpenURL();
            //Assertion for homepage diplay
            Assert.IsTrue(isElementDisplayed(image));
            signUpClick();
            //Assertion for new user signup
            Assert.IsTrue(isElementDisplayed(newuser));
            inputName(name);
            inputEmail(email);
            signupclick();

            //Assertion for 'Enter Account Information'
            Assert.IsTrue(isElementDisplayed(acc_info));
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
            wait();
            extent.Flush();
        }
        public void signupregister(string name, string email)
        {
            extent.AttachReporter(report);
            ExtentTest test = extent.CreateTest("T6_signup with register user");

            OpenURL();
            Assert.IsTrue(isElementDisplayed(image));
            signUpClick();
            inputName(name);
            inputEmail(email);
            signupclick();
            Assert.IsTrue(isElementDisplayed(message));
            wait();
            extent.Flush();
        }
    }
}
