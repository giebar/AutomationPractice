using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationPractice 
{
    internal class LoginPage : WebDriver
    {
        IWebElement signUp_btn = Driver.FindElement(By.Id("SubmitCreate"));
        IWebElement regEmail_input = Driver.FindElement(By.Id("email_create"));
        IWebElement loginEmail_input = Driver.FindElement(By.Id("email"));
        IWebElement loginPassword_input = Driver.FindElement(By.Id("passwd"));
        IWebElement signIn_btn = Driver.FindElement(By.Id("SubmitLogin"));

        public void EnterEmail(string email) {

            regEmail_input.SendKeys(email);
        }

        public void ClickSignUpBtn()
        {
            signUp_btn.Click();
        }

        public void EnterCredentialsAndLogin(string email2, string password)
        {
            loginEmail_input.SendKeys(email2);
            loginPassword_input.SendKeys(password);
            signIn_btn.Click();
        }
    }
}
