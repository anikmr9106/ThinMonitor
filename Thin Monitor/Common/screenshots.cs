﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thin_Monitor.Common
{
    class screenshots
    {
        public static void takescreenshot(string filname, IWebDriver driver)
        {
            ITakesScreenshot screenshotdriver = driver as ITakesScreenshot;
            Screenshot ScrenShot = screenshotdriver.GetScreenshot();
            ScrenShot.SaveAsFile(MyPath.screenshotpath + filname + ".jpeg", ScreenshotImageFormat.Jpeg);
        }

        public static void takescreenshot(string filname, IAlert alert)
        {
            ITakesScreenshot screenshotdriver = alert as ITakesScreenshot;
            Screenshot ScrenShot = screenshotdriver.GetScreenshot();
            ScrenShot.SaveAsFile(MyPath.screenshotpath + filname + ".jpeg", ScreenshotImageFormat.Jpeg);
        }


    }
}
