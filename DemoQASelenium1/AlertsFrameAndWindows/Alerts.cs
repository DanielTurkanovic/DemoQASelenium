using OpenQA.Selenium;
using System;
using Utilities.Common;
using Utilities.Extent;

namespace DemoQASelenium1.AlertsFrameAndWindows
{
    public class Alerts
    {
        IWebDriver driver;
        CommonTools commonTools;

        // locators
        IWebElement AlertsSideBarTab => driver.FindElement(By.XPath("//h5[contains(text(), 'Alerts')]"));
        IWebElement AlertsFromSideBar => driver.FindElement(By.XPath("//span[contains(text(), 'Alerts')]"));
        IWebElement ClickButtonToSeeAlert => driver.FindElement(By.Id("alertButton"));
        IWebElement ClickButtonPromptBoxAppear => driver.FindElement(By.Id("promtButton"));
         // constructors
         public Alerts(IWebDriver driver)
         {
            this.driver = driver;
            commonTools = new CommonTools(driver);
         }

        // methods
        public Alerts AlertsSideBarTabClick()
         {
            ExtentReporting.Instance.LogInfo("Click on Alerts, Frame & Windows tab from side menu");

            commonTools.ScrollWindow(500);
            AlertsSideBarTab.Click();

            return this;
         }

        public Alerts AlertsFromSideBarClick()
        {
            ExtentReporting.Instance.LogInfo("Click on Alerts from side bar menu");

            commonTools.ScrollWindow(500);
            AlertsFromSideBar.Click();

            return this;
        }

        public string ClickOnClickMeButtonAndGetAlertText()
        {
            ExtentReporting.Instance.LogInfo("Click on Alerts from side bar menu and get Alert text");

            ClickButtonToSeeAlert.Click();
            string alertText = commonTools.WaitForAlertText(driver, TimeSpan.FromSeconds(5));
            return alertText;
        }

        public Alerts OnClickPromptBoxAppear()
        {
            ExtentReporting.Instance.LogInfo("Click on Alerts from side bar, enter text in Alerts windows");

            commonTools.ScrollWindow(500);

            ClickButtonPromptBoxAppear.Click();
            IAlert alert = driver.SwitchTo().Alert();
            alert.SendKeys("Hello");
            alert.Accept();

            return this;
        }

    }
}
