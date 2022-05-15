using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationPractice
{
    internal class AccountPage : WebDriver
    {
        IWebElement navigationPageName = Driver.FindElement(By.ClassName("navigation_page"));
        IWebElement accountName = Driver.FindElement(By.CssSelector("#header > div.nav > div > div > nav > div:nth-child(1) > a > span"));

        public string GetPageName()
        {     
            return navigationPageName.Text; 
        }

        public string GetAccountName()
        {
            return accountName.Text;
        }

    }
}
