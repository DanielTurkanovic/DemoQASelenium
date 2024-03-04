using DemoQASelenium1.Widgets;
using OpenQA.Selenium;
using Utilities.Extent;

namespace DemoQATests.WidgetsTests
{
    public class AccordianTest : TestBase
    {
        [Test]
        public void Widget()
        {
            ExtentReporting.Instance.LogInfo("Starting test - Click on Why do we use it from Accordian tab bar");

            var specificForm = (Accordian)WebForm;
                specificForm
                .AlertsSideBarTabWidget()
                .ClickOnAccordian()
                .ClickOnWhyDoWheUseIt();

            var newTabText = Driver.FindElement(By.Id("section3Content"));
            Assert.That(newTabText.Text, Does.Contain(" 'Content here, content here', making it look like readable English"));
        }
    }
}
