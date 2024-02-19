using DemoQASelenium1.InteractionsTab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
