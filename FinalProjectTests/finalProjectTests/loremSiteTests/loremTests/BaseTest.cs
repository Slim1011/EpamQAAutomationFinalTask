using FinalProjectTests.finalProjectTests.loremSiteTests.loremPages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace FinalProjectTests
{
    public class BaseTests
    {
        private IWebDriver driver;
        private  const string _siteUrl = "https://lipsum.com/";
       
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(_siteUrl);  
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        public IWebDriver GetDriver()
        {
            return driver;
        }

        public HomePage GetHomePage()
        {
            return new HomePage(GetDriver());
        }

        public FeedPage GetFeedPage()
        {
            return new FeedPage(GetDriver());
        }
    }
}