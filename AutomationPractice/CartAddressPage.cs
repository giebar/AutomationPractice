using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationPractice
{
    internal class CartAddressPage : WebDriver
    {
        IWebElement checkout_btn = Driver.FindElement(By.CssSelector("#center_column > form > p > button"));

        public void ClickAddressCheckout()
        {
            checkout_btn.Click();
        }

    }
}
