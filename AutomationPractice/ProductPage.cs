using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationPractice
{
    internal class ProductPage : WebDriver
    {
        IWebElement addToCart_btn = Driver.FindElement(By.CssSelector("#add_to_cart > button"));
        IWebElement checkout_btn = Driver.FindElement(By.CssSelector("div.button-container > a"));

        public void ClickAddTooCart()
        {
            addToCart_btn.Click();
        }

        public void ClickProceedToCheckout()
        {
            checkout_btn.Click();
        }

    }
}
