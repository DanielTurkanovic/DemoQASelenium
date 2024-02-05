using Microsoft.Graph;
using Microsoft.Graph.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Utils.Common;
using Utils.Extent;

namespace DemoQASelenium1.BookStoreApplicationTab
{
    public class BookStoreAndProfile
    {
        IWebDriver driver;
        CommonTools commonTools;

        //locators
        IWebElement BookStoreApplicationSidebarMenuTab => driver.FindElement(By.XPath("//h5[contains(text(), 'Book Store Application')]"));
        IWebElement LoginButtonBookStoreTab => driver.FindElement(By.Id("login"));
        IWebElement UserNameInput => driver.FindElement(By.Id("userName"));
        IWebElement PasswordInput => driver.FindElement(By.Id("password"));
        IWebElement LoginButtonLoginTab => driver.FindElement(By.Id("login"));
        IWebElement ChooseBook => driver.FindElement(By.XPath("//a[contains(text(), 'Learning JavaScript Design Patterns')]"));
        IWebElement AddToYourCollectionButton => driver.FindElement(By.XPath("//button[contains(text(), 'Add To Your Collection')]"));
        IWebElement BackToBookStoreButton => driver.FindElement(By.XPath("//button[contains(text(), 'Back To Book Store')]"));
        IWebElement ProfileSidebarMenuTab => driver.FindElement(By.XPath("//span[contains(text(), 'Profile')]"));
        IWebElement LoginOnProfile => driver.FindElement(By.XPath("//a[contains(text(), 'login')]"));
        IWebElement DeletingBookFromProfile => driver.FindElement(By.Id("delete-record-undefined"));
        IWebElement ConfirmDeletingBook => driver.FindElement(By.Id("closeSmallModal-ok"));


        //constructor
        public BookStoreAndProfile(IWebDriver driver)
        {
            this.driver = driver;
            commonTools = new CommonTools(driver);
        }

        // methods
        public BookStoreAndProfile ClickBookStoreApplication()
        {
            ExtentReporting.Instance.LogInfo("Click on Book Store Application");

            commonTools.ScrollWindow(800);

            BookStoreApplicationSidebarMenuTab.Click();

            return this;
        }

        public BookStoreAndProfile LoginInBookStore(string userName, string password)
        {
            ExtentReporting.Instance.LogInfo("Fill out user name and password field");

            LoginButtonBookStoreTab.Click();
            UserNameInput.SendKeys(userName);
            PasswordInput.SendKeys(password);
            commonTools.ScrollWindow(800);
            LoginButtonLoginTab.Click();

            return this;
        }

        public BookStoreAndProfile BookChoose()
        {
            ExtentReporting.Instance.LogInfo("Adding book to colection");

            Thread.Sleep(3000);
            commonTools.ScrollWindow(800);
            ChooseBook.Click();

            commonTools.ScrollWindow(800);
            AddToYourCollectionButton.Click();
            Thread.Sleep(3000);
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
            BackToBookStoreButton.Click();

            return this;
        }

        public BookStoreAndProfile ClickOnProfile()
        {
            ExtentReporting.Instance.LogInfo("Click on profile");

            commonTools.ScrollWindow(800);
            ProfileSidebarMenuTab.Click();

            return this;
        }

        public BookStoreAndProfile LoginFromProfile()
        {
            ExtentReporting.Instance.LogInfo("Login from profile");

            LoginOnProfile.Click();

            return this;
        }

        public string BookIsAlreadyChosen()
        {
            ExtentReporting.Instance.LogInfo("Book is already chosen");

            commonTools.ScrollWindow(800);
            ChooseBook.Click();

            commonTools.ScrollWindow(800);
            AddToYourCollectionButton.Click();
            string alertText = commonTools.WaitForAlertText(driver, TimeSpan.FromSeconds(10));
            return alertText;
        }

        public string BookDeletingFromProfile()
        {
            ExtentReporting.Instance.LogInfo("Deleting book from profile");

            DeletingBookFromProfile.Click();
            ConfirmDeletingBook.Click();

            string alertText = commonTools.WaitForAlertText(driver, TimeSpan.FromSeconds(10));
            return alertText;
        }


    }
}
