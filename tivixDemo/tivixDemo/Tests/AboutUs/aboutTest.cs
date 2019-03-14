using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using tivixDemo.PageObjects;

namespace tivixDemo.Tests.AboutUs
{
    class aboutTest
    {
        [Test]
        public void validAboutPageAfterEntrenceFromMainPage()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.tivix.com";

            var mainPage = new MainPage(driver);

            AboutPage aboutPage = mainPage.goToAboutPage();
            aboutPage.validAboutPage();
            driver.Close();
        }
    }
}
