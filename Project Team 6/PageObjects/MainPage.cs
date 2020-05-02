using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;


namespace Project_Team_6.PageObjects
{
    public class MainPage : PageObject
    {
        private static readonly By searchLine = By.XPath("//input[@name='s']");
        private static readonly By buttonClick = By.Id("category-3");
        private static readonly By check = By.Id("category-6");
        private static readonly By nextCheck = By.Id("category-9");
        private static readonly By logoClick = By.Id("_desktop_logo");
        public MainPage(IWebDriver driver) : base(driver) { }
        public AuthenticationPage ClickOnSearch()
        {
            Driver.FindElement(searchLine).Click();
            return new AuthenticationPage(Driver);
        }
        public RowMenuPage ClickOnButton()
        {

            Driver.FindElement(buttonClick).Click();
            Driver.FindElement(check).Click();
            Driver.FindElement(nextCheck).Click();
            Driver.FindElement(logoClick).Click();
            return new RowMenuPage(Driver);
        }
    }
}
