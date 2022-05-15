using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationPractice
{
    internal class PaymentMethodPage : WebDriver
    {
        IWebElement confirm_btn = Driver.FindElement(By.CssSelector("#cart_navigation > button"));
        
        public void ClickConfirm()
        {
            confirm_btn.Click();
        }
        
    }
}
