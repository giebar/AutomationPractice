using OpenQA.Selenium;

namespace AutomationPractice
{
    internal class HomePage : WebDriver
    {
        IWebElement signIn_btn = Driver.FindElement(By.ClassName("header_user_info"));
       
        public void GoToSignInPage()
        {
            signIn_btn.Click();
        }
    }
}
