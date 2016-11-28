using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace seleniumAdvance
{
    [TestFixture]
    public class UnitTest1
    {
        public static IWebDriver driver;

        [TestFixtureSetUp]
        public void init() {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        }

        [Test]
        public void TestMethod1()
        {
            Page page = new Page(driver);
            driver.Url = "http://yandex.ru";

            page.setLoginAndPasswd("super.bizmartek", "nfhfyhb87KGD");
            page.login();

            Assert.IsTrue(page.isPostDysplayed());

            page.logout();

            Assert.IsTrue(page.isPasswdDisplayed());
        }

    }
}
