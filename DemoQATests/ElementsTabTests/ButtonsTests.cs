using DemoQASelenium1;
using OpenQA.Selenium;
using Utilities.Extent;

namespace DemoQATests
{
    internal class ButtonsTests : TestBase
    {
        [Test]
        public void DoubleClickTests()
        {
            ExtentReporting.Instance.LogInfo("Starting test - double click");

            var specificForm = (ElementsButtons)WebForm;
                specificForm
            .ElementsButtonClick()
            .ButtonsClick()
            .ClickOnDoubleClick();

            var doubleClickMessage = Driver.FindElement(By.Id("doubleClickMessage"));
            Assert.That(doubleClickMessage.Text, Is.EqualTo("You have done a double click"));
        }

        [Test]
        public void RightClickTest()
        {
            ExtentReporting.Instance.LogInfo("Starting test - right click");

            var specificForm = (ElementsButtons)WebForm;
                specificForm
                .ElementsButtonClick()
                .ButtonsClick()
                .ClickOnRightClickButton();

            var rightClickMessage = Driver.FindElement(By.Id("rightClickMessage"));
            Assert.That(rightClickMessage.Text, Is.EqualTo("You have done a right click"));
        }

        [Test]
        public void ClickButtonTest()
        {
            ExtentReporting.Instance.LogInfo("Starting test - click button");

            var specificForm = (ElementsButtons)WebForm;
                specificForm
                .ElementsButtonClick()
                .ButtonsClick()
                .ClickOnLeftClickButton();

            var clickMessage = Driver.FindElement(By.Id("dynamicClickMessage"));
            Assert.That(clickMessage.Text, Is.EqualTo("You have done a dynamic click"));
        }
    }
}
