﻿using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.Extent
{
    public sealed class ExtentReporting
    {
        private static ExtentReporting? instance = null;
        private static readonly object myLock = new object();
        private ExtentReports extentReports;
        private ExtentTest extentTest;

        private ExtentReporting() { }
        public static ExtentReporting Instance
        {
            get
            {
                lock (myLock)
                {
                    if (instance == null)
                    {
                        instance = new ExtentReporting();
                    }
                    return instance;
                }
            }
        }

        /// <summary>
        /// Create ExtentReporting and attach ExtentHtmlReporter
        /// </summary>
        /// <returns></returns>
        private ExtentReports StartReporting()
        {
            //var basePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var path = @"C:\Users\Microsoft\source\repos\DemoQASelenium1\Tests\Results";

            if (extentReports == null)
            {
                Directory.CreateDirectory(path);

                extentReports = new ExtentReports();
                var htmlReporter = new ExtentSparkReporter(Path.Combine(path, "report.html"));

                extentReports.AttachReporter(htmlReporter);
            }

            return extentReports;
        }

        public void CreateTest(string testName)
        {
            extentTest = StartReporting().CreateTest(testName);
        }

        public void EndReporting()
        {
            StartReporting().Flush();
        }

        public void LogInfo(string info)
        {
            extentTest.Info(info);
        }

        public void LogPass(string info)
        {
            extentTest.Pass(info);
        }

        public void LogFail(string info)
        {
            extentTest.Fail(info);
        }

        public void LogScreenshot(string info, string image)
        {
            extentTest.Info(info, MediaEntityBuilder.CreateScreenCaptureFromBase64String(image).Build());
        }
    }
}