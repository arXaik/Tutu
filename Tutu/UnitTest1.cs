using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace Tutu
{
    [TestFixture]
    public class Tests
    {
        IWebDriver webDriver = new ChromeDriver();
        [TestCase]
        public void mainTitle()
        {
            webDriver.Url = "https://www.tutu.ru/";
            Assert.AreEqual("Tutu.ru: Авиа, ЖД, билеты на автобус и туры онлайн. Стоимость железнодорожных билетов и расписание, цены на 2024 год, заказ ж/д билетов, авиабилетов, туров и билетов на автобусы.", webDriver.Title);
            webDriver.Close();
        }
        [TearDown]
        public void tearEnd()
        {
            webDriver.Quit();
        }
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void TestSuccessfulBooking()
        {
            driver.Navigate().GoToUrl("https://www.tutu.ru/");
            IWebElement button = driver.FindElement(By.ClassName("inner_wrapper"));
            string buttonText = button.Text;
            Assert.AreEqual("Найти билеты", buttonText);

        }

        [Test]
        public void TestEventSearch()
        {
            driver.Navigate().GoToUrl("https://www.tutu.ru/");

        }


        [TearDown]
        public void Cleanup()
        {
            driver.Quit();
        }
    }

}









