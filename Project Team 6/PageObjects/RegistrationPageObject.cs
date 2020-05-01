using OpenQA.Selenium;

namespace Project_Team_6.PageObjects
{
    public class RegistrationPageObject
    {
        private IWebDriver _webDriver;
        

        public RegistrationPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
    }
}