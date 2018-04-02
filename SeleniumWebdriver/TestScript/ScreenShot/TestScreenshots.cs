using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.Extensions;

namespace SeleniumWebdriver.TestScript.ScreenShot
{
    [TestClass]
    public class TestScreenShots
    {
        [TestMethod]
        public void ScreenShot()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            LinkHelper.clickLink(By.LinkText("File a Bug"));
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepository.Config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepository.Config.GetPassword());
            //ButtonHelper.ClickButton(By.Id("log_in"));

            //Screenshot screen = ObjectRepository.Driver.TakeScreenshot();
            //screen.SaveAsFile("Screen.jpeg", ScreenshotImageFormat.Jpeg);
            GenericHelper.TakeScreenShot();
            GenericHelper.TakeScreenShot("Test.jpeg");


        }

    }
}
