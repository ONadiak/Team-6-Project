using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PrestaShop.Services;
using Project_Team_6.PageObjects;

namespace PrestaShop
{
    public class BaseTest
    {
        protected IWebDriver WebDriver;

        [OneTimeSetUp]
        protected void DoBeforeAllTests()
        {
            WebDriver = new ChromeDriver();
            
        }
        
        [OneTimeTearDown]
        protected void DoAfterEach()
        {
            WebDriver.Quit();
        }

        [SetUp]
        protected void DoBeforeEach()
        {
            WebDriver.Manage().Cookies.DeleteAllCookies();
            WebDriver.Manage().Window.Maximize();
            WebDriver.Navigate().GoToUrl(DataForTest.Link);
            WaitUntil.ShouldLocate(WebDriver, DataForTest.Link);
        }

    }
}