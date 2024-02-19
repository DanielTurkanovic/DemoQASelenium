using DemoQASelenium1.Widgets;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Utilities.Common;
using Utilities.Extent;

namespace DemoQASelenium1.Widgets
{

    public class ProgressBar
    {
        IWebDriver driver;
        CommonTools commonTools;

        // locators
        IWebElement WidgetsClickOn => driver.FindElement(By.XPath("//h5[contains(text(), 'Widgets')]"));
        IWebElement ProgressBarClick => driver.FindElement(By.XPath("//span[contains(text(), 'Progress Bar')]"));
        IWebElement Start => driver.FindElement(By.Id("startStopButton"));

        //constructor
        public ProgressBar(IWebDriver driver)
        {
            this.driver = driver;
            commonTools = new CommonTools(driver);
        }

        // method
        public ProgressBar ProgressBarSideBarTabWidget()
        {
            ExtentReporting.Instance.LogInfo("Click on Widgets");

            commonTools.ScrollWindow(500);
            WidgetsClickOn.Click();

            return this;
        }

        public ProgressBar ClickOnProgressBar()
        {
            ExtentReporting.Instance.LogInfo("Click on Progress Bar");

            commonTools.ScrollWindow(500);
            ProgressBarClick.Click();

            return this;
        }

        public ProgressBar ClickStart()
        {
            ExtentReporting.Instance.LogInfo("Click on Start");

            Start.Click();

            Thread.Sleep(TimeSpan.FromSeconds(10));

            return this;
        }
    }
}