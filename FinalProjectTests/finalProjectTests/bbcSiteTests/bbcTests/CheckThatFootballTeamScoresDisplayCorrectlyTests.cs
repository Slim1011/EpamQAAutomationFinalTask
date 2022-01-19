using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FinalProjectTests.finalProjectTests.bbcSiteTests.bbcTests
{
    class CheckThatFootballTeamScoresDisplayCorrectlyTests : BaseTest
    {
        private const int TimeToWait = 10;

        [Test]
        public void CheckThatFootballTeamScoresDisplayCorrectly1()
        {
            GetHomePage().ClicksportButtonInMenu();
            GetSportPage().ClickfootballButtonInSportMenu();
            GetFootballPage().ClickScoresAndFixturesButtonInFootballMenu();
            GetFootballPage().SendKeysToSearchInput("EFL Cup");
            GetFootballPage().ChooseFirstSearchResult();
            GetFootballPage().GetMonthAndYearButton(2021, "OCT").Click();
            GetFootballPage().WaitVisibilityOfElement(TimeToWait, GetFootballPage().GetFirstSearchResultAccordingMonth());
            string game = GetFootballPage().GetTextFromFirstSearchResultAccordingMonth();
            Assert.IsTrue(game.Contains("Burnley") && game.Contains("Tottenham Hotspur") && game.Contains("0") && game.Contains("1"));
            GetFootballPage().ClickOnNameOfFirstTeam();
            string gameResultInTheCenter = GetFootballPage().GetTextFromGameResultAtTheCenterOfTheScreenh();
            Assert.IsTrue(gameResultInTheCenter.Contains("Burnley") && gameResultInTheCenter.Contains("Tottenham Hotspur") 
                && gameResultInTheCenter.Contains("0") && gameResultInTheCenter.Contains("1"));

        }

        [Test]
        public void CheckThatFootballTeamScoresDisplayCorrectly2()
        {
            GetHomePage().ClicksportButtonInMenu();
            GetSportPage().ClickfootballButtonInSportMenu();
            GetFootballPage().ClickScoresAndFixturesButtonInFootballMenu();
            GetFootballPage().SendKeysToSearchInput("Scottish Championship");
            GetFootballPage().ChooseFirstSearchResult();
            GetFootballPage().GetMonthAndYearButton(2021, "NOV").Click();
            GetFootballPage().WaitVisibilityOfElement(TimeToWait, GetFootballPage().GetFirstSearchResultAccordingMonth());
            string game = GetFootballPage().GetTextFromFirstSearchResultAccordingMonth();
            Assert.IsTrue(game.Contains("Dunfermline") && game.Contains("Ayr United") && game.Contains("3") && game.Contains("0"));
            GetFootballPage().ClickOnNameOfFirstTeam();
            string gameResultInTheCenter = GetFootballPage().GetTextFromGameResultAtTheCenterOfTheScreenh();
            Assert.IsTrue(gameResultInTheCenter.Contains("Dunfermline") && gameResultInTheCenter.Contains("Ayr United")
                && gameResultInTheCenter.Contains("3") && gameResultInTheCenter.Contains("0"));

        }

        [Test]
        public void CheckThatFootballTeamScoresDisplayCorrectly3()
        {
            GetHomePage().ClicksportButtonInMenu();
            GetSportPage().ClickfootballButtonInSportMenu();
            GetFootballPage().ClickScoresAndFixturesButtonInFootballMenu();
            GetFootballPage().SendKeysToSearchInput("Scottish Championship");
            GetFootballPage().ChooseFirstSearchResult();
            GetFootballPage().GetMonthAndYearButton(2021, "AUG").Click();
            GetFootballPage().WaitVisibilityOfElement(TimeToWait, GetFootballPage().GetFirstSearchResultAccordingMonth());
            string game = GetFootballPage().GetTextFromFirstSearchResultAccordingMonth();
            Assert.IsTrue(game.Contains("Dunfermline") && game.Contains("Arbroath") && game.Contains("0") && game.Contains("3"));
            GetFootballPage().ClickOnNameOfFirstTeam();
            string gameResultInTheCenter = GetFootballPage().GetTextFromGameResultAtTheCenterOfTheScreenh();
            Assert.IsTrue(gameResultInTheCenter.Contains("Dunfermline") && gameResultInTheCenter.Contains("Arbroath")
                && gameResultInTheCenter.Contains("0") && gameResultInTheCenter.Contains("3"));

        }

        [Test]
        public void CheckThatFootballTeamScoresDisplayCorrectly4()
        {
            GetHomePage().ClicksportButtonInMenu();
            GetSportPage().ClickfootballButtonInSportMenu();
            GetFootballPage().ClickScoresAndFixturesButtonInFootballMenu();
            GetFootballPage().SendKeysToSearchInput("EFL Cup");
            GetFootballPage().ChooseFirstSearchResult();
            GetFootballPage().GetMonthAndYearButton(2021, "DEC").Click();
            GetFootballPage().WaitVisibilityOfElement(TimeToWait, GetFootballPage().GetFirstSearchResultAccordingMonth());
            string game = GetFootballPage().GetTextFromFirstSearchResultAccordingMonth();
            Assert.IsTrue(game.Contains("Brentford") && game.Contains("Chelsea") && game.Contains("0") && game.Contains("2"));
            GetFootballPage().ClickOnNameOfFirstTeam();
            string gameResultInTheCenter = GetFootballPage().GetTextFromGameResultAtTheCenterOfTheScreenh();
            Assert.IsTrue(gameResultInTheCenter.Contains("Brentford") && gameResultInTheCenter.Contains("Chelsea")
                && gameResultInTheCenter.Contains("0") && gameResultInTheCenter.Contains("2"));

        }

    }
}
