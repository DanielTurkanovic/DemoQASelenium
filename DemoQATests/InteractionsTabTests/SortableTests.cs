using DemoQASelenium1.InteractionsTab;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Extent;

namespace DemoQATests.InteractionsTabTests
{
    public class SortableTests : TestBase
    {
        [Test]
        public void SortableListTest()
        {
            ExtentReporting.Instance.LogInfo("Starting test - SortableListTest");

            var specificForm = (Sortable)WebForm;
            specificForm
                .SelectMenuSideBarTabInteraction()
                .ClickSortable()
                .DragElementOneFromTheList();

            // Find the element container div
            IWebElement container = Driver.FindElement(By.CssSelector(".vertical-list-container"));

            // Take all elements inside container
            var elements = container.FindElements(By.CssSelector(".list-group-item.list-group-item-action"));

            // Take text of all elements
            var elementTexts = elements.Select(element => element.Text).ToList();

            // Check that "One" has been moved to the fifth place
            if (elementTexts[3] == "One")
            {
                Console.WriteLine("Element 'One' is displayed as fourth item in the list .");
            }
            else
            {
                Console.WriteLine("Element 'One' is not on number five.");
            }
        }

        [Test]
        public void SortableGridTest()
        {
            ExtentReporting.Instance.LogInfo("Starting test - SortableGridTest");

            var specificForm = (Sortable)WebForm;
            specificForm
                .SelectMenuSideBarTabInteraction()
                .ClickSortable()
                .ClickGrid()
                .DragElementOneFromTheGrid();

            // Find the element container div
            IWebElement container = Driver.FindElement(By.CssSelector(".grid-container"));

            // Take all elements inside container
            var elements = container.FindElements(By.CssSelector(".list-group-item.list-group-item-action"));

            // Take text of all elements
            var elementTexts = elements.Select(element => element.Text).ToList();

            // Check that "One" has been moved to the fifth place
            if (elementTexts[3] == "One")
            {
                Console.WriteLine("Element 'One' is displayed as fourth item in the list .");
            }
            else
            {
                Console.WriteLine("Element 'One' is not on number five.");
            }
        }
    }
}
