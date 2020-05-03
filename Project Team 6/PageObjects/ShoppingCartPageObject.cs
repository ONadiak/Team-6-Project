using OpenQA.Selenium;
using PrestaShop.Services;

namespace Project_Team_6.PageObjects
{
    public class ShoppingCartPageObject: PageObject

    {
    
    private readonly By _stringIsOrderAdded = By.XPath(" //span[@class = 'label js-subtotal']");
    private readonly By _removeButton = By.XPath(" //i[@class = 'material-icons float-xs-left']");
    private readonly By _stringIsOrderRemoved = By.XPath("//span[@class = 'no-items']");

    public string check;

    public ShoppingCartPageObject(IWebDriver driver) : base(driver) { }

    public string CheckIsTShirtAdded()
    {
        WaitUntil.WaitElement(Driver, _stringIsOrderAdded);
        string srtingForCheck = Driver.FindElement(_stringIsOrderAdded).Text;

        return srtingForCheck;
    }

    public ShoppingCartPageObject RemoveOrder()
    {
        WaitUntil.WaitElement(Driver, _removeButton);
        Driver.FindElement(_removeButton).Click();
        return this;
    }

    public string CheckIsOrderRemoved()
    {
        WaitUntil.WaitElement(Driver, _stringIsOrderRemoved);
        string checkIsRemoved = Driver.FindElement(_stringIsOrderRemoved).Text;
        return checkIsRemoved;
    }


    }
}