using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationPractice
{
    internal class SearchPage : WebDriver
    {
        IWebElement productName = Driver.FindElement(By.CssSelector("#center_column > ul > li.ajax_block_product.col-xs-12.col-sm-6.col-md-4.first-in-line.last-line.first-item-of-tablet-line.first-item-of-mobile-line.last-mobile-line > div > div.right-block > h5 > a"));
        IWebElement product_container = Driver.FindElement(By.ClassName("product-container"));

        public string GetProductName()
        {
            return productName.Text;
        }

        public void ClickOnProduct()
        {
            product_container.Click();
        }
 
    }
}
