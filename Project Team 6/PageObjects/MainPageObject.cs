using OpenQA.Selenium;

namespace Project_Team_6.PageObjects
{
    public class MainPageObject
    {
        private IWebDriver _webDriver;
        

        public MainPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }


       
    }
}