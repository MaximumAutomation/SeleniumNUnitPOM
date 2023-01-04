using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using PageObjectModel.Source.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;
using PageObjectModel.Drivers;
using NUnit.Framework;
using NUnit.Allure.Core;
using NUnit.Allure.Attributes;
using NUnit.Framework.Interfaces;
using Allure.Commons;

namespace PageObjectModel.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    [AllureNUnit]
    [AllureSuite("Login Feature")]
    [AllureFeature("Login Feature")]
    [AllureEpic("Amazon web app")]

    public class LoginTest : Driver
    {

        [Test(Description = "Login with Invalid Password")]
        [AllureStory("Login with Invalid Password")]
        [AllureStep("Login with Invalid Password")]
        [AllureTag("Regression")]
        [Category("Regresssion")]
        public void InvalidPassword()
        {
            LoginPage lp = new LoginPage();
            _driver.Navigate().GoToUrl("http://amazon.com");
            lp.Login("test@gmail.com", "pass");
            Assert.True(_driver.Title.Contains("Amazon Sign-In"));
        }

        [Test(Description = "Login with Invalid Username")]
        [AllureStory("Login with Invalid Username")]
        [AllureStep("Login with Invalid Username")]
        [AllureTag("Smoke")]
		[Category("Smoke")]
        public void InvalidUserName()
        {
            LoginPage lp = new LoginPage();
            _driver.Navigate().GoToUrl("http://amazon.com");
            lp.Login("test1@gmail.com", "pass");
            Assert.True(_driver.Title.Contains("Amazon Sign-In"));
        }

        [Test(Description = "Login with Invalid Username and Password")]
        [AllureStory("Login with Invalid Username and Password")]
        [AllureStep("Login with Invalid Username and Password")]
        [AllureTag("Regresssion")]
        [Category("Regresssion")]
        public void InvalidUserPassword()
        {
            LoginPage lp = new LoginPage();
            _driver.Navigate().GoToUrl("http://amazon.com");
            lp.Login("test@gmaila.com", "pass1");
            Assert.True(_driver.Title.Contains("Amazon Sign-In"));
        }


        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                byte[] content = ((ITakesScreenshot)_driver).GetScreenshot().AsByteArray; 
                AllureLifecycle.Instance.AddAttachment("Failed Screenshot", "image/png",content);
            }
        }
    }
}
