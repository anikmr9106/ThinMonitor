using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thin_Monitor.Common
{
    class Frame
    {


        public static void Switch_to_Frames1(IWebDriver driver)
        {
            Thread.Sleep(TimeSpan.FromSeconds(3));
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(TimeSpan.FromSeconds(3));
            driver.SwitchTo().Frame("AppFrame");
            //driver.SwitchTo().Frame("EikonNowMarker");
            driver.SwitchTo().Frame("internal");
            driver.SwitchTo().Frame("AppFrame");
            driver.SwitchTo().Frame("EikonNowMarker");
            driver.SwitchTo().Frame("AppFrame");
        }

        public static void Switch_to_Frames2(IWebDriver driver)
        {
            Thread.Sleep(TimeSpan.FromSeconds(3));
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(TimeSpan.FromSeconds(3));
            driver.SwitchTo().Frame("AppFrame");
            //driver.SwitchTo().Frame("EikonNowMarker");
            driver.SwitchTo().Frame("internal");
            driver.SwitchTo().Frame("AppFrame");
            //driver.SwitchTo().Frame("EikonNowMarker");
            //driver.SwitchTo().Frame("AppFrame");
        }


    }
}
