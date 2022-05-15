using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationPractice
{
    internal class CartSummaryPage : WebDriver
    {
        IWebElement checkout_btn= Driver.FindElement(By.CssSelector("a.button.btn.btn-default.standard-checkout.button-medium"));
       
        public void ClickSummaryCheckout()
        {
            checkout_btn.Click();
        }
   
    }
}
