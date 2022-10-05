using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;

namespace SeleniumQuiz
{
    [TestClass]
    public class UnitTest1 : CommonMethods
    {

        public TestContext instance;

        public TestContext TestContext { get; set; }


        [TestInitialize]
        public void testinit()
        {
            startBrowser();

        }
        [TestCleanup]

        public void Testclean()
        {
            //closebrowser();
            QuitBrowser();
        }


        //[TestCategory("SignUp")]
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Quizdatafile.xml", "signupforvalid", DataAccessMethod.Sequential)]
        public void T1_RegisterUser()
        {

            SignUp ss = new SignUp(driver);

            string entername = TestContext.DataRow["name"].ToString();
            string emailaddress = TestContext.DataRow["email"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string firstname = TestContext.DataRow["firstname"].ToString();
            string lastname = TestContext.DataRow["lastname"].ToString();
            string Company = TestContext.DataRow["Company"].ToString();
            string Adress1 = TestContext.DataRow["Adress1"].ToString();
            string Adress2 = TestContext.DataRow["Adress2"].ToString();
            string State = TestContext.DataRow["State"].ToString();
            string City = TestContext.DataRow["City"].ToString();
            string zipCode = TestContext.DataRow["zipCode"].ToString();
            string mobile = TestContext.DataRow["mobile"].ToString();
            ss.signup(entername,emailaddress,password,firstname,lastname, Company, Adress1, Adress2, State, City, zipCode, mobile);
            //ExtentTest test = extent.CreateTest("FYP_T1_Verify sign up button is clickable and functional");

        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Quizdatafile.xml", "subscription", DataAccessMethod.Sequential)]
        public void T2_verifySubscriptionInHomePage()
        {

            Subscription ss = new Subscription(driver);
            string emailaddress = TestContext.DataRow["Emailid"].ToString();
            ss.subscription(emailaddress);

        }
        [TestMethod]

        public void T3_DownloadInvoiceAfterPurchaseOrder()
        {

            Invoice ss = new Invoice(driver);

            ss.downloadinvoice("Tayyaba", "tayyabaramzan111@gmail.com", "tayyaba123", "tayyaba", "Ramzan", "Contour", "Askari", "Askari2", "Pakistan", "Lahore", "54000", "030765654343");
        }

        [TestMethod]
        
        public void T4_AddProductsInCart()
        {

            AddtoCart ss = new AddtoCart(driver);
            ss.AdditemToCart();
            

        }
        //[TestMethod]
        //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Quizdatafile.xml", "subscription", DataAccessMethod.Sequential)]
        //public void T5_RegisterwhileCheckout()
        //{

        //    Invoice ss = new Invoice(driver);
        //    string emailaddress = TestContext.DataRow["Emailid"].ToString();
        //    ss.downloadinvoice();

        //}
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Quizdatafile.xml", "signupwithregisteresEmail", DataAccessMethod.Sequential)]
        public void T6_RegisterUserwithExistingEmail()
        {

            SignUp ss = new SignUp(driver);

            string entername = TestContext.DataRow["name"].ToString();
            string emailaddress = TestContext.DataRow["email"].ToString();
            
            ss.signupregister(entername, emailaddress);
            

        }
        [TestMethod]
        public void T7_ScrollUpandScrollDown()
        {

            ScrollUpDown obj = new ScrollUpDown(driver);
            obj.scrollUpandDown();


        }
    }
}

