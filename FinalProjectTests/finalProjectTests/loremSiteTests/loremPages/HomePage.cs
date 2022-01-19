using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectTests.finalProjectTests.loremSiteTests.loremPages
{
     public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {

        }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Pyccкий')]")]
        private IWebElement _russianLanguageButton;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'рыба')]")]
        private IWebElement _firstParagraph;

        [FindsBy(How = How.XPath, Using = "//input[@name='generate']")]
        private IWebElement _generateLoremIpsumButton;

        [FindsBy(How = How.XPath, Using = "//input[@value='words']")]
        private IWebElement _wordsRadioButton;

        [FindsBy(How = How.XPath, Using = "//input[@value='bytes']")]
        private IWebElement _bytesRadioButton;

        [FindsBy(How = How.XPath, Using = "//input[@id='amount']")]
        private IWebElement _amountInputField;

        [FindsBy(How = How.XPath, Using = "//input[@name='start']")]
        private IWebElement _startWithLorumIpsumCheckbox;


        public void ClickToRussianLanguageButton()
        {
            _russianLanguageButton.Click();
        }

        public string GetTextFromFirstParagraph()
        {
            return _firstParagraph.Text;
        }

        public void ClickTogenerateLoremIpsumButton()
        {
            _generateLoremIpsumButton.Click();
        }
        public void ClickOnWordsRadioButton()
        {
            _wordsRadioButton.Click();
        }

        public void ClickOnBytesRadioButton()
        {
            _bytesRadioButton.Click();
        }

        public void InputQuantiryIntoNumberFieldAndClickGenerateButton(int quantity)
        {
            _amountInputField.Clear();
            _amountInputField.SendKeys(quantity.ToString());
            ClickTogenerateLoremIpsumButton();
        }

        public void ClearCheckboxStartWithLorumIpsum()
        {
            _startWithLorumIpsumCheckbox.Click();
        }
    }
}
