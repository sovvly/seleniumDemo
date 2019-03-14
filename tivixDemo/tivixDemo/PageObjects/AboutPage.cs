using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace tivixDemo.PageObjects
{
    class AboutPage
    {
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//div/button[@class = 'tivix - button']")]
        private IWebElement joinOutTeamBtn;

        [FindsBy(How = How.XPath, Using = "//div/p[text()='YEAR FOUNDED']")]
        private IWebElement yearFoundedLbl;

        [FindsBy(How = How.XPath, Using = "//div/p[text()='TALENTED EMPLOYEES']")]
        private IWebElement talentedLbl;

        [FindsBy(How = How.XPath, Using = "//div/p[text()='OFFICES WORLDWIDE']")]
        private IWebElement officesLbl;

        public AboutPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void validAboutPage()
        {
            Assert.True(joinOutTeamBtn.Displayed, "Missing join our team button");
            Assert.True(yearFoundedLbl.Displayed, "Missing year founded label");
            Assert.True(talentedLbl.Displayed, "Missing talented emploees label");
            Assert.True(officesLbl.Displayed, "Missing offices worldwide label");
        }
    }


}