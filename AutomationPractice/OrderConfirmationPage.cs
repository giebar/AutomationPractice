using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationPractice
{
    internal class OrderConfirmationPage : WebDriver
    {
        IWebElement confirmationMessage = Driver.FindElement(By.CssSelector("#center_column > div > p > strong"));
        
        public string GetConfirmationMessage()
        {
            return confirmationMessage.Text;
        }

    }
}
