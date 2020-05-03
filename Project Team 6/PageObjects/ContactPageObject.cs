using OpenQA.Selenium;
using PrestaShop.Services;

namespace Project_Team_6.PageObjects
{
    public class ContactPageObject : PageObject
    {
        private readonly By _emeilField =By.Name("from");
        private readonly By _helpField = By.XPath("//textarea[@class='form-control']");
        private readonly By _sendButton = By.XPath("//input[@class='btn btn-primary']");
        private readonly By _isSended = By.XPath("//div[@class='col-xs-12 alert alert-success']");
        public ContactPageObject(IWebDriver driver) : base(driver) { }

        public ContactPageObject SendingContactList()
        {
            Driver.FindElement(_emeilField).SendKeys(DataForTest.emeil);
            Driver.FindElement(_helpField).SendKeys(DataForTest.exemple);
            Driver.FindElement(_sendButton).Click();
            return this;
        }

        public string CheckIsSended()
        {
            WaitUntil.WaitElement(Driver, _isSended);
            string isSended =Driver.FindElement(_isSended).Text;
            return isSended;
        }
    }
}