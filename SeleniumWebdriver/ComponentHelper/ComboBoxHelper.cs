using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.ComponentHelper
{
    public class ComboBoxHelper
    {
        private static SelectElement select;

        public static void SelectElement(By Locator, int index)
        {
            select = new SelectElement(GenericHelper.GetElement(Locator));
            select.SelectByIndex(index);
        }
        public static void SelectElement(By Locator, string visibleText)
        {
            select = new SelectElement(GenericHelper.GetElement(Locator));
            select. SelectByValue(visibleText);
        }
        public static IList<string> GetAllItems(By Locator)
        {
            select = new SelectElement(GenericHelper.GetElement(Locator));
            return select.Options.Select((x)=> x.Text).ToList();
        }
    }
}
