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
            Assert.AreEqual("Tutu.ru: ����, ��, ������ �� ������� � ���� ������. ��������� ��������������� ������� � ����������, ���� �� 2024 ���, ����� �/� �������, �����������, ����� � ������� �� ��������.", webDriver.Title);
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
            Assert.AreEqual("����� ������", buttonText);

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









