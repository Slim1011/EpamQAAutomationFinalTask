using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectTests.finalProjectTests.bbcSiteTests.bbcTests
{
    class CheckOfArticleTitlesPresenceTests : BaseTest
    {
        private const string NameOfHeadlineArticle = "Theranos founder Elizabeth Holmes guilty of fraud";
        private const string NameOfFirstArticleOnStoriesPageBySearch = "Stories for Collective Worship";
        private readonly List<string> ExpectedNamesOfSecondaryArticles = new List<string>() {"Biden and Putin phone call seeks 'diplomatic path'", "Omicron and Delta driving case tsunami - WHO",
        "Protesters set Australia's old parliament on fire", "Elon Musk rejects claim he is hogging space", "'Icemageddon' warnings follow Alaska heat record"};
        private const int TimeToWait = 10;


        [Test]
        public void CheckThatNameOfHeadlineArticleIsCorrect()
        {
            GetHomePage().ClickOnNewsButton();
            Assert.AreEqual(NameOfHeadlineArticle, GetHomePage().GetTextFromFromHeadlineArticleName());
        }

        [Test]
        public void CheckThatSecondaryArticleTitlesIsCorrect()
        {
            GetHomePage().ClickOnNewsButton();
            GetHomePage().WaitVisibilityOfElement(TimeToWait, GetHomePage().GetSecondaryArticleTitles());
            Assert.AreEqual(ExpectedNamesOfSecondaryArticles, GetHomePage().GetListOfSecondaryAricleNames());
        }

        [Test]
        public void CheckThatNameOfFirstArticleFromChoosenCategoryIsCorrect()
        {
            GetHomePage().ClickOnNewsButton();
            GetHomePage().InputSearchWordIntoSearchBarAndClickSearchButton(GetHomePage().GetTextFromCategoryButtonName(GetHomePage().GetStoriesCategoryButton()));
            Assert.AreEqual(NameOfFirstArticleOnStoriesPageBySearch, GetStoriesPage().GetNameFromfirstArticleFromStoriesPageBySearching());

        }
    }
}
