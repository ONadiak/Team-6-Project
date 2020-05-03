using System;
using Project_Team_6.PageObjects;

namespace PrestaShop.Services
{
    public class DataForTest
    {
        public static readonly TimeSpan implicitWait = TimeSpan.FromMilliseconds(3000);
        public static string Link { get; } = "http://52.177.12.77:8080/uk/";
        public static string ExpectedResultForAdded { get; } = "1 item";
        public static string ExpectedResultForAdded2 { get; } = "1 елемент";
        public static string ExpectedResultForRemoved { get; } = "У кошику більше не залишилось товарів";
        public static string ExpectedResultForRemoved2 { get; } = "There are no more items in your cart";
        public static string emeil { get; } = "nadiak@gmail.com";
        public static string exemple { get; } = "Exemple of ' What we can help you ";
        public static string IsSended { get; } = "Ваше повідомлення успішно надіслано.";
        public static readonly string url = "http://52.177.12.77:8080/uk/";


    }
}