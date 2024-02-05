using OpenQA.Selenium;
using OpenQA.Selenium.DevTools;
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

namespace DemoQASelenium1.InteractionsTab
{
    public class Sortable
    {
        IWebDriver driver;
        CommonTools commonTools;
       
        // locators
        IWebElement InteractionClick => driver.FindElement(By.XPath("//h5[contains (text(), 'Interactions')]"));
        IWebElement SortableClick => driver.FindElement(By.XPath("//span[contains (text(), 'Sortable')]"));
        IWebElement ElementOneFromList => driver.FindElement(By.XPath("(//div[contains(text(), 'One')])[1]"));
        IWebElement ElementFiveFromListTarget => driver.FindElement(By.XPath("(//div[contains(text(), 'Five')])[1]"));
        IWebElement GridClick => driver.FindElement(By.Id("demo-tab-grid"));
        IWebElement ElementOneFromGrid => driver.FindElement(By.XPath("(//div[contains(text(), 'One')])[2]"));
        IWebElement ElementFiveFromGridTarget => driver.FindElement(By.XPath("(//div[contains(text(), 'Five')])[2]"));

        // constructor
        public Sortable (IWebDriver driver)
        {
            this.driver = driver;
            commonTools = new CommonTools(driver);
        }

        // method
        public Sortable SelectMenuSideBarTabInteraction() 
        {
            ExtentReporting.Instance.LogInfo("Click on Interaction");

            commonTools.ScrollWindow(500);
            InteractionClick.Click();

            return this;
        }

        public Sortable ClickSortable()
        {
            ExtentReporting.Instance.LogInfo("Click on Interaction");

            commonTools.ScrollWindow(500);
            SortableClick.Click();

            return this;
        }

        public Sortable DragElementOneFromTheList()
        {
            ExtentReporting.Instance.LogInfo("Drag and Drop element from the list");

            commonTools.ScrollWindow(300);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.location.reload();");
            Actions actions = new Actions(driver);
            actions.DragAndDrop(ElementOneFromList, ElementFiveFromListTarget).Perform();

            return this;
        }

        public Sortable ClickGrid()
        {
            ExtentReporting.Instance.LogInfo("Click on Grid");

            commonTools.ScrollWindow(500);
            GridClick.Click();

            return this;
        }

        public Sortable DragElementOneFromTheGrid()
        {
            ExtentReporting.Instance.LogInfo("Drag and Drop element from the grid");

            commonTools.ScrollWindow(300);

            if (ElementOneFromGrid.Displayed && ElementOneFromGrid.Enabled)
            {
                Actions Actions = new Actions(driver);
                Actions.DragAndDrop(ElementOneFromGrid, ElementFiveFromGridTarget).Perform();
            }

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Actions actions = new Actions(driver);
            actions.DragAndDrop(ElementOneFromGrid, ElementFiveFromGridTarget).Perform();

            return this;
        }
    }
}
