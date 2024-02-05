using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Threading;
using Utils.Common;
using Utils.Extent;

namespace DemoQASelenium
{
    public class ElementsTextBox
    {
        IWebDriver driver;
        CommonTools commonTools;

        //locators
        IWebElement ElementsSideBar => driver.FindElement(By.XPath("//h5[contains(text(), 'Elements')]"));
        IWebElement TextBoxElement => driver.FindElement(By.XPath("//span[contains(text(), 'Text Box')]"));
        IWebElement FullNameInput => driver.FindElement(By.Id("userName"));
        IWebElement EmailInput => driver.FindElement(By.Id("userEmail"));
        IWebElement CurrentAddressTextArea => driver.FindElement(By.Id("currentAddress"));
        IWebElement PermanentAddressTextArea => driver.FindElement(By.Id("permanentAddress"));
        IWebElement SubmitButton => driver.FindElement(By.Id("submit"));

        //constructor
        public ElementsTextBox(IWebDriver driver)
        {
            this.driver = driver;
            commonTools = new CommonTools(driver);
        }

        //methods
        public ElementsTextBox ElementsButtonClick()
        {
            ExtentReporting.Instance.LogInfo($"Click on the Elements");

            commonTools.ScrollWindow(500);

            commonTools.HighlightElement(ElementsSideBar, driver);

            ElementsSideBar.Click();

            return this;
        }

        public ElementsTextBox TextBoxElementButton()
        {
            ExtentReporting.Instance.LogInfo($"Click on text box element from side menu");

            commonTools.HighlightElement(TextBoxElement, driver);

            TextBoxElement.Click();

            return this;
        }

        public ElementsTextBox FullNameInputText(string text)
        {
            ExtentReporting.Instance.LogInfo($"Write '{text}' to full name text area");

            commonTools.HighlightElement(FullNameInput, driver);

            FullNameInput.SendKeys(text);

            return this;
        }

        public ElementsTextBox EmailInputText(string text)
        {
            ExtentReporting.Instance.LogInfo($"Write '{text}' to full name text area");

            commonTools.HighlightElement(EmailInput, driver);

            EmailInput.SendKeys(text);

            return this;
        }

        public ElementsTextBox CurrentAddressTextAreaText(string text)
        {
            ExtentReporting.Instance.LogInfo($"Write '{text}' to full name text area");

            commonTools.HighlightElement(CurrentAddressTextArea, driver);

            CurrentAddressTextArea.SendKeys(text);

            return this;
        }

        public ElementsTextBox PermanentAddressTextAreaText(string text)
        {
            ExtentReporting.Instance.LogInfo($"Write '{text}' to full name text area");

            commonTools.HighlightElement(PermanentAddressTextArea, driver);

            PermanentAddressTextArea.SendKeys(text);

            return this;
        }

        public ElementsTextBox SubmitButtonForm()
        {
            ExtentReporting.Instance.LogInfo($"Button clicked");

            commonTools.ScrollWindow(500);

            commonTools.HighlightElement(SubmitButton, driver);

            SubmitButton.Click();

            return this;
        }
    }
}
