using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumAdvance
{
    class Page
    {
        private IWebDriver driver;

        public Page(IWebDriver driver) {

            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }
        
        [FindsBy(How = How.Name, Using = "login")]
        private IWebElement loginField;

        [FindsBy(How = How.Name, Using = "passwd")]
        private IWebElement passwdField;

        public void SetLoginText(string text) {
        loginField.SendKeys(text);
        }

        public void SetPasswdText(string text) {
            passwdField.SendKeys(text);
            passwdField.Submit();
        }
    }
}
