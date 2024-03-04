using DemoQASelenium1;
using OpenQA.Selenium;
using Utilities.Extent;

namespace DemoQATests
{
    public class RadioButtonClickTests : TestBase
    {
        [Test]
        public void RadioButtonTests()
        {
            ExtentReporting.Instance.LogInfo("Starting test - radio button");

            var specificForm = (ElementsRadioButtons)WebForm;
                specificForm
            .ElementsButtonClick()
            .RadioButtonClick()
            .RadioButtonClickYes();

            IWebElement spanElement = Driver.FindElement(By.XPath("//span[contains(text(), 'Yes')]"));
            Assert.That(spanElement.Text, Is.EqualTo("Yes"));
        }
    }
}
