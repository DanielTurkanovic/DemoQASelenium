using DemoQASelenium1.InteractionsTab;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Extent;

namespace DemoQATests.InteractionsTabTests
{
    public class DragAndDropTests : TestBase
    {
        [Test]
        public void DragAndDropTest() 
        {
            ExtentReporting.Instance.LogInfo("Starting test - SortableListTest");

            var specificForm = (Droppable)WebForm;
            specificForm
                .SelectMenuSideBarTabInteraction()
                .ClickDroppable()
                .ClickSimple()
                .DragAndDrop();

            var textDropped = Driver.FindElement(By.XPath("//p[contains(text(), 'Dropped')]"));
            Assert.That(textDropped.Text, Is.EqualTo("Dropped!"));
        }
    }
}
