using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
namespace Project_Team_6.PageObjects
{
    public class RowMenuPage : PageObject
    {
        private static readonly By createButtonClick = By.Id("category-3");
        public RowMenuPage(IWebDriver driver) : base(driver)
        { }
        public RowMenuPage ChangeLanguage()
        {
            Driver.FindElement(createButtonClick).Click();
            // Driver.FindElement(check).Click();
            // Driver.Manage().Timeouts().ImplicitWait = Settings.implicitWait;
            //Driver.FindElement(chengeLanguage).Click();
            return this;
        }
    }
}
