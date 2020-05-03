using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using PrestaShop.Services;
using Project_Team_6.FrameWork;

namespace Project_Team_6.Test
{
    public abstract class TestCase
    {
        protected IWebDriver driver;
        protected TestCase()
        {
            driver = Selenium.GetDriver(Drivers.Chrome);
            driver.Navigate().GoToUrl(DataForTest.url);
        }

    }
}
