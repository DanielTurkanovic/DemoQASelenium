using DemoQASelenium1;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Extent;

namespace DemoQATests
{
    public class RadioButtonClickTests : TestBase
    {
        [Test]
        public void RadioButtonTests()
        {
            ExtentReporting.Instance.LogInfo("Starting test - radio button");

            var specificForm = (ElementsRadioButtons)WebForm;
                specificForm
            .ElementsButtonClick()
            .RadioButtonClick()
            .RadioButtonClickYes();

            IWebElement spanElement = Driver.FindElement(By.XPath("//span[contains(text(), 'Yes')]"));
            Assert.That(spanElement.Text, Is.EqualTo("Yes"));
        }
    }
}
