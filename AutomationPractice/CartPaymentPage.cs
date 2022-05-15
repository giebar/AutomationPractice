using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationPractice
{
    internal class CartPaymentPage : WebDriver
    {
        IWebElement payByBankwire_btn = Driver.FindElement(By.ClassName("bankwire"));
        
        public void ClickPaymentMethod()
        {
            payByBankwire_btn.Click();
        }

    }
}
