using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thin_Monitor.Page_Object
{
    class Login
    {
        public Login(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        // UserID Field  
        [FindsBy(How = How.Id, Using = "AAA-AS-SI1-SE003")]
        public IWebElement UserId { get; set; }

        // Password Field   
        [FindsBy(How = How.Id, Using = "AAA-AS-SI1-SE006")]
        public IWebElement Password { get; set; }

        // Sign me in automatically Field   
        [FindsBy(How = How.Id, Using = "AAA-AS-SI1-SE008_CheckBox_TRUE")]
        public IWebElement SignMe { get; set; }

        // Sign In Button Field   
        [FindsBy(How = How.Id, Using = "AAA-AS-SI1-SE014")]
        public IWebElement SignInbtn { get; set; }

        // Cancel Button Field   
        [FindsBy(How = How.Id, Using = "AAA-AS-SI1-SE015")]
        public IWebElement Cancelbtn { get; set; }

        // Forget Password Field   
        [FindsBy(How = How.Id, Using = "AAA-AS-SI1-SE007")]
        public IWebElement ForgetPwd { get; set; }

        // Signin Field   
        [FindsBy(How = How.Id, Using = "AAA-AS-SI2-SE009")]
        public IWebElement Signin { get; set; }

        // Cancel Field   
        [FindsBy(How = How.Id, Using = "AAA-AS-SI2-SE010")]
        public IWebElement Calcel { get; set; }
    }
}
