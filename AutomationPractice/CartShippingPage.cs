using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationPractice
{
    internal class CartShippingPage : WebDriver
    {
        IWebElement agreement_checkbox = Driver.FindElement(By.Id("cgv"));
        IWebElement checkout_btn = Driver.FindElement(By.CssSelector("#form > p > button"));

        public void ClickAgreementCheckbox()
        {
            agreement_checkbox.Click();
        }

        public void ClickShippingChechout()
        {
            checkout_btn.Click();
        }

    }
}
