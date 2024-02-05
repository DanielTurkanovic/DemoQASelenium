using DemoQASelenium;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils.Common;
using Utils.Extent;

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

            string filePath = @"C:\Users\Microsoft\Desktop\wallpapers\5506088.jpg"; 
            ChooseFile.SendKeys(filePath);

            return this;
        }
    }
}
