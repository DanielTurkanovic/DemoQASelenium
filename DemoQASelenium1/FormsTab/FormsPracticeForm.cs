using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.IO;
using System.Reflection;
using Utilities.Common;
using Utilities.Extent;

namespace DemoQASelenium1.FormsTab
{
    public class FormsPracticeForm
    {
        IWebDriver driver;
        CommonTools commonTools;

        //locators
        IWebElement FormsSideBarMenuButton => driver.FindElement(By.XPath("//h5[contains(text(), 'Forms')]"));
        IWebElement PracticeForm => driver.FindElement(By.XPath("//span[contains(text(), 'Practice Form')]"));
        IWebElement InputFirstName => driver.FindElement(By.Id("firstName"));
        IWebElement InputLastName => driver.FindElement(By.Id("lastName"));
        IWebElement InputUserEmail => driver.FindElement(By.Id("userEmail"));
        IWebElement GenderRadioButton => driver.FindElement(By.Id("gender-radio-1"));
        IWebElement InputMobileNumber => driver.FindElement(By.Id("userNumber"));
        IWebElement InputDateOfBirth => driver.FindElement(By.Id("dateOfBirthInput"));
        IWebElement DataPickerPreviousMonth => driver.FindElement(By.XPath("(//button[contains(text(), 'Previous Month')])"));
        IWebElement ChooseDayOfBirth => driver.FindElement(By.XPath("(//div[contains(text(), '14')])"));
        IWebElement InputSubject => driver.FindElement(By.Id("subjectsInput"));
        IWebElement ChooseHobbies => driver.FindElement(By.Id("hobbies-checkbox-2"));
        IWebElement SelectPicture => driver.FindElement(By.Id("uploadPicture"));
        IWebElement CurrentAddress => driver.FindElement(By.Id("currentAddress"));
        IWebElement StateDropDown => driver.FindElement(By.Id("state"));
        IWebElement ChooseState => driver.FindElement(By.CssSelector("[id*='-option-1']"));
        IWebElement CityDropDown => driver.FindElement(By.Id("city"));
        IWebElement ChooseCity => driver.FindElement(By.CssSelector("[id*='option-2']"));
        IWebElement ClickOnSubmitButton => driver.FindElement(By.Id("submit"));

        //constructor
        public FormsPracticeForm(IWebDriver driver)
        {
            this.driver = driver;
            commonTools = new CommonTools(driver);
        }

        //methods
        public FormsPracticeForm ClickOnFormsSideBarMenuButton()
        {
            ExtentReporting.Instance.LogInfo("Click on Forms Form sidebar menu");

            commonTools.ScrollWindow(500);
            FormsSideBarMenuButton.Click();

            return this;
        }

        public FormsPracticeForm ClickOnPracticeForm()
        {
            ExtentReporting.Instance.LogInfo("Click on Practice Form item from Forms sidebar menu");

            PracticeForm.Click();

            return this;
        }

        public FormsPracticeForm FirstNameInput(string text)
        {
            ExtentReporting.Instance.LogInfo($"Write '{text}' to full name text area");

            InputFirstName.SendKeys(text);

            return this;
        }

        public FormsPracticeForm LastNameInput(string text)
        {
            ExtentReporting.Instance.LogInfo($"Write '{text}' to full name text area");

            InputLastName.SendKeys(text);

            return this;
        }

        public FormsPracticeForm EmailInput(string email)
        {
            ExtentReporting.Instance.LogInfo("Write in Email field");

            InputUserEmail.SendKeys(email);

            return this;
        }

        public FormsPracticeForm GenderRadioButtonClick()
        {
            ExtentReporting.Instance.LogInfo("Click on the Radio button");

            Actions action = new Actions(driver);
            action.MoveToElement(GenderRadioButton).Perform();
            action.Click().Perform();

            return this;
        }

        public FormsPracticeForm MobileNumberInput(string mobileNumber)
        {
            ExtentReporting.Instance.LogInfo("Write in Mobile Number");

            InputMobileNumber.SendKeys(mobileNumber);

            return this;
        }

        public FormsPracticeForm DateOfBirthInput()
        {
            ExtentReporting.Instance.LogInfo("Input Date of Birth");

            commonTools.ScrollWindow(500);
            InputDateOfBirth.Click();
            DataPickerPreviousMonth.Click();
            ChooseDayOfBirth.Click();

            return this;
        }

        public FormsPracticeForm SubjectInput(string text)
        {
            ExtentReporting.Instance.LogInfo($"Write '{text}' subject filed");

            InputSubject.SendKeys(text);

            return this;
        }

            public FormsPracticeForm HobbiesChoose()
        {
            ExtentReporting.Instance.LogInfo("Click on the Hobbies button");

            Actions action = new Actions(driver);
            action.MoveToElement(ChooseHobbies).Perform();
            action.Click().Perform();

            return this;
        }

        public FormsPracticeForm ClickOnSelectPicture()
        {
            ExtentReporting.Instance.LogInfo("Click on Select picture");

            var imageFileName = "5506088.jpg";
            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imageFileName);
            SelectPicture.SendKeys(imagePath);

            return this;
        }

        public FormsPracticeForm CurrentAddressInput(string text)
        {
            ExtentReporting.Instance.LogInfo($"Write '{text}' to the Current Address text area");

            CurrentAddress.SendKeys(text);

            return this;
        }

        public FormsPracticeForm StateChoose()
        {
            ExtentReporting.Instance.LogInfo("Choose and click on State from the drop down menu");

            // make zoom screen to 50%, because commercial was hiding the element 
            var html = driver.FindElement(By.TagName("html"));
            var js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.body.style.transform = 'scale(0.5)'", html);

            StateDropDown.Click();
            ChooseState.Click();

            return this;
        }

        public FormsPracticeForm CityChoose()
        {
            ExtentReporting.Instance.LogInfo("Choose and click on City from the drop down menu");

            CityDropDown.Click();
            ChooseCity.Click();

            return this;
        }

        public FormsPracticeForm SubmitButtonClick()
        {
            ExtentReporting.Instance.LogInfo("Click on Submit Button");

            ClickOnSubmitButton.Click();
            // return zoom of the screen to 100%
            var html = driver.FindElement(By.TagName("html"));
            var js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.body.style.transform = 'scale(1)'", html);

            return this;
        }

    }
}

