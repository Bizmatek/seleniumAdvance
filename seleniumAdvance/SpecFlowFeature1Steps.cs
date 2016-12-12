using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace seleniumAdvance
{
    [Binding]
    public class SpecFlowFeature1Steps
    {

        Page page;
        IWebDriver driver;

        [Given(@"I have entered (.*) into login field")]
        public void GivenIHaveEnteredIntoLoginField(string login)
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            driver.Url = "http://yandex.ru";
            page = new Page(driver);
            page.setLogin(login);
        }

        [Given(@"I Have entered (.*) into the password field")]
        public void GivenIHaveEnteredIntoThePasswordField(string passwd)
        {
            page.setPasswd(passwd);
        }


        [When(@"I press enter into a password field")]
        public void WhenIPressEnterIntoAPasswordField()
        {
            page.login();
        }

        [Then(@"the result sould display post list")]
        public void ThenTheResultSouldDisplayPostList()
        {
            Assert.IsTrue(page.isPostDysplayed());
        }

    }
}
