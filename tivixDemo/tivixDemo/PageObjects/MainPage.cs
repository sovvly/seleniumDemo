using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace tivixDemo.PageObjects
{
    class MainPage
    {
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//a/li/span[text()='services']")]
        private IWebElement servicesBtn;

        [FindsBy(How = How.XPath, Using = "//a/li/span[text()='case studies']")]
        private IWebElement caseStudiesBn;

        [FindsBy(How = How.XPath, Using = "//a/li/span[text()='about']")]
        private IWebElement aboutBtn;

        [FindsBy(How = How.XPath, Using = "//a/li/span[text()='blog']")]
        private IWebElement blogBtn;

        [FindsBy(How = How.XPath, Using = "//a/li/span[text()='resources']")]
        private IWebElement resourcesBtn;

        [FindsBy(How = How.XPath, Using = "//a/li/span[text()='carriers']")]
        private IWebElement carriersBtn;

        [FindsBy(How = How.XPath, Using = "//a/li/span[text()='contact']")]
        private IWebElement contactBtn;

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public AboutPage goToAboutPage()
        {
            aboutBtn.Click();
            return new AboutPage(driver);
        }
    }
}
