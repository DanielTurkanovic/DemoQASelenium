using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using Utilities.Common;
using Utilities.Extent;

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
        IWebElement SearchBoxField => driver.FindElement(By.Id("searchBox"));
        IWebElement ChooseBook => driver.FindElement(By.XPath("//a[contains(text(), 'Learning JavaScript Design Patterns')]"));
        IWebElement AddToYourCollectionButton => driver.FindElement(By.XPath("//button[contains(text(), 'Add To Your Collection')]"));
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

            commonTools.ScrollWindow(500);
            LoginButtonBookStoreTab.Click();
            UserNameInput.SendKeys(userName);
            PasswordInput.SendKeys(password);
            commonTools.ScrollWindow(800);
            LoginButtonLoginTab.Click();

            return this;
        }

        public BookStoreAndProfile BookChoose()
        {
            ExtentReporting.Instance.LogInfo("Adding book to collection");
            
            SearchBoxField.SendKeys("Learning");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            wait.Until(ExpectedConditions.ElementToBeClickable(ChooseBook));
            ChooseBook.Click();

            commonTools.ScrollWindow(800);

            wait.Until(ExpectedConditions.ElementToBeClickable(AddToYourCollectionButton));
            AddToYourCollectionButton.Click();

            wait.Until(ExpectedConditions.AlertIsPresent());
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();

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
         
            SearchBoxField.SendKeys("Learning");
            ChooseBook.Click();

            commonTools.ScrollWindow(800);
            AddToYourCollectionButton.Click();
          
            string alertText = commonTools.WaitForAlertText(driver, TimeSpan.FromSeconds(5));
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
