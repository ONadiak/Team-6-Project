using OpenQA.Selenium;

namespace Project_Team_6.PageObjects
{
    public class AuthorizationPageObject
    {
        private IWebDriver _webDriver;
        

        public AuthorizationPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
    }
}