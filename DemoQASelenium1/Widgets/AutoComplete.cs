using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V117.Performance;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Utils.Common;
using Utils.Extent;

namespace DemoQASelenium1.Widgets
{
    public class AutoComplete
    {
        IWebDriver driver;
        CommonTools commonTools;

        // locators
        IWebElement WidgetsClickOn => driver.FindElement(By.XPath("//h5[contains(text(), 'Widgets')]"));
        IWebElement AutoCompleteClick => driver.FindElement(By.XPath("//span[contains(text(), 'Auto Complete')]"));
        IWebElement MultipleColorNames => driver.FindElement(By.Id("autoCompleteMultipleContainer"));

        // constructor
        public AutoComplete(IWebDriver driver)
        {
            this.driver = driver;
            commonTools = new CommonTools(driver);
        }

        // method
        public AutoComplete AlertsSideBarTabWidget()
        {
            ExtentReporting.Instance.LogInfo("Click on Widgets");

            commonTools.ScrollWindow(500);
            WidgetsClickOn.Click();

            return this;
        }

        public AutoComplete ClickOnAutoComplete()
        {
            ExtentReporting.Instance.LogInfo("Click on Auto Complete from side bar");

            commonTools.ScrollWindow(500);
            AutoCompleteClick.Click();
            return this;
        }

        public AutoComplete TypeMultipleColorNames(string text)
        {
            ExtentReporting.Instance.LogInfo("Type color in the field");

            commonTools.ScrollWindow(200);

            Actions actions = new Actions(driver);
            actions.MoveToElement(MultipleColorNames).Perform();

            MultipleColorNames.SendKeys("text");
            MultipleColorNames.SendKeys(Keys.Down);
            MultipleColorNames.SendKeys(Keys.Tab);
            MultipleColorNames.SendKeys("text");
            MultipleColorNames.SendKeys(Keys.Tab);

            return this;
        }
    }
}
