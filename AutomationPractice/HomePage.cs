using OpenQA.Selenium;

namespace AutomationPractice
{
    internal class HomePage : WebDriver
    {
        IWebElement signIn_btn = Driver.FindElement(By.ClassName("login"));
        IWebElement search_input = Driver.FindElement(By.Id("search_query_top"));
        IWebElement search_btn = Driver.FindElement(By.ClassName("button-search"));
       
        public void GoToLoginPage()
        {
            signIn_btn.Click();
        }

        public void SearchItem(string searchedItem)
        {
            search_input.SendKeys(searchedItem);
            search_btn.Click();
            
        }
    }
}
