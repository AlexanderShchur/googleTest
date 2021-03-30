using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using googleTest.helpers;

namespace googleTest.page_objects
{
    class GooglePage : InitDriver
    {
        IWebDriver driver = InitDriver.getDriver;
        IWebElement element;

        private locators.GooglePageLocators e() 
        {
            return new locators.GooglePageLocators();
        }

        public void clickSearchInput() 
        {
            element = driver.FindElement(e().searchInput);
            element.Click();
        }

        public void enterSearchQuery(String query)
        {
            element.SendKeys(query);
        }

        public void clickSearchButton() 
        {
            element = driver.FindElement(e().btnSearch);
            element.Click();
        }

    }
}
