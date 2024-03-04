using DemoQASelenium1.Widgets;
using OpenQA.Selenium;
using Utilities.Extent;

namespace DemoQATests.WidgetsTests
{
    public class AutoCompleteTest : TestBase
    {
        [Test]
        [TestCase("bl")] 
        public void TypeMultipleColor(string color)
        {
            ExtentReporting.Instance.LogInfo("Starting test - type two color in the color field");

            var specificForm = (AutoComplete)WebForm;
                specificForm
                .AlertsSideBarTabWidget()
                .ClickOnAutoComplete()
                .TypeMultipleColorNames(color);

            var blueElement = Driver.FindElement(By.XPath("//div[contains(text(), 'Blue')]"));
            var blackElement = Driver.FindElement(By.XPath("//div[contains(text(), 'Black')]"));

            Assert.Multiple(() =>
            {
                Assert.That(blueElement.Text, Is.EqualTo("Blue"));
                Assert.That(blackElement.Text, Is.EqualTo("Black"));
            });
        }
    }
}

