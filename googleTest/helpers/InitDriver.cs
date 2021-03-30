using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Configuration;

namespace googleTest.helpers
{
    class InitDriver
    {
        private static IWebDriver webDriver;
        private static string baseURL = ConfigurationManager.AppSettings["url"];
        private static string browser = ConfigurationManager.AppSettings["browser"];
        
        private const string webDriverDirectory = "C:/Users/Sasha/Desktop/testProject/googleTest/googleTest/resources/";

        public static void Init()
        {
            switch (browser)
            {
                case "Chrome":
                    webDriver = new ChromeDriver(webDriverDirectory);
                    break;
                case "Firefox":
                    webDriver = new FirefoxDriver(webDriverDirectory);
                    break;
            }
            webDriver.Manage().Window.Maximize();
            Goto(baseURL);
        }
        public static string Title
        {
            get { return webDriver.Title; }
        }
        public static IWebDriver getDriver
        {
            get { return webDriver; }
        }
        public static void Goto(string url)
        {
            webDriver.Url = url;
        }
        public static void Close()
        {
            webDriver.Quit();
        }
    }
}
