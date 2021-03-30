using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using googleTest.test_objects;
using googleTest.helpers;

namespace googleTest
{
    public class SearchPage_TS
    {

        [SetUp]
        public void Setup()
        {
            InitDriver.Init();
        }

        [Test]
        public void GoogleSearchTest()
        {
            SearchPageTest searchPageTest = new SearchPageTest();

            searchPageTest.googleSearchTest();
        }

        [TearDown]
        public void EndTests()
        {
            InitDriver.Close(); 
        }
    }
}