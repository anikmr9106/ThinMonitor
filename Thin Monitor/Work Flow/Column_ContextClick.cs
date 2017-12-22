using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Thin_Monitor.Common;

namespace Thin_Monitor.Work_Flow
{
    class Column_ContextClick
    {

        public static void Columnselection_1(IWebDriver driver, int colnum,int selectoptionnum)
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(driver.FindElement(By.XPath("//*[@id='section0']/div[" + colnum + "]"))).ContextClick().Build().Perform();
            Frame.Switch_to_Frames2(driver);
            Actions actions1 = new Actions(driver);
            actions1.MoveToElement(driver.FindElement(By.XPath("//*[@id='itemContainer']/eikon-layout-menu-item["+selectoptionnum+"]"))).Build().Perform();
            actions1.Click().Build().Perform();
        }

        public static void Columnselection_2(IWebDriver driver, int colnum, int selectoptionnum, int selectoption_2 , string name)
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(driver.FindElement(By.XPath("//*[@id='section0']/div[" + colnum + "]"))).ContextClick().Build().Perform();
            Frame.Switch_to_Frames2(driver);
            Actions actions1 = new Actions(driver);
            actions1.MoveToElement(driver.FindElement(By.XPath("//*[@id='itemContainer']/eikon-layout-menu-item["+ selectoptionnum+"]"))).Build().Perform();
            actions1.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Actions actions2 = new Actions(driver);
            actions2.MoveToElement(driver.FindElement(By.XPath("//*[@id='itemContainer']/eikon-layout-menu-item["+selectoption_2 +"][@item-id="+"'"+name+"'"+"]"))).Build().Perform();
            actions2.Click().Build().Perform();
        }
    }
}
