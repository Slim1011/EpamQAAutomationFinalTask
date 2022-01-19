using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectTests.finalProjectTests.bbcSiteTests.bbcPages
{
    public class FootballPage : BasePage
    {
        public FootballPage(IWebDriver driver) : base(driver)
        {

        }

        [FindsBy(How = How.XPath, Using = "//a[@data-stat-title='Scores & Fixtures']")]
        private IWebElement _scoresAndFixturesButtonInFootballMenu;

        [FindsBy(How = How.XPath, Using = "//input[@id='downshift-0-input']")]
        private IWebElement _searchInput;

        [FindsBy(How = How.XPath, Using = "(//a[@class='sp-c-search__result-item'])[1]")]
        private IWebElement _firstSearchResult;

        [FindsBy(How = How.XPath, Using = "//a[@class='sp-c-date-picker-timeline__item-inner  false']")]
        private IList<IWebElement> _monthsAndYears;

        [FindsBy(How = How.XPath, Using = "(//div[@class='sp-c-fixture__wrapper'])[1]")]
        private IWebElement _firstSearchResultAccordingMonth;

        [FindsBy(How = How.XPath, Using = "(//span[@class='sp-c-fixture__team-name sp-c-fixture__team-name--home'])[1]")]
        private IWebElement _nameOfFirstTeam;

        [FindsBy(How = How.XPath, Using = "(//div[@class='sp-c-fixture__wrapper'])[1]")]
        private IWebElement _gameResultAtTheCenterOfTheScreen;


        public void ClickScoresAndFixturesButtonInFootballMenu()
        {
            _scoresAndFixturesButtonInFootballMenu.Click();
        }

        public void SendKeysToSearchInput(string searchPhraze)
        {
            _searchInput.SendKeys(searchPhraze);
        }

        public void ChooseFirstSearchResult()
        {
            _firstSearchResult.SendKeys(Keys.Enter);
        }
        public IWebElement GetMonthAndYearButton(int year, string month)
        {
            return _monthsAndYears.Where(date => date.Text.Contains(month) && date.Text.Contains(year.ToString())).FirstOrDefault();
        }

        public IWebElement GetFirstSearchResultAccordingMonth()
        {
            return _firstSearchResultAccordingMonth;
        }

        public string GetTextFromFirstSearchResultAccordingMonth()
        {
            return _firstSearchResultAccordingMonth.Text;
        }

        public void ClickOnNameOfFirstTeam()
        {
            _nameOfFirstTeam.Click();
        }

        public string GetTextFromGameResultAtTheCenterOfTheScreenh()
        {
            return _gameResultAtTheCenterOfTheScreen.Text;
        }


    }
}
