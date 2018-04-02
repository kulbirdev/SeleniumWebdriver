using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.TestScript.RadioButton
{
    [TestClass]
    public class HandleRadioButton
    {
        [TestMethod]
        public void TestRadio()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            LinkHelper.clickLink(By.LinkText("File a Bug"));
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepository.Config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepository.Config.GetPassword());
            ButtonHelper.ClickButton(By.Id("log_in"));

            LinkHelper.clickLink(By.XPath("//div[@id='header']/ul[1]/li[9]/a"));
            LinkHelper.clickLink(By.XPath("//dt[@id='parameters']/a"));

            //IWebElement element = ObjectRepository.Driver.FindElement(By.Id("ssl_redirect-on"));
            //element.Click();

            Console.WriteLine("Selected : {0}", RadioButtonHelper.IsRadioButtonSelected(By.Id("ssl_redirect-on")));
            RadioButtonHelper.ClickRadioButton(By.Id("ssl_redirect-on"));


        }
    }
}
