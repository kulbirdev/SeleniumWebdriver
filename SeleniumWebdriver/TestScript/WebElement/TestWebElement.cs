using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.TestScript.PageNavigation.WebElement
{
    [TestClass]
    public class TestWebElement
    {
        [TestMethod]
        public void GetElement()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            try
            {
                ReadOnlyCollection<IWebElement> col = ObjectRepository.Driver.FindElements(By.TagName("input"));

                Console.WriteLine("Size : {0}", col.Count);
                Console.WriteLine("Size : {0}", col.ElementAt(0));

                //ObjectRepository.Driver.FindElement(By.TagName("input"));
                //ObjectRepository.Driver.FindElement(By.ClassName("btn"));
                //ObjectRepository.Driver.FindElement(By.CssSelector("#find"));
                //ObjectRepository.Driver.FindElement(By.LinkText("File a Bug"));
                //ObjectRepository.Driver.FindElement(By.PartialLinkText("File"));
                //ObjectRepository.Driver.FindElement(By.Name("quicksearch"));
                //ObjectRepository.Driver.FindElement(By.Id("find_bottom"));
                //ObjectRepository.Driver.FindElement(By.XPath("//input[@id='find']"));

            }
            catch(NoSuchElementException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
