using DemoQASelenium;
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
    public class ElementsRadioButtons
    {
        IWebDriver driver;
        CommonTools commonTools;

        //locators
        IWebElement ElementsSideBar => driver.FindElement(By.XPath("//h5[contains(text(), 'Elements')]"));
        IWebElement RadioButtonElement => driver.FindElement(By.Id("item-2"));
        IWebElement RadioButtonElementYes => driver.FindElement(By.XPath("//label[contains(text(),'Yes')]"));


        //constructor
        public ElementsRadioButtons(IWebDriver driver) 
        {
            this.driver = driver;
            commonTools = new CommonTools(driver);
        }

        //methods
        public ElementsRadioButtons ElementsButtonClick()
        {
            ExtentReporting.Instance.LogInfo($"Click on the Elements");

            commonTools.ScrollWindow(500);
            ElementsSideBar.Click();

            return this;
        }

        public ElementsRadioButtons RadioButtonClick()
        {
            ExtentReporting.Instance.LogInfo($"Radio button click");

            commonTools.ScrollWindow(500);
            RadioButtonElement.Click();

            return this;
        }

        public ElementsRadioButtons RadioButtonClickYes()
        {
            ExtentReporting.Instance.LogInfo($"Click on radio button yes");

            RadioButtonElementYes.Click();

            return this;
        }
    }
}
