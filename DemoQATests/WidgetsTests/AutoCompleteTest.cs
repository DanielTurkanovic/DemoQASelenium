using DemoQASelenium1.Widgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Extent;

namespace DemoQATests.WidgetsTests
{
    public class AutoCompleteTest : TestBase
    {
        [Test]
        [TestCase("bl")] 
        public void TypeMultipleColor(string color)
        {
            ExtentReporting.Instance.LogInfo("Starting test - type two color in the color field");

            var specificForm = (AutoComplete)WebForm;
                specificForm
                .AlertsSideBarTabWidget()
                .ClickOnAutoComplete()
                .TypeMultipleColorNames(color);
        }
    }
}

