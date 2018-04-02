using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.TestScript.Hyperlink
{
    [TestClass]
    public class TestHyperlink
    {
        [TestMethod]
        public void ClickLink()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            //IWebElement element = ObjectRepository.Driver.FindElement(By.LinkText("File a Bug"));
            //element.Click();

            LinkHelper.clickLink(By.LinkText("File a Bug"));
            //LinkHelper.clickLink(By.PartialLinkText("File"));
        }
    }
}
