using DemoQASelenium1.BookStoreApplicationTab;
using OpenQA.Selenium;
using Utilities.Extent;

namespace DemoQATests.BookStoreApplicationTests
{
    public class BookStoreAndProfileTest : TestBase
    {
        [Test]
        [Order(0)]
        [TestCase("BilboB", "Samsung1!")]
        public void AddingBookToProfile(string userName, string password)
        {
           ExtentReporting.Instance.LogInfo("Starting test - Book Store and Profile");

            var specificForm = (BookStoreAndProfile)WebForm;
                specificForm
                .ClickBookStoreApplication()
                .LoginInBookStore(userName, password)
                .BookChoose()
                .ClickOnProfile();

            var bookOnProfile = Driver.FindElement(By.XPath("//a[contains(text(), 'Learning JavaScript Design Patterns')]"));
            Assert.That(bookOnProfile.Text, Is.EqualTo("Learning JavaScript Design Patterns"));
        }

        [Test]
        [Order(1)]
        [TestCase("BilboB", "Samsung1!")]
        public void CheckingThatBookIsAddedToProfile(string userName, string password)
        {
            ExtentReporting.Instance.LogInfo("Starting test - Checking that book is added to Profile");

            var specificForm = (BookStoreAndProfile)WebForm;
            var message =
            specificForm
            .ClickBookStoreApplication()
            .LoginInBookStore(userName, password)
            .BookIsAlreadyChosen();

            var expectedAlertText = "Book already present in the your collection!";
            Assert.That(message, Is.EqualTo(expectedAlertText), "Text in Alert is not expected text");
        }

        [Test]
        [Order(2)]
        [TestCase("BilboB", "Samsung1!")]
        public void DeletingBookFromProfile(string userName, string password)
        {
            ExtentReporting.Instance.LogInfo("Starting test - Delating book from Profile");

            var specificForm = (BookStoreAndProfile)WebForm;
            var message =
                specificForm
                .ClickBookStoreApplication()
                .ClickOnProfile()
                .LoginFromProfile()
                .LoginInBookStore(userName, password)
                .BookDeletingFromProfile();

            string expectedAlertText = "Book deleted.";
            Assert.That(message, Is.EqualTo(expectedAlertText), "Text in Alert is not expected text");
        }
    }
}
