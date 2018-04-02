using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.TestScript.PhantomJS
{
    [TestClass]
    public class TestPhantomJS
    {
        [TestMethod]
        public void TestPhantomJSDriver()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            GenericHelper.TakeScreenShot();
            LinkHelper.clickLink(By.LinkText("File a Bug"));
            GenericHelper.TakeScreenShot();
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepository.Config.GetUsername());
            GenericHelper.TakeScreenShot();
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepository.Config.GetPassword());
            GenericHelper.TakeScreenShot();
            ButtonHelper.ClickButton(By.Id("log_in"));
            GenericHelper.TakeScreenShot();

        }
    }
}
