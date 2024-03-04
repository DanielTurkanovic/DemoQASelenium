using OpenQA.Selenium;
using Utilities.Common;
using Utilities.Extent;

namespace DemoQASelenium1.Widgets
{
    public class Accordian
    {
        IWebDriver driver;
        CommonTools commonTools;

        // locators
        IWebElement WidgetsClickOn => driver.FindElement(By.XPath("//h5[contains(text(), 'Widgets')]"));
        IWebElement AccordianSideBarTab => driver.FindElement(By.XPath("//span[contains(text(), 'Accordian')]"));
        IWebElement WhyDoWeUseItClickOn => driver.FindElement(By.Id("section3Heading"));


        // constructor
        public Accordian(IWebDriver driver)
        {
            this.driver = driver;
            commonTools = new CommonTools(driver);
        }

        // method
        public Accordian AlertsSideBarTabWidget()
        {
            ExtentReporting.Instance.LogInfo("Click on Widgets");

            commonTools.ScrollWindow(500);
            WidgetsClickOn.Click();

            return this;
        }

        public Accordian ClickOnAccordian()
        {
            ExtentReporting.Instance.LogInfo("Click on Accordian from side bar menu");

            commonTools.ScrollWindow(500);
            AccordianSideBarTab.Click();

            return this;
        }

        public Accordian ClickOnWhyDoWheUseIt()
        {
            ExtentReporting.Instance.LogInfo("Click on Why Do We Use It in the Accordian Tab");

            commonTools.ScrollWindow(500);
            WhyDoWeUseItClickOn.Click();

            return this;
        }
    }
}
