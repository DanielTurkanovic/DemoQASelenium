using AventStack.ExtentReports.MarkupUtils;
using DemoQASelenium;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Utils.Common;
using Utils.Extent;

namespace DemoQASelenium1
{
    public class ElementsWebTables
    {
        IWebDriver driver;
        CommonTools commonTools;

        //locators
        IWebElement ElementsSideBar => driver.FindElement(By.XPath("//h5[contains(text(), 'Elements')]"));
        IWebElement WebTables => driver.FindElement(By.Id("item-3"));
        IWebElement SearchBox => driver.FindElement(By.Id("searchBox"));
        IWebElement ClickOnAddButton => driver.FindElement(By.Id("addNewRecordButton"));
        IWebElement InputFirstName => driver.FindElement(By.Id("firstName"));
        IWebElement InputLastName => driver.FindElement(By.Id("lastName"));
        IWebElement InputEmail => driver.FindElement(By.Id("userEmail"));
        IWebElement InputAge => driver.FindElement(By.Id("age"));
        IWebElement InputSalary => driver.FindElement(By.Id("salary"));
        IWebElement InputDepartment => driver.FindElement(By.Id("department"));
        IWebElement ClickSubmit => driver.FindElement(By.Id("submit"));

        //constructor 
        public ElementsWebTables(IWebDriver driver)
        {
            this.driver = driver;
            commonTools = new CommonTools(driver);
        }

        //method
        public ElementsWebTables ElementsButtonClick()
        {
            ExtentReporting.Instance.LogInfo($"Click on the Elements");

            commonTools.ScrollWindow(500);
            ElementsSideBar.Click();

            return this;
        }

        public ElementsWebTables WebTablesClick()
        {
            ExtentReporting.Instance.LogInfo("Web Tables clicked");

            commonTools.ScrollWindow(500);
            WebTables.Click();

            return this;
        }

        public ElementsWebTables TextInSearchBox(string text)
        {
            ExtentReporting.Instance.LogInfo($"Typed {text} in Search box");

            SearchBox.SendKeys(text);

            return this;
        }

        public ElementsWebTables ClickOnAdd()
        {
            ExtentReporting.Instance.LogInfo("Click on the add button");

            ClickOnAddButton.Click();

            return this;
        }

        public ElementsWebTables FirstNameInput(string text)
        {
            ExtentReporting.Instance.LogInfo($"Write {text} in First Name field");

            InputFirstName.SendKeys(text);

            return this;
        }

        public ElementsWebTables LastNameInput(string text)
        {
            ExtentReporting.Instance.LogInfo($"Write {text} in Last Name field");

            InputLastName.SendKeys(text);

            return this;
        }

        public ElementsWebTables EmailInput(string text)
        {
            ExtentReporting.Instance.LogInfo($"Write {text} in Email field");

            InputEmail.SendKeys(text);

            return this;
        }

        public ElementsWebTables AgeInput(string text)
        {
            ExtentReporting.Instance.LogInfo($"Write {text} in Age field");

            InputAge.SendKeys(text);

            return this;
        }

        public ElementsWebTables SalaryInput(string text)
        {
            ExtentReporting.Instance.LogInfo($"Write {text} in Salary field");

            InputSalary.SendKeys(text);

            return this;
        }

        public ElementsWebTables DepartmentInput(string text)
        {
            ExtentReporting.Instance.LogInfo($"Write {text} in Department field");

            InputDepartment.SendKeys(text);

            return this;
        }

        public ElementsWebTables SubmitClick()
        {
            ExtentReporting.Instance.LogInfo("Click on the Submit button");

            ClickSubmit.Click();

            return this;
        }

        public ElementsWebTables ClearTextInSearchBox()
        {
            ExtentReporting.Instance.LogInfo("Cleared text in search box");

            SearchBox.Clear();

            return this;

        }
    }
}