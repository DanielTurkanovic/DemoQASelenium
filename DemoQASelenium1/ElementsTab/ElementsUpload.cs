﻿using OpenQA.Selenium;
using System;
using Utilities.Common;
using Utilities.Extent;

namespace DemoQASelenium1
{
    public class ElementsUpload
    {
        IWebDriver driver;
        CommonTools commonTools;

        //locators
        IWebElement ElementsSideBar => driver.FindElement(By.XPath("//h5[contains(text(), 'Elements')]"));

        IWebElement Upload => driver.FindElement(By.Id("item-7"));

        IWebElement ChooseFile => driver.FindElement(By.Id("uploadFile"));

        //constructor
        public ElementsUpload(IWebDriver driver)
        {
            this.driver = driver;
            commonTools = new CommonTools(driver);
        }

        //methods
        public ElementsUpload ElementsButtonClick()
        {
            ExtentReporting.Instance.LogInfo($"Click on the Elements");

            commonTools.ScrollWindow(500);
            ElementsSideBar.Click();

            return this;
        }

        public ElementsUpload ClickOnUpload() 
        {
            ExtentReporting.Instance.LogInfo("Click on Upload item from Elements sidebar menu");

            commonTools.ScrollWindow(500);
            Upload.Click();

            return this;
        }

        public ElementsUpload ClickOnChooseFile() 
        {
            ExtentReporting.Instance.LogInfo("Click on Choose File");

            var imageFileName = "5506088.jpg";
            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imageFileName);
            ChooseFile.SendKeys(imagePath);

            return this;
        }
    }
}
