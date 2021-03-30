using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace googleTest.locators
{
    class GooglePageLocators
    {
        public By searchInput = By.Name("q");
        public By btnSearch = By.Name("btnK");
    }
}
