using DemoQASelenium1.AlertsFrameAndWindows;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Common;
using Utils.Extent;

namespace DemoQASelenium1.Widgets
{
    public class Widgets
    {
        IWebDriver driver;
        CommonTools commonTools;

        // locators
        IWebElement WidgetsClickOn => driver.FindElement(By.XPath("//h5[contains(text(), 'Widgets')]"));
        IWebElement AccordianSideBarTab => driver.FindElement(By.XPath("//span[contains(text(), 'Accordian')]"));
        IWebElement WhyDoWeUseItClickOn => driver.FindElement(By.Id("section3Heading"));


        // constructor
        public Widgets(IWebDriver driver)
        {
            this.driver = driver;
            commonTools = new CommonTools(driver);
        }

        // method
        public Widgets AlertsSideBarTabWidget()
        {
            ExtentReporting.Instance.LogInfo("Click on Widgets");

            commonTools.ScrollWindow(500);
            WidgetsClickOn.Click();

            return this;
        }

        public Widgets ClickOnAccordian()
        {
            ExtentReporting.Instance.LogInfo("Click on Accordian from side bar menu");

            commonTools.ScrollWindow(500);
            AccordianSideBarTab.Click();

            return this;
        }

        public Widgets ClickOnWhyDoWheUseIt()
        {
            ExtentReporting.Instance.LogInfo("Click on Why Do We Use It in the Accordian Tab");

            commonTools.ScrollWindow(500);
            WhyDoWeUseItClickOn.Click();

            return this;
        }
    }
}
