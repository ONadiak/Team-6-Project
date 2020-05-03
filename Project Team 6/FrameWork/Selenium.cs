using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PrestaShop.Services;

namespace Project_Team_6.FrameWork
{
    public static class Selenium
    {
        public static IWebDriver GetDriver(Drivers drivers)
        {
            switch (drivers)
            {
                case Drivers.Chrome:
                default:
                    return GetChromeDriver();
            }
        }
        private static IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = DataForTest.implicitWait;
            return driver;
        }

    }
    public enum Drivers
    {
        Chrome,
    }
}
