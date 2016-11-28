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

        string str;

        [FindsBy(How = How.ClassName, Using = "ns-view-messages-item-wrap")]
        private IWebElement postList;

        [FindsBy(How = How.XPath, Using = "//*[@class = 'mail-User-Name']")]
        private IWebElement userMenu;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'b-mail-dropdown__item'][6]/a")]
        private IWebElement exit;

        public void setLoginAndPasswd(string login, string passwd) {
            new Actions(driver).SendKeys(loginField, login).SendKeys(passwdField, passwd).Build().Perform();
        }

        public void logout() {
            new Actions(driver).Click(userMenu).Click(exit).Build().Perform();
        }

        public void login() {
            passwdField.Submit();
        }

        public bool isPasswdDisplayed() {
            if (passwdField.Displayed) {
                return true;
            }
            return false;
        }

        public bool isPostDysplayed() {
            if (postList.Displayed) {
                return true;
            }
            return true;
        }
        
    }
}
