using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Thin_Monitor.Common;
using Thin_Monitor.Page_Object;


namespace Thin_Monitor.Work_Flow
{
    class AddRic
    {
        static ExtentTest test = ExtentReport.ReportStart("Entering RICs", "Adding RICs and Chain");

        public void Add_ric(IWebDriver driver )
        {
            Page_Object.Monitor mon = new Page_Object.Monitor(driver);

            try
            {
                //Adding RICs From List 
                string part1 = "//*[@id='section1']/div/div[2]/div[";
                string part2 = "]/div";
                int i = 1;
                List<string> riclist = RICsList.riclist();
                foreach (string j in riclist)
                {
                    string fullpath = part1 + i + part2;
                    Actions act_rowi = new Actions(driver);
                    act_rowi.MoveToElement(driver.FindElement(By.XPath(fullpath))).DoubleClick().Click().SendKeys(j).SendKeys(Keys.Enter).Build().Perform();
                    i++;
                }

                mon.setting_btn.Click();
                Actions actions_multitable = new Actions(driver);
                actions_multitable.MoveToElement(mon.multitable).Click().MoveToElement(mon.table_2).Click().Build().Perform();

                Thread.Sleep(TimeSpan.FromSeconds(5));
                Actions act_chain = new Actions(driver);
                act_chain.MoveToElement(driver.FindElement(By.XPath("//*[@id='section3']/div/div[2]/div[1]"))).DoubleClick().Click().SendKeys(".FTSE").SendKeys(Keys.Enter).Build().Perform();
                Thread.Sleep(TimeSpan.FromSeconds(4));
                driver.FindElement(By.XPath("//*[@id='section3']/div/div[2]/div[1]/div/span/span[1]")).Click();

                ExtentReport.ReportLog(test, "Pass", "Successfully RICs have been added", driver);
            }

            catch
            {
                ExtentReport.ReportLog(test, "Fail", "Failed to Add RICs", driver);
            }

           
        }


        public void ContextClick(IWebDriver driver)
        {

            try
            {
                Column_ContextClick.Columnselection_1(driver, 7, 2);

                Page_Object.Monitor mon = new Page_Object.Monitor(driver);
                Frame.Switch_to_Frames1(driver);
                mon.Format_Number.Click();
                Thread.Sleep(TimeSpan.FromSeconds(3));
                mon.Format_Number_Sign.Click();
                mon.Format_OKbtn.Click();

                ExtentReport.ReportLog(test, "Pass", "Successfully Formated", driver);
            }

            catch
            {
                ExtentReport.ReportLog(test, "Fail", "Formate Failed", driver);
            }

            //try
            //{
                Column_ContextClick.Columnselection_2(driver, 6, 3,2,"sortAscEveryUpdate");

               ExtentReport.ReportLog(test, "Pass", "Successfully Sorted in Ascending Order", driver);
            //}

            //catch
            //{
              //  ExtentReport.ReportLog(test, "Fail", "Formate Failed", driver);
            //}

            ExtentReport.ReportStop(test);
        }
    }
}
