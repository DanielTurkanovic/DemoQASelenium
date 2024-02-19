using DemoQASelenium;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Common;
using Utilities.Extent;
    
namespace DemoQASelenium1
{
    public class ElementsLinks
    {
        IWebDriver driver;
        CommonTools commonTools;

        //locators
        IWebElement ElementsSideBar => driver.FindElement(By.XPath("//h5[contains(text(), 'Elements')]"));
        IWebElement Links => driver.FindElement(By.Id("item-5"));

        IWebElement HomeLink => driver.FindElement(By.Id("simpleLink"));

        //constructor
        public ElementsLinks(IWebDriver driver)
        {
            this.driver = driver;
            commonTools = new CommonTools(driver);
        }

        //methods
        public ElementsLinks ElementsButtonClick()
        {
            ExtentReporting.Instance.LogInfo($"Click on the Elements");

            commonTools.ScrollWindow(500);
            ElementsSideBar.Click();

            return this;
        }

        public ElementsLinks LinksClick() 
        {
            ExtentReporting.Instance.LogFail("Click on Links item from Elements sidebar menu");

            commonTools.ScrollWindow(500);
            Links.Click();

            return this;
        }

        public ElementsLinks HomeLinkClick() 
        {
            ExtentReporting.Instance.LogInfo("Click on Home link and switch to the next tab");

            HomeLink.Click();

            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);

            return this;
        }
    }
}
