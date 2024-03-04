using OpenQA.Selenium;
using Utilities.Common;
using Utilities.Extent;

namespace DemoQASelenium1.Widgets
{
    public class SelectMenu
    {
        IWebDriver driver;
        CommonTools commonTools;

        // locators
        IWebElement WidgetsClickOn => driver.FindElement(By.XPath("//h5[contains(text(), 'Widgets')]"));
        IWebElement SelectMenuClick => driver.FindElement(By.XPath("//span[contains(text(), 'Select Menu')]"));
        IWebElement SelectValueClick => driver.FindElement(By.XPath("//div[contains(text(), 'Select Option')]"));
        IWebElement SelectOption => driver.FindElement(By.CssSelector("[id*='option-0-1']"));
        IWebElement SelectOne => driver.FindElement(By.XPath("//div[contains(text(), 'Select Title')]"));
        IWebElement SelectTitle => driver.FindElement(By.CssSelector("[id*='option-0-5']"));
        IWebElement OldStyleSelectMenuClick => driver.FindElement(By.Id("oldSelectMenu"));
        IWebElement OldStyleSelectMenuClickColorChose => driver.FindElement(By.XPath("//option[contains(text(), 'Blue')]"));
        IWebElement MultiselectDropDownClick => driver.FindElement(By.XPath("//div[contains(text(), 'Select...')]"));
        IWebElement MultiselectDropDownClickBlue => driver.FindElement(By.XPath("//div[contains(text(), 'Blue')]"));
        IWebElement MultiselectDropDownClickGreen => driver.FindElement(By.XPath("//div[contains(text(), 'Green')]"));

        IWebElement StandardMultiSelect => driver.FindElement(By.XPath("//option[contains(text(), 'Audi')]"));
        // constructors
        public SelectMenu(IWebDriver driver)
        {
            this.driver = driver;
            commonTools = new CommonTools(driver);
        }

        // method
        public SelectMenu SelectMenuSideBarTabWidget()
        {
            ExtentReporting.Instance.LogInfo("Click on Widgets");

            commonTools.ScrollWindow(500);
            WidgetsClickOn.Click();

            return this;
        }

        public SelectMenu ClickSelectMenu()
        {
            ExtentReporting.Instance.LogInfo("Click on Select Menu Side Bar Tab Widgets");

            commonTools.ScrollWindow(800);
            SelectMenuClick.Click();

            return this;
        }

        public SelectMenu ChooseFromSelectValue()
        {
            ExtentReporting.Instance.LogInfo("Click on Select Value and choose from drop down menu");

            SelectValueClick.Click();
            SelectOption.Click();

            return this;
        }

        public SelectMenu ChooseFromSelectOne()
        {
            ExtentReporting.Instance.LogInfo("Click on Select Title and choose from drop down menu");

            SelectOne.Click();
            commonTools.ScrollWindow(800);
            SelectTitle.Click();

            return this;
        }

        public SelectMenu ChooseFromOldStyleSelectMenu()
        {
            ExtentReporting.Instance.LogInfo("Click on Old Style Select Menu and choose from drop down menu");

            OldStyleSelectMenuClick.Click();
            OldStyleSelectMenuClickColorChose.Click();

            return this;
        }

        public SelectMenu ChooseFromMultiselectDropDown()
        {
            ExtentReporting.Instance.LogInfo("Click on Multiselect drop down and choose from drop down menu");

            commonTools.ScrollWindow(800);
            MultiselectDropDownClick.Click();
            MultiselectDropDownClickBlue.Click();
            MultiselectDropDownClickGreen.Click();



            return this;
        }

        public SelectMenu ChooseFromStandardMultiSelect()
        {
            ExtentReporting.Instance.LogInfo("Click on Standard multi select and choose from drop down menu");

            StandardMultiSelect.Click();
          
            return this;
        }
    }
}
