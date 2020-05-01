using OpenQA.Selenium;
using PrestaShop.Services;

namespace Project_Team_6.PageObjects
{
    public class ContactPageObject
    {
        private IWebDriver _webDriver;
        private readonly By _emeilField =By.Name("from");
        private readonly By _helpField = By.XPath("//textarea[@class='form-control']");
        private readonly By _sendButton = By.XPath("//input[@class='btn btn-primary']");
        private readonly By _isSended = By.XPath("//div[@class='col-xs-12 alert alert-success']");
        public ContactPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public ContactPageObject SendingContactList()
        {
            _webDriver.FindElement(_emeilField).SendKeys(UserNameForTest.emeil);
            _webDriver.FindElement(_helpField).SendKeys(UserNameForTest.exemple);
            _webDriver.FindElement(_sendButton).Click();
            return this;
        }

        public string CheckIsSended()
        {
            WaitUntil.WaitElement(_webDriver, _isSended);
            string isSended =_webDriver.FindElement(_isSended).Text;
            return isSended;
        }
    }
}