using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationPractice
{
    internal class RegistrationPage : WebDriver
    {
        IWebElement customerName_input = Driver.FindElement(By.Id("customer_firstname"));
        IWebElement customerSurname_input = Driver.FindElement(By.Id("customer_lastname"));
        IWebElement password_input = Driver.FindElement(By.Id("passwd"));
        IWebElement address_input = Driver.FindElement(By.Id("address1"));
        IWebElement city_input = Driver.FindElement(By.Id("city"));
        IWebElement state_dropdown = Driver.FindElement(By.Id("id_state"));
        IWebElement state_option = Driver.FindElement(By.CssSelector("#id_state > option:nth-child(2)"));
        IWebElement postcode_input = Driver.FindElement(By.Id("postcode"));
        IWebElement phone_input = Driver.FindElement(By.Id("phone_mobile"));
        IWebElement register_btn = Driver.FindElement(By.Id("submitAccount"));

        string customerName = "Vardenis";
        string customerSurname = "Pavardenis";
        string password = "password";
        string address = "address";
        string city = "city";
        string postcode = "12345";
        string phone = "12345678";

        public void FillFormAndRegister()
        {
            customerName_input.SendKeys(customerName);
            customerSurname_input.SendKeys(customerSurname);
            password_input.SendKeys(password);
            address_input.SendKeys(address);
            city_input.SendKeys(city);
            state_dropdown.Click();
            state_option.Click();
            postcode_input.SendKeys(postcode);
            phone_input.SendKeys(phone);
            register_btn.Click();
        }

    }
}
