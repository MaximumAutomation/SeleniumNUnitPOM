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
    public class HomePage : Driver
    {       

        [FindsBy(How = How.Id, Using = "twotabsearchtextbox")]
        private IWebElement _searchtxtbox;

        [FindsBy(How = How.Id, Using = "nav-search-submit-button")]
        private IWebElement _searchbtn;

        [FindsBy(How = How.Id, Using = "nav-link-accountList")]
        public IWebElement _signinlink;
        

        public HomePage()
        {            
            PageFactory.InitElements(_driver, this);
        }

        public void Search(string searchtext)
        {
            Thread.Sleep(2000);
            _searchtxtbox.SendKeys(searchtext);
            Thread.Sleep(2000);
            _searchbtn.Click();
        }

    }
}
