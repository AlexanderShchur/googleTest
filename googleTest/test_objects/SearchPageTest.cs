using System;
using System.Collections.Generic;
using System.Text;
using googleTest.page_objects;

namespace googleTest.test_objects
{
    class SearchPageTest : GooglePage
    {
        public void googleSearchTest()
        {
            clickSearchInput();
            enterSearchQuery("QA");
            clickSearchButton();
        }
    }
}
