using DemoQASelenium1.AlertsFrameAndWindows;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Extent;

namespace DemoQATests.AlertsFrameAndWindowsTests
{
    public class AlertsTests : TestBase
    {
        [Test]
        public void AlertsTest()
        {
            ExtentReporting.Instance.LogInfo("Starting test - Alerts Test");

            var specificForm = (Alerts)WebForm;
            var message =
                specificForm
                .AlertsSideBarTabClick()
                .AlertsFromSideBarClick()
                .ClickOnClickMeButtonAndGetAlertText();

            string expectedAlertText = "You clicked a button";
            Assert.That(message, Is.EqualTo(expectedAlertText), "Text in Alert is not expected text");
        }

        [Test]
        public void AlertsPromptBoxTest()
        {
            ExtentReporting.Instance.LogInfo("Starting test - enter text in prompt box");

            var specificForm = (Alerts)WebForm;
                specificForm
                .AlertsSideBarTabClick()
                .AlertsFromSideBarClick()
                .OnClickPromptBoxAppear();

            var newTabText = Driver.FindElement(By.Id("promptResult"));
            Assert.That(newTabText.Text, Is.EqualTo("You entered Hello"));
        }
    }   
}

