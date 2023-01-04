using OpenQA.Selenium;
using PageObjectModel.Drivers;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel.Source.Pages
{
    public class LoginPage : Driver
    {
        IWebDriver _webdriver;

        [FindsBy(How = How.Id, Using = "ap_email")]
        private IWebElement _emailtxt;

        [FindsBy(How =How.Id,Using = "continue")]
        private IWebElement _continuebtn;

        [FindsBy(How = How.Id, Using = "ap_password")]
        private IWebElement _passwordtxt;

        [FindsBy(How = How.Id, Using = "signInSubmit")]
        private IWebElement _siginbtn;
        

        public LoginPage()
        {                        
            PageFactory.InitElements(_driver, this);
        }


        public void Login(string user, string password)
        {            
            HomePage hp = new HomePage();
            Thread.Sleep(2000);
            hp._signinlink.Click();
            _emailtxt.SendKeys(user);
            _continuebtn.Click();
            _passwordtxt.SendKeys(password);
            _siginbtn.Click();
        }
    }
}
