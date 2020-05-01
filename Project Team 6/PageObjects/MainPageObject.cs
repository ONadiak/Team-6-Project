using OpenQA.Selenium;

namespace Project_Team_6.PageObjects
{
    public class MainPageObject
    {
        private IWebDriver _webDriver;
        private readonly By _tShirtImage = By.XPath("//a[@class = 'thumbnail product-thumbnail']");
        private readonly By _contactButton = By.Id("contact-link");
        
        

        public MainPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public TShirtPageObject ClickOnImageTShirt()
        {
            _webDriver.FindElement(_tShirtImage).Click();
            return new TShirtPageObject(_webDriver);
        }

        public ContactPageObject ClickOnContactButton()
        {
            _webDriver.FindElement(_contactButton).Click();
            return new ContactPageObject(_webDriver);
            
        }


       
    }
}