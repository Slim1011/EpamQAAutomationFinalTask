using FinalProjectTests.finalProjectTests.bbcSiteTests.bbcPages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace FinalProjectTests
{
    public class BaseTest

    {
        private IWebDriver driver;
        private const string _siteUrl = "https://www.bbc.com/news";

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

        public StoriesPage GetStoriesPage()
        {
            return new StoriesPage(GetDriver());
        }

        public CoronavirusPage GetCoronavirusPage()
        {
            return new CoronavirusPage(GetDriver());
        }

        public SportPage GetSportPage()
        {
            return new SportPage(GetDriver());
        }

        public FootballPage GetFootballPage()
        {
            return new FootballPage(GetDriver());
        }
    }
}