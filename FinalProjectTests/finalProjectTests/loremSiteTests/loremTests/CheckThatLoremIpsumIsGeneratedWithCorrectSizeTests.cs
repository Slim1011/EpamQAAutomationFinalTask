using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectTests.finalProjectTests.loremSiteTests.loremTests
{
    class CheckThatLoremIpsumIsGeneratedWithCorrectSizeTests : BaseTests
    {
        private readonly int[] numbersOfGeneratedWords = { 10, -1, 0, 5, 20};
        private readonly int[] numbersForWordsVerification = { 10, 5, 5, 5, 20};
        private readonly int countOfWordsChecks = 5;
        private readonly int[] numbersOfGeneratedBytes = { 15, 0, -2, 35 };
        private readonly int[] numbersForBytesVerification = { 15, 5, 5, 35 };
        private readonly int countOfBytesChecks = 4;
        [Test]
        public void CheckThatLoremIpsumGeneratedWithCorrectNumbersOfWords()
        {
            GetHomePage().ClickOnWordsRadioButton();
            for (int i = 0; i < countOfWordsChecks; i++)
            { 
                GetHomePage().InputQuantiryIntoNumberFieldAndClickGenerateButton(numbersOfGeneratedWords[i]);
                Assert.AreEqual(numbersForWordsVerification[i], GetFeedPage().GetNumberOfGeneratedWords());
                GetFeedPage().GoBackFromFeedPageToHomePage();

            }
        }

        [Test]
        public void CheckThatLoremIpsumGeneratedWithCorrectNumbersOfBytes()
        {
            GetHomePage().ClickOnBytesRadioButton();
            for (int i = 0; i < countOfBytesChecks; i++)
            {
                GetHomePage().InputQuantiryIntoNumberFieldAndClickGenerateButton(numbersOfGeneratedBytes[i]);
                Assert.AreEqual(numbersForBytesVerification[i], GetFeedPage().GetNumberOfGeneratedBytes());
                GetFeedPage().GoBackFromFeedPageToHomePage();
            }
        }
    }
}
