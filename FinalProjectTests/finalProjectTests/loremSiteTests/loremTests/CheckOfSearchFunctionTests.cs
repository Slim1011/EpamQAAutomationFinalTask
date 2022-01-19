using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectTests.finalProjectTests.loremSiteTests.loremTests
{
   
    class CheckOfSearchFunctionTests : BaseTests
    {
        private const string WordOfWerification = "рыба";
        private const string SearchPhraze = "Lorem ipsum dolor sit amet, consectetur adipiscing elit";
        private const int TimeToWait = 10;


       [Test]
        public void CheckThatSearchWordAppearsInFirstParagraph()
        {
             GetHomePage().ClickToRussianLanguageButton();
            Assert.IsTrue( GetHomePage().GetTextFromFirstParagraph().Contains(WordOfWerification));
            
        }

        [Test]
        public void CheckThatFirstParagraphOnFeedPageStartsFromLoremIpsum()
        {
            GetHomePage().ClickTogenerateLoremIpsumButton();
            GetFeedPage().WaitVisibilityOfElement(TimeToWait, GetFeedPage().GetFeedPageFirstParagraph());
            Assert.IsTrue(GetFeedPage().GetTextFromFeedPage().StartsWith(SearchPhraze));
        }

        [Test]
        public void CheckThatFirstParagraphOnFeedPageNotStartsFromLoremIpsumAfterUntickAccordingRadioButton()
        {
            GetHomePage().ClearCheckboxStartWithLorumIpsum();
            GetHomePage().ClickTogenerateLoremIpsumButton();
            GetFeedPage().WaitVisibilityOfElement(TimeToWait, GetFeedPage().GetFeedPageFirstParagraph());
            Assert.IsFalse(GetFeedPage().GetTextFromFeedPage().StartsWith(SearchPhraze));
            
        }

        
    }
}
