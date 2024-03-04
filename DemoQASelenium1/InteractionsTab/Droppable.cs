using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using Utilities.Common;
using Utilities.Extent;

namespace DemoQASelenium1.InteractionsTab
{
    public class Droppable
    {
        IWebDriver driver;
        CommonTools commonTools;

        // locators
        IWebElement InteractionClick => driver.FindElement(By.XPath("//h5[contains (text(), 'Interactions')]"));
        IWebElement DroppableClick => driver.FindElement(By.XPath("//span[contains (text(), 'Droppable')]"));
        IWebElement SimpleClick => driver.FindElement(By.Id("droppableExample-tab-simple"));
        IWebElement DragMe => driver.FindElement(By.Id("draggable"));
        IWebElement DropHere => driver.FindElement(By.Id("droppable"));

        //constructor
        public Droppable(IWebDriver driver)
        {
            this.driver = driver;
            commonTools = new CommonTools(driver);
        }

        //method
        public Droppable SelectMenuSideBarTabInteraction()
        {
            ExtentReporting.Instance.LogInfo("Click on Interaction");

            commonTools.ScrollWindow(500);
            InteractionClick.Click();

            return this;
        }

        public Droppable ClickDroppable()
        {
            ExtentReporting.Instance.LogInfo("Click on Droppable");

            commonTools.ScrollWindow(500);
            DroppableClick.Click();

            return this;
        }

        public Droppable ClickSimple()
        {
            ExtentReporting.Instance.LogInfo("Click on Simple");

            SimpleClick.Click();

            return this;
        }

        public Droppable DragAndDrop()
        {
            ExtentReporting.Instance.LogInfo("Click on Simple");

            Actions actions = new Actions(driver);
            actions.DragAndDrop(DragMe, DropHere).Perform();

            return this;
        }
    }
}
