using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using Utilities.Common;
using Utilities.Extent;

namespace DemoQASelenium1.InteractionsTab
{
    public class Resizable
    {
        IWebDriver driver;
        CommonTools commonTools;

        // locators
        IWebElement InteractionClick => driver.FindElement(By.XPath("//h5[contains (text(), 'Interactions')]"));
        IWebElement ResizableClick => driver.FindElement(By.XPath("//span[contains (text(), 'Resizable')]"));
        IWebElement SquareResizable => driver.FindElement((By.XPath("(//span[@class='react-resizable-handle react-resizable-handle-se'])[2]")));
        // constructor
        public Resizable (IWebDriver driver)
        {
            this.driver = driver;
            commonTools = new CommonTools(driver);
        }

        // method
        public Resizable SelectMenuSideBarTabInteraction()
        {
            ExtentReporting.Instance.LogInfo("Click on Interaction");

            commonTools.ScrollWindow(500);
            InteractionClick.Click();

            return this;
        }

        public Resizable ClickResizable()
        {
            ExtentReporting.Instance.LogInfo("Click on Resizable");

            commonTools.ScrollWindow(500);
            ResizableClick.Click();

            return this;
        }

        public Resizable ResizableSquare()
        {
            ExtentReporting.Instance.LogInfo("Click on Resizable");

            commonTools.ScrollWindow(500);
            SquareResizable.Click();
            Actions actions = new Actions(driver);
            actions.ClickAndHold(SquareResizable).MoveToElement(SquareResizable, 400, 200).Release().Perform();

            return this;
        }

    }
}
