using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectTests.finalProjectTests.bbcSiteTests.bbcPages
{
    public class CoronavirusPage : BasePage
    {
        public CoronavirusPage(IWebDriver driver) : base(driver)
        {

        }

        [FindsBy(How = How.XPath, Using = "//li[contains(@class,'gs-o-list-ui__item--flush gel')]//a[@href='/news/have_your_say']")]
        private IWebElement _yourCoronavirusStoriesLink;

        [FindsBy(How = How.XPath, Using = "//a[@href='/news/52143212']")]
        private IWebElement _yourQuestionsAnsweredTopic;

        [FindsBy(How = How.XPath, Using = "//textarea[@class='text-input--long']")]
        private IWebElement _fieldForQuestions;

        [FindsBy(How = How.XPath, Using = "//input[@aria-label='Name']")]
        private IWebElement _nameField;

        [FindsBy(How = How.XPath, Using = "//input[@aria-label='Email address']")]
        private IWebElement _emailField;

        [FindsBy(How = How.XPath, Using = "//input[@type='checkbox']")]
        private IWebElement _acceptanceCheckBox;

        [FindsBy(How = How.XPath, Using = "//button[text()='Submit']")]
        private IWebElement _submitButton;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Close']")]
        private IWebElement _closeButtonForSignInWindow;

        [FindsBy(How = How.XPath, Using = "//div[@class='long-text-input-container']//div[@class='input-error-message']")]
        private IWebElement _textErrorWindow;

        [FindsBy(How = How.XPath, Using = "//input[@aria-label='Name']/following-sibling::div")]
        private IWebElement _nameErrorWindow;

        [FindsBy(How = How.XPath, Using = "//div[text()=' must be accepted']")]
        private IWebElement _confirmationButtonErrorWindow;

        [FindsBy(How = How.XPath, Using = "//input[@aria-label='Email address']/following-sibling::div")]
        private IWebElement _emailErrorWindow;




        public void ClickYourCoronavirusStoriesLink()
        {
            _yourCoronavirusStoriesLink.Click();
        }

        public void ClickYourQuestionsAnsweredTopic()
        {
            _yourQuestionsAnsweredTopic.Click();
        }

        public IWebElement GetCloseButtonForSignInWindow()
        {
            return _closeButtonForSignInWindow;
        }

        public IWebElement GetEmailErrorWindow()
        {
            return _emailErrorWindow;
        }

        public string GetTextFromNameErrorWindow()
        {
            return _nameErrorWindow.Text;
        }

        public string GetTextFromEmailErrorWindow()
        {
            return _emailErrorWindow.Text;
        }

        public string GetTextFromTextErrorWindow()
        {
            return _textErrorWindow.Text;
        }

        public string GetTextFromconfirmationButtonErrorWindow()
        {
            return _confirmationButtonErrorWindow.Text;
        }


        public void FillAllFieldsExceptEmailAndClickSubmitButton(string question, string name)
        {
            _fieldForQuestions.SendKeys(question);
            _nameField.SendKeys(name);
            _acceptanceCheckBox.Click();
            _submitButton.Click();
        }

        public void ClickOnSubmitButton()
        {
            _submitButton.Click();
        }



    }
}
