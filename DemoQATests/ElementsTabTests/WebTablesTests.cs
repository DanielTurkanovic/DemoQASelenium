using DemoQASelenium1;
using OpenQA.Selenium;

namespace DemoQATests
{
    public class WebTablesTests : TestBase
    {
        [Test]
        [TestCase("test@gmail.com", "180000")]
        [TestCase("test.com", "180 000")]
        public void ElementsWebTablesTest(string email, string salary)
        {
            var text = Guid.NewGuid().ToString();
            var specificForm = (ElementsWebTables)WebForm;
                specificForm
                .ElementsButtonClick()
                .WebTablesClick()
                .TextInSearchBox("Kierra")
                .ClickOnAdd()
                .FirstNameInput(text)
                .LastNameInput(text)
                .EmailInput(email)
                .AgeInput("22")
                .SalaryInput(salary)
                .DepartmentInput("It Sector")
                .SubmitClick()
                .ClearTextInSearchBox();

            if (!email.Contains("@") && salary.Length > 6)
            {
                var emailField = Driver.FindElement(By.Id("userEmail"));
                var emailBorderColor = emailField.GetCssValue("border-color");

                var salaryField = Driver.FindElement(By.Id("salary"));
                var salaryBorderColor = salaryField.GetCssValue("border-color");

                if (emailBorderColor == "rgb(220, 53, 69)" && salaryBorderColor == "rgb(220, 53, 69)")
                {
                    Assert.Pass("Email and salary fields have red colored borders, wrong inputs for email and salary fields");
                }
            }
        }
    }
}
