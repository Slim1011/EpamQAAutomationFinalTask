using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectTests.finalProjectTests.bbcSiteTests.bbcTests
{
    class checkOfSendingDataTests : BaseTest
    {
        private const string Question = "What's going on???!!";
        private const string Name = "Saddam Hussein";
        private const int TimeToWait = 10;
        private const string EmailErrorSearchPhrase = "Email address can't be blank";
        private const string NameErrorSearchPhrase = "Name can't be blank";
        private const string TextErrorSearchPhrase = "can't be blank";
        private const string AcceptanceCheckBoxErrorSearchPhrase = "must be accepted";
       

        [Test]
        
        public void checkThatSubmissionDidNotWorkWithEmptyEmailField()
        {
            GetHomePage().ClickCoronavirusButtonInMenu();
            GetCoronavirusPage().ClickYourCoronavirusStoriesLink();
            GetCoronavirusPage().ClickYourQuestionsAnsweredTopic();
            GetCoronavirusPage().WaitElementIsEnable(TimeToWait, GetCoronavirusPage().GetCloseButtonForSignInWindow());
            GetCoronavirusPage().GetCloseButtonForSignInWindow().Click();
            GetCoronavirusPage().FillAllFieldsExceptEmailAndClickSubmitButton(Question, Name);
            GetCoronavirusPage().WaitVisibilityOfElement(TimeToWait, GetCoronavirusPage().GetEmailErrorWindow());
            Assert.IsTrue(GetCoronavirusPage().GetTextFromEmailErrorWindow().Contains(EmailErrorSearchPhrase));
        }

        [Test]
        public void checkThatSubmissionDidNotWorkWithAllEmptyFields()
        {
            GetHomePage().ClickCoronavirusButtonInMenu();
            GetCoronavirusPage().ClickYourCoronavirusStoriesLink();
            GetCoronavirusPage().ClickYourQuestionsAnsweredTopic();
            GetCoronavirusPage().WaitElementIsEnable(TimeToWait, GetCoronavirusPage().GetCloseButtonForSignInWindow());
            GetCoronavirusPage().GetCloseButtonForSignInWindow().Click();
            GetCoronavirusPage().ClickOnSubmitButton();
            GetCoronavirusPage().WaitVisibilityOfElement(TimeToWait, GetCoronavirusPage().GetEmailErrorWindow());
            Assert.IsTrue(GetCoronavirusPage().GetTextFromEmailErrorWindow().Contains(EmailErrorSearchPhrase));
            Assert.IsTrue(GetCoronavirusPage().GetTextFromNameErrorWindow().Contains(NameErrorSearchPhrase));
            Assert.IsTrue(GetCoronavirusPage().GetTextFromTextErrorWindow().Contains(TextErrorSearchPhrase));
            Assert.IsTrue(GetCoronavirusPage().GetTextFromconfirmationButtonErrorWindow().Contains(AcceptanceCheckBoxErrorSearchPhrase));
        }
    }
}
