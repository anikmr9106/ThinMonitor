using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Thin_Monitor.Work_Flow;

namespace Thin_Monitor
{
    [TestFixture]
    public class TestClass
    {
        static IWebDriver driver = new ChromeDriver();

        [Test]
        public void A_Installisation()
        {
            driver.Url = "https://apac1.apps.cp.thomsonreuters.com/web/apps/thinmonitor";
        }

        [Test]
        public void B_Login()
        {
            Eikon_Login login = new Eikon_Login();
            login.eikonlogin(driver);

            driver.Manage().Window.Maximize();
        }

        [Test]
        public void C_EnteringRICs()
        {
            AddRic addRic = new AddRic();
            addRic.Add_ric(driver);
            addRic.ContextClick(driver);
        }



    }
}
