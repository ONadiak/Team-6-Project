using OpenQA.Selenium;
using PrestaShop.Services;

namespace Project_Team_6.PageObjects
{
    public class TShirtPageObject
    {
        private IWebDriver _webDriver;
        private readonly By _addToCartButton = By.XPath("//button[@class = 'btn btn-primary add-to-cart']");
        private readonly By _proceedButton = By.XPath(" //a[@class = 'btn btn-primary']");

        public TShirtPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }


        public ShoppingCartPageObject AddToCart()
        {
            _webDriver.FindElement(_addToCartButton).Click();
            WaitUntil.WaitElement(_webDriver,_proceedButton);
            _webDriver.FindElement(_proceedButton).Click();
            return new ShoppingCartPageObject(_webDriver);
        }

    }
}