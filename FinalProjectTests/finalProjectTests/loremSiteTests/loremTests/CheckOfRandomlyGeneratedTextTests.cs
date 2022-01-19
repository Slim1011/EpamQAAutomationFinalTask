using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectTests.finalProjectTests.loremSiteTests.loremTests
{
    class CheckOfRandomlyGeneratedTextTests : BaseTests
    {
        
        private const int TimeToWait = 10;
        private const double NumberOfGenerations = 10;

        [Test]
        public void CheckOfPercentageWordLoremInGeneratedParagraphs()
        {
            double totalCounter = 0;
            for (int i = 0; i < NumberOfGenerations; i++)
            {
                GetHomePage().ClickTogenerateLoremIpsumButton();
                GetFeedPage().WaitVisibilityOfElement(TimeToWait, GetFeedPage().GetGeneratedText());
                totalCounter += GetFeedPage().TotalCountOfParagraphs(GetFeedPage().GetNumberOfParagraphContainsLorumWord());
                GetFeedPage().GoBackFromFeedPageToHomePage();
            }
            double averageNumberOfParagraphs = totalCounter / NumberOfGenerations;
            Assert.IsTrue(averageNumberOfParagraphs > 2 && averageNumberOfParagraphs < 3);
           
            

        }
    }
}
