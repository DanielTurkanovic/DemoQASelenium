using DemoQASelenium;
using DemoQASelenium1;
using DemoQASelenium1.AlertsFrameAndWindows;
using DemoQASelenium1.BookStoreApplicationTab;
using DemoQASelenium1.FormsTab;
using DemoQASelenium1.InteractionsTab;
using DemoQASelenium1.Widgets;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Common;
using Utils.Extent;


namespace DemoQATests
{
    public class TestBase
    {
        public enum FormType
        {
            TextBox,
            CheckBox,
            RadioButtons,
            WebTables,
            Buttons,
            Links,
            Upload,
            PracticeForm,
            BrowserWindows,
            Alerts,
            Widgets,
            AutoComplete,
            ProgressBar,
            ToolTips,
            SelectMenu,
            Sortable,
            Resizable,
            Droppable,
            Login,
            BookStoreAndProfile
          
        }
        protected IWebDriver Driver { get; private set; }
        protected Browser Browser { get; private set; }
        protected FormType CurrentFormType { get; private set; }
        protected object WebForm { get; private set; }

        [SetUp]
        public void SetUp()
        {
            ExtentReporting.Instance.CreateTest(TestContext.CurrentContext.Test.MethodName);

            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://demoqa.com/");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            Browser = new Browser(Driver);

            SetFormTypeFromTestClass();

            SwitchToForm(CurrentFormType);
        }
        private void SetFormTypeFromTestClass()
        {
            string testClassName = TestContext.CurrentContext.Test.ClassName;

            if (testClassName.Contains("ElementsTextBoxTest"))
            {
                CurrentFormType = FormType.TextBox;
            }
            else if (testClassName.Contains("CheckBoxTest"))
            {
                CurrentFormType = FormType.CheckBox;
            }
            else if (testClassName.Contains("RadioButtonClickTests"))
            {
                CurrentFormType = FormType.RadioButtons;
            }
            else if (testClassName.Contains("WebTablesTests"))
            {
                CurrentFormType = FormType.WebTables;
            }
            else if (testClassName.Contains("ButtonsTests"))
            {
                CurrentFormType = FormType.Buttons;
            }
            else if (testClassName.Contains("LinksTests"))
            {
                CurrentFormType = FormType.Links;
            }
            else if (testClassName.Contains("UploadTests"))
            {
                CurrentFormType = FormType.Upload;
            }
            else if (testClassName.Contains("PracticeFormTest"))
            {
                CurrentFormType = FormType.PracticeForm;
            }
            else if (testClassName.Contains("BrowserWindowsTests"))
            {
                CurrentFormType = FormType.BrowserWindows;
            }
            else if (testClassName.Contains("Alerts"))
            {
                CurrentFormType = FormType.Alerts;
            }
            else if (testClassName.Equals("DemoQATests.WidgetsTests.WidgetsTests"))
            {
                CurrentFormType = FormType.Widgets;
            }
            else if (testClassName.Equals("DemoQATests.WidgetsTests.AutoCompleteTest"))
            {
                CurrentFormType = FormType.AutoComplete;
            }
            else if (testClassName.Equals("DemoQATests.WidgetsTests.ProgressBarTest"))
            {
                CurrentFormType = FormType.ProgressBar;
            }
            else if (testClassName.Equals("DemoQATests.WidgetsTests.ToolTipsTest"))
            {
                CurrentFormType = FormType.ToolTips;
            }
            else if (testClassName.Equals("DemoQATests.WidgetsTests.SelectMenuTest"))
            {
                CurrentFormType = FormType.SelectMenu;
            }
            else if (testClassName.Equals("DemoQATests.InteractionsTabTests.SortableTests"))
            {
                CurrentFormType = FormType.Sortable;
            }
            else if (testClassName.Equals("DemoQATests.InteractionsTabTests.ResizableTests"))
            {
                CurrentFormType = FormType.Resizable;
            }
            else if (testClassName.Equals("DemoQATests.InteractionsTabTests.DragAndDropTests"))
            {
                CurrentFormType = FormType.Droppable;
            }
            else if (testClassName.Equals("DemoQATests.BookStoreApplicationTests.LoginTest"))
            {
                CurrentFormType = FormType.Login;
            }
            else if (testClassName.Equals("DemoQATests.BookStoreApplicationTests.BookStoreAndProfileTest"))
            {
                CurrentFormType = FormType.BookStoreAndProfile;
            }
            else
            {
                throw new InvalidOperationException("Unsupported test class");
            }
        }
        public void SwitchToForm(FormType formType)
        {
            CurrentFormType = formType;

            switch (CurrentFormType)
            {
                case FormType.TextBox:
                    WebForm = new ElementsTextBox(Driver);
                    break;
                case FormType.CheckBox:
                    WebForm = new ElementsCheckBox(Driver);
                    break;
                case FormType.RadioButtons:
                    WebForm = new ElementsRadioButtons(Driver);
                    break;
                case FormType.WebTables:
                    WebForm = new ElementsWebTables(Driver);
                    break;
                case FormType.Buttons:
                    WebForm = new ElementsButtons(Driver);
                    break;
                case FormType.Links:
                    WebForm = new ElementsLinks(Driver);
                    break;
                case FormType.Upload:
                    WebForm = new ElementsUpload(Driver);
                    break;
                case FormType.PracticeForm:
                    WebForm = new FormsPracticeForm(Driver);
                    break;
                case FormType.BrowserWindows:
                    WebForm = new BrowserWindows(Driver);
                    break;
                case FormType.Alerts:
                    WebForm = new Alerts(Driver);
                    break;
                case FormType.Widgets:
                    WebForm = new Widgets(Driver);
                    break;
                case FormType.AutoComplete:
                    WebForm = new AutoComplete(Driver);
                    break;
                case FormType.ProgressBar: 
                    WebForm = new ProgressBar(Driver);
                    break;
                case FormType.ToolTips:
                    WebForm = new ToolTips(Driver);
                    break;
                case FormType.SelectMenu:
                    WebForm = new SelectMenu(Driver);
                    break;
                case FormType.Sortable:
                    WebForm = new Sortable(Driver);
                    break;
                case FormType.Resizable: 
                    WebForm = new Resizable(Driver);
                    break;
                case FormType.Droppable:
                    WebForm = new Droppable(Driver);
                    break;
                case FormType.Login:
                    WebForm = new Login(Driver);
                    break;
                case FormType.BookStoreAndProfile:
                    WebForm = new BookStoreAndProfile(Driver);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        [TearDown]
        public void TearDown()
        {
            EndTest();
            ExtentReporting.Instance.EndReporting();
            Driver.Quit();
        }

        private void EndTest()
        {
            var testStatus = TestContext.CurrentContext.Result.Outcome.Status;
            var message = TestContext.CurrentContext.Result.Message;

            switch (testStatus)
            {
                case TestStatus.Failed:
                    ExtentReporting.Instance.LogInfo($"Test has failed {message}");
                    break;
                case TestStatus.Skipped:
                    ExtentReporting.Instance.LogFail($"Test skipped {message}");
                    break;
                default:
                    break;
            }

            //extent report
            ExtentReporting.Instance.LogScreenshot("Ending test", Browser.GetScreenshot());
        }
    }
}
