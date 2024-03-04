using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using Utilities.Common;
using Utilities.Extent;

namespace DemoQASelenium1
{
    public class ElementsButtons
    {
        IWebDriver driver;
        CommonTools commonTools;

        //locators
        IWebElement ElementsSideBar => driver.FindElement(By.XPath("//h5[contains(text(), 'Elements')]"));
        IWebElement Buttons => driver.FindElement(By.Id("item-4"));

        IWebElement DoubleClick => driver.FindElement(By.Id("doubleClickBtn"));

        IWebElement RightClick => driver.FindElement(By.Id("rightClickBtn"));

        IWebElement LeftClick => driver.FindElement(By.XPath("(//button[contains(text(), 'Click Me')])[3]"));

        //constructor
        public ElementsButtons(IWebDriver driver)
        {
            this.driver = driver;
            commonTools = new CommonTools(driver);
        }

        //methods
        public ElementsButtons ElementsButtonClick()
        {
            ExtentReporting.Instance.LogInfo($"Click on the Elements");

            commonTools.ScrollWindow(500);
            ElementsSideBar.Click();

            return this;
        }

        public ElementsButtons ButtonsClick()
        {
            ExtentReporting.Instance.LogInfo("Buttons click");

            commonTools.ScrollWindow(500);
            Buttons.Click();

            return this;
        }

        public ElementsButtons ClickOnDoubleClick() 
        {
            ExtentReporting.Instance.LogInfo("Perform double click on button");

            Actions action = new Actions(driver);

            action.DoubleClick(DoubleClick);

            action.Perform();

            return this;
        }

        public ElementsButtons ClickOnRightClickButton() 
        {
            ExtentReporting.Instance.LogInfo("Perform right click on button");

            Actions action = new Actions(driver);

            action.ContextClick(RightClick);

            action.Perform();

            return this;
        }

        public ElementsButtons ClickOnLeftClickButton() 
        {
            ExtentReporting.Instance.LogInfo("Click on the Click me button");

            LeftClick.Click();

            return this;

        }

    }
}
