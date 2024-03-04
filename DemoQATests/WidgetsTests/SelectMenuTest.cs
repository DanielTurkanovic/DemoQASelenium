using DemoQASelenium1.Widgets;
using OpenQA.Selenium;
using Utilities.Extent;

namespace DemoQATests.WidgetsTests
{
    public class SelectMenuTest : TestBase
    {
        [Test]
        public void SelectMenu()
        {
            ExtentReporting.Instance.LogInfo("Starting test - Select Menu");

            var specificForm = (SelectMenu)WebForm;
            specificForm
                .SelectMenuSideBarTabWidget()
                .ClickSelectMenu()
                .ChooseFromSelectValue()
                .ChooseFromSelectOne()
                .ChooseFromOldStyleSelectMenu()
                .ChooseFromMultiselectDropDown()
                .ChooseFromStandardMultiSelect();

            var colorIsChosen = Driver.FindElement(By.XPath("//div[contains(text(), 'Blue')]"));
            Assert.That(colorIsChosen.Text, Is.EqualTo("Blue"));
        }
    }
}
