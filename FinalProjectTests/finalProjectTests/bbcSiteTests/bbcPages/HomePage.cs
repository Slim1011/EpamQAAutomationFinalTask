using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FinalProjectTests.finalProjectTests.bbcSiteTests.bbcPages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {

        }
        [FindsBy(How = How.XPath, Using = "//div[@id='orb-nav-links']//a[text()='News']")]
        private IWebElement _newsButton;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'gs-c-promo-body gs-u-display-none ')]//h3[contains(text(),'US reports Covid record')]")]
        private IWebElement _nameOfHeadlineArticle;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'nw-c-top-stories__tertiary-top ')]//a[contains(@class,'gs-c-promo')]")]
        private IList<IWebElement> _secondaryArticleTitles;

        [FindsBy(How = How.XPath, Using = "//li[contains(@class,'gs-o-list-ui__item--flush gel')]//a[@href='/news/stories']")]
        private IWebElement _storiesCategoryButton;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,' gel-1/2@xl ')]//h3[contains(@class,'gs')]")]
        private IWebElement _nameOfFirstArticleInTechCategory;

        [FindsBy(How = How.XPath, Using = "//input[@id='orb-search-q']")]
        private IWebElement _searchBar;

        [FindsBy(How = How.XPath, Using = "//button[@id='orb-search-button']")]
        private IWebElement _searchButton;

        [FindsBy(How = How.XPath, Using = "//li[contains(@class,'gs-o-list-ui__item--flush gel')]//a[@href='/news/coronavirus']")]
        private IWebElement _coronavirusButtonInMenu;

        [FindsBy(How = How.XPath, Using = "//div[@id='orb-nav-links']//a[text()='Sport']")]
        private IWebElement _sportButtonInMenu;



        
        public void ClickOnNewsButton()
        {
            _newsButton.Click();
        }
        public string GetTextFromFromHeadlineArticleName()
        {
            return _nameOfHeadlineArticle.Text;
        }

        public IList<IWebElement> GetSecondaryArticleTitles()
        {
            return _secondaryArticleTitles;
        }

        public List<string> GetListOfSecondaryAricleNames()
        {
            List<string> secondArticleNames = new List<string>();
            foreach (var article in _secondaryArticleTitles)
            {
                secondArticleNames.Add(article.Text);
            }
            return secondArticleNames;
        }

        public IWebElement GetStoriesCategoryButton()
        {
            return _storiesCategoryButton;
        }

        public string GetTextFromCategoryButtonName(IWebElement button)
        {
            return button.Text;
        }

        public void InputSearchWordIntoSearchBarAndClickSearchButton(string searchWord)
        {
            _searchBar.SendKeys(searchWord + Keys.Enter);
           
        }

        public void ClickCoronavirusButtonInMenu()
        {
            _coronavirusButtonInMenu.Click();
        }

        public void ClicksportButtonInMenu()
        {
            _sportButtonInMenu.Click();
        }

    }
}
