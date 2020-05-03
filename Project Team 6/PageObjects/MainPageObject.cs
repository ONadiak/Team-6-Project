using OpenQA.Selenium;

namespace Project_Team_6.PageObjects
{
    public class MainPageObject: PageObject

    {
    
    private readonly By _tShirtImage = By.XPath("//a[@class = 'thumbnail product-thumbnail']");
    private readonly By _contactButton = By.Id("contact-link");
    private static readonly By searchLine = By.XPath("//input[@name='s']");
    private static readonly By buttonClick = By.Id("category-3");
    private static readonly By check = By.Id("category-6");
    private static readonly By nextCheck = By.Id("category-9");
    private static readonly By logoClick = By.Id("_desktop_logo");
    private static readonly By createButtonClick = By.Id("category-3");


    public MainPageObject(IWebDriver driver) : base(driver) { }
    //public MainPageObject(IWebDriver webDriver)
    // {
    //    _webDriver = webDriver;
    //}

    public TShirtPageObject ClickOnImageTShirt()
    {
        Driver.FindElement(_tShirtImage).Click();
        return new TShirtPageObject(Driver);
    }

    public ContactPageObject ClickOnContactButton()
    {
        Driver.FindElement(_contactButton).Click();
        return new ContactPageObject(Driver);

    }
    public AuthenticationPage ClickOnSearch()
    {
        Driver.FindElement(searchLine).Click();
        return new AuthenticationPage(Driver);
    }
    public MainPageObject ClickOnButton()
    {

        Driver.FindElement(buttonClick).Click();
        Driver.FindElement(check).Click();
        Driver.FindElement(nextCheck).Click();
        Driver.FindElement(logoClick).Click();
        return new MainPageObject(Driver);
    }
    public MainPageObject ChangeLanguage()
    {
        Driver.FindElement(createButtonClick).Click();
        // Driver.FindElement(check).Click();
        // Driver.Manage().Timeouts().ImplicitWait = Settings.implicitWait;
        //Driver.FindElement(chengeLanguage).Click();
        return this;
    }



    }
}