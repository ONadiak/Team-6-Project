using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Project_Team_6.FrameWork;
using Project_Team_6.PageObjects;
using NUnit.Framework;
namespace Project_Team_6.Test
{
    public class SearchValidationTest : TestCase
    {
        public MainPageObject mainPage;

        [OneTimeSetUp]
        public void OneTimeSetUp() => mainPage = new MainPageObject(driver);
        [OneTimeTearDown]
        public void OneTimeTearDown() => driver.Quit();//видаляє exe



        [TestCase(false, "mug")]
        [TestCase(true, "plate")]

        public void Test(bool isPositive, string text)
        {
            AuthenticationPage authenticationPage = mainPage.ClickOnSearch();
            bool isOk = authenticationPage.EnterSearch(text).IsSearchOk();
            Assert.That(isOk, Is.EqualTo(isPositive),
                $"Search was validated{(isOk ? "successfully" : "unsuccessfully")}");
        }
    }
}
