using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Common;
using Utils.Extent;

namespace DemoQASelenium
{
    public class ElementsCheckBox
    {
        IWebDriver driver;
        CommonTools commonTools;

        //locators
        IWebElement ElementsSideBar => driver.FindElement(By.XPath("//h5[contains(text(), 'Elements')]"));
        IWebElement CheckBoxElement => driver.FindElement(By.XPath("//span[contains(text(), 'Check Box')]"));

        IWebElement HomeButton => driver.FindElement(By.XPath("//button[@title='Toggle']"));

        IWebElement DocumentButton => driver.FindElement(By.XPath("(//button[@title='Toggle'])[3]"));
        IWebElement OfficeButton => driver.FindElement(By.XPath("(//button[@title='Toggle'])[5]"));
        IWebElement GeneralCheckBox => driver.FindElement(By.XPath("//span[contains(text(), 'General')]"));
       
        //constructor
        public ElementsCheckBox(IWebDriver driver)
        {
            this.driver = driver;
            commonTools = new CommonTools(driver);
        }

        //method
        public ElementsCheckBox ElementsButtonClick()
        {
            ExtentReporting.Instance.LogInfo($"Click on the Elements");

            commonTools.ScrollWindow(500);
            ElementsSideBar.Click();

            return this;
        }

        public ElementsCheckBox CheckBoxElementButton()
        {
            ExtentReporting.Instance.LogInfo("Click on check box element from side menu");

            CheckBoxElement.Click();

            return this;
        }

        public ElementsCheckBox HomeButtonClick()
        {
            ExtentReporting.Instance.LogInfo("Home button clicked");

            HomeButton.Click();

            return this;
        }

        public ElementsCheckBox DocumentButtonClick()
        {
            ExtentReporting.Instance.LogInfo("Document button clicked");

            DocumentButton.Click();

            return this;
        }

        public ElementsCheckBox OfficeButtonClick()
        {
            ExtentReporting.Instance.LogInfo("Document button clicked");

            OfficeButton.Click();

            return this;
        }

        public ElementsCheckBox GeneralCheckboxClick()
        {
            ExtentReporting.Instance.LogInfo("General checkbox clicked");

            commonTools.ScrollWindow(500);
            GeneralCheckBox.Click();

            return this;
        }
    }
}
