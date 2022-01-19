using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectTests.finalProjectTests.bbcSiteTests.bbcPages
{
    public class StoriesPage : BasePage
    {
        public StoriesPage(IWebDriver driver) : base(driver)
        {

        }

        [FindsBy(How = How.XPath, Using = "(//a[@class='ssrcss-atl1po-PromoLink e1f5wbog0'])[1]")]
        private IWebElement _firstArticleFromStoriesPageBySearching;


        public string GetNameFromfirstArticleFromStoriesPageBySearching()
        {
            return _firstArticleFromStoriesPageBySearching.Text;
        }
    }
}
