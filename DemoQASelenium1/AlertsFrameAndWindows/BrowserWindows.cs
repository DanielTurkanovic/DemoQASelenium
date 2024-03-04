using OpenQA.Selenium;
using Utilities.Common;
using Utilities.Extent;

namespace DemoQASelenium1.AlertsFrameAndWindows
{
    public class BrowserWindows
    {
        IWebDriver driver;
        CommonTools commonTools;

        // locators
        IWebElement AlertsSideBarTab => driver.FindElement(By.XPath("//h5[contains(text(), 'Alerts')]"));
        IWebElement BrowserWindowsTab => driver.FindElement(By.XPath("//span[contains(text(), 'Browser Windows')]"));
        IWebElement NewTab => driver.FindElement(By.Id("tabButton"));
        IWebElement NewWindow => driver.FindElement(By.Id("windowButton"));


        // constructors
        public BrowserWindows(IWebDriver driver)
        {
            this.driver = driver;
            commonTools = new CommonTools(driver);
        }

        //method
        public BrowserWindows AlertsSideBarTabButton()
        {
            ExtentReporting.Instance.LogInfo("Click on Alerts, Frame & Windows tab from side menu");

            commonTools.ScrollWindow(500);
           
            AlertsSideBarTab.Click();

            return this;
        }

        public BrowserWindows BrowserWindowsButton()
        {
            ExtentReporting.Instance.LogInfo("Click on Browser Windows tab from side menu");

            commonTools.ScrollWindow(500);

            BrowserWindowsTab.Click();

            return this;
        }

        public BrowserWindows NewTabClick()
        {
            ExtentReporting.Instance.LogInfo("Click on New Tab and switch to New Tab");

            NewTab.Click();
            // switch to new tab
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            return this;
        }
        
        public BrowserWindows NewWindowClick() 
        {
            ExtentReporting.Instance.LogInfo("Click on New Window");

            NewWindow.Click();
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            return this;
        }

    }
}
