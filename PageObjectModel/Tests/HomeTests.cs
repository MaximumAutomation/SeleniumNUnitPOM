using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObjectModel.Drivers;
using PageObjectModel.Source.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace PageObjectModel.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    [AllureNUnit]
    [AllureSuite("Search Feature")]
    [AllureFeature("Search feature")]
    [AllureEpic("Amazon web app")]

    public class HomeTests : Driver
    {
     
        [Test(Description = "Searching for a book on amazon")]
        [AllureStory("Search Book")]
        [AllureStep("Search Book")]
        [AllureTag("Regression")]
        [Category("Regresssion")]
        public void SearchBook()
        {
            HomePage hp = new HomePage();
            _driver.Navigate().GoToUrl("http://amazon.com");
            Console.WriteLine("Navigated to amazon web app");
            hp.Search("webdriver book");
            Console.WriteLine("Searching for webdriver book");
            Console.WriteLine("Validating the title of the browser");
            Assert.True(_driver.Title.Contains("webdriver book"));

        }

        [Test(Description = "Searching for a Phone on amazon")]
        [AllureStory("Search Phone")]
        [AllureStep("Search Phone")]
        [AllureTag("Smoke")]
		[Category("Smoke")]
        public void SearchPhone()
        {
            HomePage hp = new HomePage();
            _driver.Navigate().GoToUrl("http://amazon.com");
            hp.Search("iphone 13");
            Assert.True(_driver.Title.Contains("iphone 13"));

        }

        [Test(Description = "Searching for a watch on amazon")]
        [AllureStory("Search Watch")]
        [AllureStep("Search Watch")]
        [AllureTag("Regression")]
        [Category("Regresssion")]
        public void SearchWatch()
        {
            HomePage hp = new HomePage();
            _driver.Navigate().GoToUrl("http://amazon.com");
            hp.Search("apple watch");
            Assert.True(_driver.Title.Contains("apple watch"));

        }

    }
}
