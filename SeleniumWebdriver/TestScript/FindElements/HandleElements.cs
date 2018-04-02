using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.TestScript.FindElements
{
    [TestClass]
    public class HandleElements
    {

        public void GetAllElements()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            IReadOnlyCollection<IWebElement> elements =  ObjectRepository.Driver.FindElements(By.XPath("//input"));
            foreach (var ele in elements)
            {
                Console.WriteLine("ID : {0}", ele.GetAttribute("id"));

            }
        }

    }
}
