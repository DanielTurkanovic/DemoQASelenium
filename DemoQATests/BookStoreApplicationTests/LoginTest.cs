using DemoQASelenium1.BookStoreApplicationTab;
using OpenQA.Selenium;
using Utilities.Extent;

namespace DemoQATests.BookStoreApplicationTests
{
    public class LoginTest : TestBase
    {
        [Test]
        public void Login()
        {
            ExtentReporting.Instance.LogInfo("Starting test - login form");

            var specificForm = (Login)WebForm;
                specificForm 
                .ClickBookStoreApplication()
                .ClickLogInSideBar()
                .InputUserName("BilboB")
                .InputPassword("Samsung1!")
                .ClickOnLoginButton();

            var successfulLogin = Driver.FindElement(By.XPath("//label[contains(text(), 'BilboB')]"));
            if (successfulLogin.Displayed)
            {
                Assert.Pass("User is logged into the Bookstore Application");
            }
            else
            {
                Assert.Fail("Test failed");
            }
        }


        [Test]
        public void InvalidLogin()
        {
            ExtentReporting.Instance.LogInfo("Starting test - login form");

            var specificForm = (Login)WebForm;
                specificForm
                .ClickBookStoreApplication()
                .ClickLogInSideBar()
                .InputUserName("tester")
                .InputPassword("1111111")
                .ClickOnLoginButton();

            var invalidUserNameOrPassword = Driver.FindElement(By.XPath("//p[contains(text(), 'Invalid username or password!')]"));
            if (invalidUserNameOrPassword.Displayed)
            {
                Assert.Pass("Invalid user name or password");
            }
            else
            {
                Assert.Fail("Test failed");
            }
        }
    }
}
