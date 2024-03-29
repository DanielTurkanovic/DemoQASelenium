﻿using DemoQASelenium1.Widgets;
using OpenQA.Selenium;
using Utilities.Extent;

namespace DemoQATests.WidgetsTests
{
    public class ProgressBarTest : TestBase
    {
        [Test]
        public void ProgressBar()
        {
            ExtentReporting.Instance.LogInfo("Starting test - Progress bar");

            var specificForm = (ProgressBar)WebForm;
                specificForm
                .ProgressBarSideBarTabWidget()
                .ClickOnProgressBar()
                .ClickStart();

            IWebElement resetButton = Driver.FindElement(By.Id("resetButton"));
            Assert.That(resetButton.Text, Is.EqualTo("Reset"));
        }
    }
}
