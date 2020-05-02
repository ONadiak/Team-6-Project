using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Project_Team_6.FrameWork;

namespace Project_Team_6.PageObjects
{
    public class AuthenticationPage : PageObject
    {
        private static readonly By createSearchInput = By.XPath("//input[@name='s']");
        private static readonly By IsSearch = By.XPath("//section[@class='page-content page-not-found']");
        public AuthenticationPage(IWebDriver driver) : base(driver)
        { }
        public AuthenticationPage EnterSearch(string text)
        {
            //Driver.FindElement(createSearchInput).Click();
            Driver.FindElement(createSearchInput).SendKeys(text);
            Driver.FindElement(createSearchInput).SendKeys(Keys.Enter);
            Driver.FindElement(createSearchInput).Clear();
            return this;
        }
        public bool IsSearchOk()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.Zero;
            bool isOk = Wait.WaitFor(() => Driver.FindElements(IsSearch).Any());
            Driver.Manage().Timeouts().ImplicitWait = Settings.implicitWait;
            return isOk;
        }
    }
}
