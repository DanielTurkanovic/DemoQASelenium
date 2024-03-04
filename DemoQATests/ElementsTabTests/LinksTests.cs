using DemoQASelenium1;
using Utilities.Extent;

namespace DemoQATests
{
    internal class LinksTests : TestBase
    {
        [Test]
        public void LinksTest()
        {
            ExtentReporting.Instance.LogInfo("Starting test - links");

            var specificForm = (ElementsLinks)WebForm;
                specificForm
                .ElementsButtonClick()
                .LinksClick()
                .HomeLinkClick();

            string actualTitle = Driver.Title;
            string expectedTitle = "DEMOQA";
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
        }
    }
}
