using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
namespace Project_Team_6.PageObjects
{
    public abstract class PageObject
    {
        protected readonly IWebDriver Driver;
        public PageObject(IWebDriver driver) => Driver = driver;
    }
}
