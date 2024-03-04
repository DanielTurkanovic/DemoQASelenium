using DemoQASelenium1.InteractionsTab;
using Utilities.Extent;

namespace DemoQATests.InteractionsTabTests
{
    public class ResizableTests : TestBase
    {
        [Test]
        public void SquareResize()
        {
            ExtentReporting.Instance.LogInfo("Starting test - SortableListTest");

            var specificForm = (Resizable)WebForm;
            specificForm
                .SelectMenuSideBarTabInteraction()
                .ClickResizable()
                .ResizableSquare();
        }
    }
}
