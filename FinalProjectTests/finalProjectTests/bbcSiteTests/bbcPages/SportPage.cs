using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectTests.finalProjectTests.bbcSiteTests.bbcPages
{
    public class SportPage : BasePage
    {
        public SportPage(IWebDriver driver) : base(driver)
        {

        }

        [FindsBy(How = How.XPath, Using = "//div[@role='menubar']//a[@data-stat-title='Football']")]
        private IWebElement _footballButtonInSportMenu;


        public void ClickfootballButtonInSportMenu()
        {
            _footballButtonInSportMenu.Click();
        }
    }

    
}
