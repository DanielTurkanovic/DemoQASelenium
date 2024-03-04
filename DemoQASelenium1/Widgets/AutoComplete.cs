using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using Utilities.Common;
using Utilities.Extent;

namespace DemoQASelenium1.Widgets
{
    public class AutoComplete
    {
        IWebDriver driver;
        CommonTools commonTools;

        // locators
        IWebElement WidgetsClickOn => driver.FindElement(By.XPath("//h5[contains(text(), 'Widgets')]"));
        IWebElement AutoCompleteClick => driver.FindElement(By.XPath("//span[contains(text(), 'Auto Complete')]"));
        IWebElement MultipleColorNames => driver.FindElement(By.XPath("(//div[@class='auto-complete__input'])[1]"));
        IWebElement MultipleColorText => driver.FindElement(By.Id("autoCompleteMultipleInput"));
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

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(MultipleColorNames));

            MultipleColorNames.Click();
            MultipleColorText.SendKeys(text);
            MultipleColorText.SendKeys(Keys.Down);
            MultipleColorText.SendKeys(Keys.Tab);
            MultipleColorText.Click();
            MultipleColorText.SendKeys(text);
            MultipleColorText.SendKeys(Keys.Tab);

            return this;
        }
    }
}
