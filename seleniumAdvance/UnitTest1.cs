using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace seleniumAdvance
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            Page page = new Page(driver);

            driver.Url = "http://yandex.ru";
            page.SetLoginText("super.bizmartek");
            page.SetPasswdText("nfhfyhb87KGD");

        }
    }
}
