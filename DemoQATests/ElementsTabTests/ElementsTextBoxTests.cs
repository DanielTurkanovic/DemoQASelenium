using DemoQASelenium;
using DemoQASelenium1.FormsTab;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Extent;

namespace DemoQATests.ElementsTabTests
{
    public class ElementsTextBoxTests : TestBase
    {
        [Test]
        [TestCase("test@gmail.com", false)] 
        [TestCase("test@.com", true)] 
        public void ElementsTextBoxTest(string email, bool expected)
        {
            ExtentReporting.Instance.LogInfo("Starting test - submit form");

            var text = Guid.NewGuid().ToString();
            var specificForm = (ElementsTextBox)WebForm;
                specificForm
                .ElementsButtonClick()
                .TextBoxElementButton()
                .FullNameInputText(text)
                .EmailInputText(email) 
                .CurrentAddressTextAreaText(text)
                .PermanentAddressTextAreaText(text)
                .SubmitButtonForm();

            var emailField = Driver.FindElement(By.Id("userEmail"));
            var borderColor = emailField.GetCssValue("border-color");

            if (borderColor == "rgb(255, 0, 0)" && expected)
            {
                Assert.Pass("Email field is colored red, wrong email");
            }
            else if (borderColor != "rgb(255, 0, 0)" && !expected)
            {
                Assert.Pass("Email field is not colored red, correct email");
            }
            else
            {
                Assert.Fail("Test failed");
            }
        }
    }
}
