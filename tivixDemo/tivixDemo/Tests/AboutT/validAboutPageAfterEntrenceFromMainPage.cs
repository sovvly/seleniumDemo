using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using tivixDemo.PageObjects;

namespace tivixDemo.Tests.AboutT
{
    class validAboutPageAfterEntrenceFromMainPage
    {
        private IWebDriver driver;

        [SetUp]
         public void startBrowser()
        {  
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\Users\yoursUserName\tivixDemo\tivixDemo\tivixDemo\", "geckodriver.exe");   
            service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
            driver = new FirefoxDriver(service);
            driver.Navigate().GoToUrl("https://www.tivix.com");
        }

        [Test]
        public void validAboutPageAfterEntrenceFromMainPageTest()
        {        

            var mainPage = new MainPage(driver);

            AboutPage aboutPage = mainPage.goToAboutPage();
            aboutPage.validAboutPage();
            driver.Close();
        }
    }
}
