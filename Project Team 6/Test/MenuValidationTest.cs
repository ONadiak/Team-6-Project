using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Team_6.PageObjects;
using NUnit.Framework;
namespace Project_Team_6.Test
{
    class MenuValidationTest : TestCase
    {
        public MainPage mainPage;

        [OneTimeSetUp]
        public void OneTimeSetUp() => mainPage = new MainPage(driver);
        [OneTimeTearDown]
        public void OneTimeTearDown() => driver.Quit();//видаляє exe


        [TestCase()]
        public void NextTest()
        {
            RowMenuPage changeLanguagePage = mainPage.ClickOnButton();

        }

        static void Main(string[] args)
        {

        }
    }
}
