using DemoQASelenium1.AlertsFrameAndWindows;
using DemoQASelenium1.Widgets;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Extent;

namespace DemoQATests.WidgetsTests
{
    public class WidgetsTests : TestBase
    {
        [Test]
        public void AccordianTest()
        {
            ExtentReporting.Instance.LogInfo("Starting test - Click on Why do we use it from Accordian tab bar");

            var specificForm = (Widgets)WebForm;
                specificForm
                .AlertsSideBarTabWidget()
                .ClickOnAccordian()
                .ClickOnWhyDoWheUseIt();

            var newTabText = Driver.FindElement(By.Id("section3Content"));
            Assert.That(newTabText.Text, Does.Contain(" 'Content here, content here', making it look like readable English"));
        }
    }
}
