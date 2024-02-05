using DemoQASelenium1.Widgets;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Common;
using Utils.Extent;

namespace DemoQASelenium1.BookStoreApplicationTab
{
    public class Login
    {
        IWebDriver driver;
        CommonTools commonTools;

        // locators
        IWebElement BookStoreApplicationClick => driver.FindElement(By.XPath("//h5[contains(text(), 'Book Store Application')]"));
        IWebElement LoginClick => driver.FindElement(By.XPath("//span[contains(text(), 'Login')]"));
        IWebElement UserNameInput => driver.FindElement(By.Id("userName"));
        IWebElement PasswordInput => driver.FindElement(By.Id("password"));
        IWebElement LoginButtonClick => driver.FindElement(By.Id("login"));

        // constructor
        public Login(IWebDriver driver)
        {
            this.driver = driver;
            commonTools = new CommonTools(driver);
        }

        //method
        public Login ClickBookStoreApplication()
        {
            ExtentReporting.Instance.LogInfo("Click on Book Store Application");

            commonTools.ScrollWindow(800);
            BookStoreApplicationClick.Click();

            return this;
        }

        public Login ClickLogInSideBar()
        {
            ExtentReporting.Instance.LogInfo("Click on Login in side bar tab");

            commonTools.ScrollWindow(500);
            LoginClick.Click();

            return this;
        }

        public Login InputUserName(string text)
        {
            ExtentReporting.Instance.LogInfo($"Write {text} to full user name text area");

            commonTools.ScrollWindow(500);
            UserNameInput.SendKeys(text);

            return this;
        }

        public Login InputPassword(string text)
        {
            ExtentReporting.Instance.LogInfo($"Write {text} to full user name text area");

            commonTools.ScrollWindow(500);
            PasswordInput.SendKeys(text);

            return this;
        }

        public Login ClickOnLoginButton()
        {
            ExtentReporting.Instance.LogInfo("Click on Login button");

            commonTools.ScrollWindow(500);
            LoginButtonClick.Click();

            return this;
        }
    }
}
