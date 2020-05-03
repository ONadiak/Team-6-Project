using OpenQA.Selenium;
using PrestaShop.Services;

namespace Project_Team_6.PageObjects
{
    public class TShirtPageObject : PageObject

    {
        private readonly By _addToCartButton = By.XPath("//button[@class = 'btn btn-primary add-to-cart']");
    private readonly By _proceedButton = By.XPath(" //a[@class = 'btn btn-primary']");

    public TShirtPageObject(IWebDriver driver) : base(driver) { }

    public ShoppingCartPageObject AddToCart()
    {
        Driver.FindElement(_addToCartButton).Click();
        WaitUntil.WaitElement(Driver, _proceedButton);
        Driver.FindElement(_proceedButton).Click();
        return new ShoppingCartPageObject(Driver);
    }

    }
}