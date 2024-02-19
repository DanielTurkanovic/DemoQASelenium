using DemoQASelenium1;
using DemoQASelenium1.AlertsFrameAndWindows;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Extent;

namespace DemoQATests.AlertsFrameAndWindowsTests
{
    public class BrowserWindowsTests : TestBase
    {
        [Test]
        public void NewTabTest()
        {
            ExtentReporting.Instance.LogInfo("Starting test - New Tab Test");

            var specificForm = (BrowserWindows)WebForm;
                specificForm
                .AlertsSideBarTabButton()
                .BrowserWindowsButton()
                .NewTabClick();

            var newTabText = Driver.FindElement(By.Id("sampleHeading"));
            Assert.That(newTabText.Text, Is.EqualTo("This is a sample page"));
        }

        [Test]
        public void NewWindowTest()
        {
            ExtentReporting.Instance.LogInfo("Starting test - New Window Test");

            var specificForm = (BrowserWindows)WebForm;
                specificForm
                .AlertsSideBarTabButton()
                .BrowserWindowsButton()
                .NewWindowClick();

            var newTabText = Driver.FindElement(By.Id("sampleHeading"));
            Assert.That(newTabText.Text, Is.EqualTo("This is a sample page"));
        }
    }
}
