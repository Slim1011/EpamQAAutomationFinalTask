using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FinalProjectTests.finalProjectTests.loremSiteTests.loremPages
{
    public class FeedPage : BasePage
    {
        IWebDriver driver;
        public FeedPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }
        int totalCount = 0;

        [FindsBy(How = How.XPath, Using = "//div[@id = 'lipsum']//p[1]")]
        private IWebElement _feedPageFirstParagraph;

        [FindsBy(How = How.XPath, Using = "//div[@id='lipsum']")]
        private IWebElement _generatedString;

        [FindsBy(How = How.XPath, Using = "//div[@id='lipsum']")]
        private IWebElement _generatedText;

        public string GetTextFromFeedPage()
        {
            return _feedPageFirstParagraph.Text;
        }

        public IWebElement GetFeedPageFirstParagraph()
        {
            return _feedPageFirstParagraph;
        }
        public int GetNumberOfGeneratedWords()
        {
            return _generatedString.Text.Split(" ").Count(); 
        }

        public int GetNumberOfGeneratedBytes()
        {
            return _generatedString.Text.Count();
            
        }

        public void GoBackFromFeedPageToHomePage()
        {
            driver.Navigate().Back();
        }

        public int GetNumberOfParagraphContainsLorumWord()
        {
            int count = 0;
           
            string[] separateParagraphs = Regex.Split(_generatedText.Text.ToLower(), @"\r\n");
            foreach (var paragraph in separateParagraphs)
            {
                if (paragraph.Contains("lorem"))
                {
                    count++;
                }
            }
            return count;
        }

        public int TotalCountOfParagraphs(int numberOfParagaraphs)
        {
            
            totalCount += numberOfParagaraphs;
            return totalCount;
        }

        public IWebElement GetGeneratedText()
        {
            return _generatedText;
        }
    }
}
