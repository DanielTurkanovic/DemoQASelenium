using DemoQASelenium1.Widgets;
using OpenQA.Selenium;
using Utilities.Extent;

namespace DemoQATests.WidgetsTests 
{
    public class ToolTipsTest :TestBase
    {
        [Test]
        public void ToolTip()
        {
            ExtentReporting.Instance.LogInfo("Starting test - Tool Tips");

            var specificForm = (ToolTips)WebForm;
            specificForm
                .ProgressBarSideBarTabWidget()
                .ClickOnToolTips()
                .HoverMeToSeeButton();

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IWebElement element = Driver.FindElement(By.CssSelector("button[aria-describedby='buttonToolTip']"));
            Assert.That(element, Is.Not.Null, "Element is not find.");
        }
    }
}
