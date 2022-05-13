using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace AutomationPractice
{
    class Tests : WebDriver
    {
        private string URL = "http://automationpractice.com/index.php";

        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl(URL);
        }

        [Test]
        public void Test_Registration()
        {
            HomePage homePage = new HomePage();
            homePage.GoToSignInPage();
            Thread.Sleep(5);
        }

        [TearDown]
        public void Close()
        {
            Driver.Close();
        }
    }
}