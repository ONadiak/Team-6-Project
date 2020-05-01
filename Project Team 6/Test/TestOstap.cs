using NUnit.Framework;
using PrestaShop.Services;
using Project_Team_6.PageObjects;

namespace PrestaShop
{
    [TestFixture]
    public class TestOstap : BaseTest 
    {
        [Test]
        public void TestIsTShirtAdded() 
        {
            var mainMenu = new MainPageObject(WebDriver);
            var orderMenu = new ShoppingCartPageObject(WebDriver);
            mainMenu
                .ClickOnImageTShirt()
                .AddToCart()
                .CheckIsTShirtAdded();
            string actualResult = orderMenu.CheckIsTShirtAdded();
            Assert.AreEqual(UserNameForTest.ExpectedResultForAdded2,actualResult, "Adding is wrong or wasn't completed");
        }

        [Test]
        public void TestIsOrderRemoved()
        {
            var mainMenu = new MainPageObject(WebDriver);
            var orderMenu = new ShoppingCartPageObject(WebDriver);
            mainMenu
                .ClickOnImageTShirt()
                .AddToCart()
                .RemoveOrder();
            string actualResult = orderMenu.CheckIsOrderRemoved();
            Assert.AreEqual(UserNameForTest.ExpectedResultForRemoved, actualResult,"Removing is wrong or wasn't completed");
        }

        [Test]
        public void TestSendingContactList()
        {
            var mainMenu = new MainPageObject(WebDriver);
            var orderMenu = new ContactPageObject(WebDriver);
            mainMenu
                .ClickOnContactButton()
                .SendingContactList();
            string actualResult = orderMenu.CheckIsSended();
            Assert.AreEqual(UserNameForTest.IsSended, actualResult, " Sending is wrong or wasn't completed ");

        }

    }
}