using DemoQASelenium1.FormsTab;
using DemoQATests.ElementsTabTests;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Extent;

namespace DemoQATests.FormsTabTests
{
    internal class PracticeFormTest : TestBase
    {
        [Test]
        [TestCase("name@email.com", "3654895543")]
        [TestCase("name@.com", "3654895")]
        public void FormTest(string email, string mobileNumber)
        {
            ExtentReporting.Instance.LogInfo($"Starting test - Forms with Email: {email}, Mobile Number: {mobileNumber}");

            var text = Guid.NewGuid().ToString();
            var specificForm = (FormsPracticeForm)WebForm;
                specificForm
                .ClickOnFormsSideBarMenuButton()
                .ClickOnPracticeForm()
                .FirstNameInput(text)
                .LastNameInput(text)
                .EmailInput(email)
                .GenderRadioButtonClick()
                .MobileNumberInput(mobileNumber)
                .DateOfBirthInput()
                .SubjectInput(text)
                .HobbiesChoose()
                .ClickOnSelectPicture()
                .CurrentAddressInput(text)
                .StateChoose()
                .CityChoose()
                .SubmitButtonClick();

            if (email.Contains("@") && mobileNumber.Length == 10)
            {
                // Positive case
                IWebElement submitHeading = Driver.FindElement(By.XPath("//div[contains(text(), 'Thanks for submitting the form')]"));
                Assert.That(submitHeading.Text, Is.EqualTo("Thanks for submitting the form"));
            }
            else
            {
                // Negative case
                var emailField = Driver.FindElement(By.Id("userEmail"));
                var emailBorderColor = emailField.GetCssValue("border-color");

                var mobileNumberField = Driver.FindElement(By.Id("userNumber"));
                var salaryBorderColor = mobileNumberField.GetCssValue("border-color");

                if (emailBorderColor == "rgb(148, 26, 37)" && salaryBorderColor == "rgb(148, 26, 37)")
                {
                    Assert.Fail("Email and mobile fields have red colored borders, wrong inputs for email and salary fields");
                }
            }
        }
    }
}
