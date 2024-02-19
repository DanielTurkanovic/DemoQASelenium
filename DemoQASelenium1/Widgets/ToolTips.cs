using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Common;
using Utilities.Extent;

namespace DemoQASelenium1.Widgets
{
    public class ToolTips
    {
        IWebDriver driver;
        CommonTools commonTools;

        // locators 
        IWebElement WidgetsClickOn => driver.FindElement(By.XPath("//h5[contains(text(), 'Widgets')]"));
        IWebElement ToolTipsClick => driver.FindElement(By.XPath("//span[contains(text(), 'Tool Tips')]"));
        IWebElement HoverMeToSee => driver.FindElement(By.Id("toolTipButton"));


        // constructor
        public ToolTips(IWebDriver driver)
        {
            this.driver = driver;
            commonTools = new CommonTools(driver);
        }

        // method
        public ToolTips ProgressBarSideBarTabWidget()
        {
            ExtentReporting.Instance.LogInfo("Click on Widgets");

            commonTools.ScrollWindow(500);
            WidgetsClickOn.Click();

            return this;
        }

        public ToolTips ClickOnToolTips()
        {
            ExtentReporting.Instance.LogInfo("Click on Tool Tips");

            commonTools.ScrollWindow(800);
            ToolTipsClick.Click();

            return this;
        }

        public ToolTips HoverMeToSeeButton()
        {
            ExtentReporting.Instance.LogInfo("Hover over the Hover Me To See Button");

            Actions actions = new Actions(driver);
            actions.MoveToElement(HoverMeToSee).Perform();

            return this;
        }
    }
}
