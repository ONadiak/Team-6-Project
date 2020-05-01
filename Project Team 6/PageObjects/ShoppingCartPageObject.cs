using OpenQA.Selenium;
using PrestaShop.Services;

namespace Project_Team_6.PageObjects
{
    public class ShoppingCartPageObject
    {
        private IWebDriver _webDriver;
        private readonly By _stringIsOrderAdded = By.XPath(" //span[@class = 'label js-subtotal']");
        private readonly By _removeButton = By.XPath(" //i[@class = 'material-icons float-xs-left']");
        private readonly By _stringIsOrderRemoved = By.XPath("//span[@class = 'no-items']");
        
        public string check;
        public ShoppingCartPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public string CheckIsTShirtAdded()
        {
            WaitUntil.WaitElement(_webDriver,_stringIsOrderAdded); 
            string srtingForCheck = _webDriver.FindElement(_stringIsOrderAdded).Text;
            
            return srtingForCheck;
        }

        public ShoppingCartPageObject RemoveOrder()
        {
            WaitUntil.WaitElement(_webDriver, _removeButton);
            _webDriver.FindElement(_removeButton).Click();
            return this;
        }

        public string CheckIsOrderRemoved()
        {
            WaitUntil.WaitElement(_webDriver,_stringIsOrderRemoved);
            string checkIsRemoved = _webDriver.FindElement(_stringIsOrderRemoved).Text;
            return checkIsRemoved;
        }


    }
}