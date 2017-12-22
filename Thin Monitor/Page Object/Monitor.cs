using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thin_Monitor.Page_Object
{
    class Monitor
    {
        public Monitor(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        // Setting Button  
        [FindsBy(How = How.Id, Using = "button-menu")]
        public IWebElement setting_btn { get; set; }

        // Main Menu Dropdown Combo Box   
        [FindsBy(How = How.Id, Using = "main-menu-combo-box")]
        public IWebElement main_combobox { get; set; }

        // Table 1 Row_2  
        [FindsBy(How = How.XPath, Using = "//*[@id='section1']/div/div[2]/div[2]/div")]
        public IWebElement table1_row2_col1 { get; set; }

        // Multi-Table
        [FindsBy(How = How.Id, Using = "cog-menu-multiTables")]
        public IWebElement multitable { get; set; }

        // Table -2
        [FindsBy(How = How.Id, Using = "cog-menu-2table")]
        public IWebElement table_2 { get; set; }

        // Format -- General
        [FindsBy(How = How.Id, Using = "grid-menu-general")]
        public IWebElement Format_General { get; set; }

        // Format -- Number
        [FindsBy(How = How.Id, Using = "grid-menu-number")]
        public IWebElement Format_Number { get; set; }

        // Format -- Scaled Values
        [FindsBy(How = How.Id, Using = "grid-menu-scaledValues")]
        public IWebElement Format_ScaledValue { get; set; }

        // Format -- Percentage
        [FindsBy(How = How.Id, Using = "grid-menu-percentage")]
        public IWebElement Format_Percentage { get; set; }

        // Format -- Date & Time
        [FindsBy(How = How.Id, Using = "grid-menu-dateTime")]
        public IWebElement Format_Datetime { get; set; }

        // Format -- FX
        [FindsBy(How = How.Id, Using = "grid-menu-fx")]
        public IWebElement Format_FX { get; set; }

        // Format Tab-- Value Format
        [FindsBy(How = How.Id, Using = "tab-value")]
        public IWebElement Format_tab_Value { get; set; }

        // Format Tab-- Display Style
        [FindsBy(How = How.Id, Using = "tab-display")]
        public IWebElement Format_tab_Display { get; set; }

        // Format Tab-- Highlight
        [FindsBy(How = How.Id, Using = "tab-highlight")]
        public IWebElement Format_tab_Highlight { get; set; }

        // Format Tab-- Color Text
        [FindsBy(How = How.Id, Using = "tab-colorText")]
        public IWebElement Format_tab_Colortext { get; set; }

        // Format Tab-- Color Text
        [FindsBy(How = How.XPath, Using = "//*[contains(@class,'dialog')]/div/div/div[2]/div/div[2]/div[1]/div[2]/div[1]/div[3]/div[3]/label")]
        public IWebElement Format_Number_Sign { get; set; }

        // Format OK Button
        [FindsBy(How = How.XPath, Using = "//*[contains(@id,'dialog')]/div/div/div[3]/div/quartz-layout/quartz-layout[2]/coral-button[1]/button")]
        public IWebElement Format_OKbtn { get; set; }

        // Format Cancel Button
        [FindsBy(How = How.XPath, Using = "//*[contains(@id,'dialog')]/div/div/div[3]/div/quartz-layout/quartz-layout[2]/coral-button[2]/button")]
        public IWebElement Format_Cancel_btn { get; set; }


    }
}
