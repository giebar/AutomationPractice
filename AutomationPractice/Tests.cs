using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace AutomationPractice
{
    class Tests : WebDriver
    {
        private string URL = "http://automationpractice.com/index.php";

        //registration data
        string reg_email = "khkknkymhni@gresgs.lt";

        //login data
        string login_email = "testas@testukas.lt";
        string login_password = "password";

        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl(URL);
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [Test]
        public void RegistrationTest()
        {
            HomePage homePage = new HomePage();
            homePage.GoToLoginPage();
            LoginPage loginPage = new LoginPage();
            loginPage.EnterEmail(reg_email);
            loginPage.ClickSignUpBtn();
            RegistrationPage registrationPage = new RegistrationPage();
            registrationPage.FillFormAndRegister();
            AccountPage accountPage = new AccountPage();
            Assert.AreEqual("My account", accountPage.GetPageName(), "Account was not created");
        }

        [Test]
        public void LoginTest()
        {
            HomePage homePage = new HomePage();
            homePage.GoToLoginPage();
            LoginPage loginPage = new LoginPage();
            loginPage.EnterCredentialsAndLogin(login_email, login_password);
            AccountPage accountPage = new AccountPage();
            Assert.AreEqual("Vardenis Pavardenis", accountPage.GetAccountName(), "Login was not successful");
        }

        [Test]
        public void SearchTest()
        {
            string searchedItem = "Printed Chiffon Dress";
            HomePage homePage = new HomePage();   
            homePage.SearchItem(searchedItem);
            SearchPage searchPage = new SearchPage();
            Assert.AreEqual(searchedItem, searchPage.GetProductName(), "Item was not found");
        }

        [Test]
        public void BuyItemTest()
        {
            HomePage homePage = new HomePage();
            homePage.SearchItem("Printed Chiffon Dress");
            SearchPage searchPage = new SearchPage();
            searchPage.ClickOnProduct();
            ProductPage productPage = new ProductPage();
            productPage.ClickAddTooCart();  
            productPage.ClickProceedToCheckout();
            CartSummaryPage cartSummaryPage = new CartSummaryPage();
            cartSummaryPage.ClickSummaryCheckout();
            LoginPage loginPage = new LoginPage();
            loginPage.EnterCredentialsAndLogin(login_email, login_password);
            CartAddressPage cartAddressPage = new CartAddressPage();
            cartAddressPage.ClickAddressCheckout();
            CartShippingPage cartShippingPage = new CartShippingPage();
            cartShippingPage.ClickAgreementCheckbox();
            cartShippingPage.ClickShippingChechout();
            CartPaymentPage cartPaymentPage = new CartPaymentPage();
            cartPaymentPage.ClickPaymentMethod();
            PaymentMethodPage paymentMethodPage = new PaymentMethodPage();
            paymentMethodPage.ClickConfirm();
            OrderConfirmationPage orderConfirmationPage = new OrderConfirmationPage();
            Assert.AreEqual("Your order on My Store is complete.", orderConfirmationPage.GetConfirmationMessage(), "Order was not completed");
        }

        [TearDown]
        public void Close()
        {
            Driver.Close();
        }
    }
}