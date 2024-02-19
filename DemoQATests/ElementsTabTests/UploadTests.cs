using DemoQASelenium1;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Extent;

namespace DemoQATests.ElementsTabTests
{
    internal class UploadTests : TestBase
    {
        [Test]
        public void UploadTest()
        {
            ExtentReporting.Instance.LogInfo("Starting test - Upload");

            var specificForm = (ElementsUpload)WebForm;
                specificForm
                .ElementsButtonClick()
                .ClickOnUpload()
                .ClickOnChooseFile();

            IWebElement downloadLink = Driver.FindElement(By.Id("uploadedFilePath"));
            Assert.That(downloadLink.Displayed, Is.True);
        }
    }
}
