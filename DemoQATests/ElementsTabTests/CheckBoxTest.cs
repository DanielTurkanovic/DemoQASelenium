using DemoQASelenium;
using OpenQA.Selenium;
using Utilities.Extent;

namespace DemoQATests.ElementsTabTests
{
    public class CheckBoxTest : TestBase
    {
        [Test]
        public void ElementCheckBoxTest()
        {
            ExtentReporting.Instance.LogInfo("Starting test - Elements Checkbox form");

            var specificForm = (ElementsCheckBox)WebForm;
                specificForm
                .ElementsButtonClick()
                .CheckBoxElementButton()
                .HomeButtonClick()
                .DocumentButtonClick()
                .OfficeButtonClick()
                .GeneralCheckboxClick();

            var successMessage = Driver.FindElement(By.ClassName("text-success"));
            Assert.That(successMessage.Text, Is.EqualTo("general"));
        }
    }
}
