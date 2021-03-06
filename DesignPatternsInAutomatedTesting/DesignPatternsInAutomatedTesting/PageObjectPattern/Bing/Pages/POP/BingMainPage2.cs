﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace DesignPatternsInAutomatedTesting.PageObjectPattern.Bing.Pages.POP
{
    public class BingMainPage2
    {
        private readonly IWebDriver browser;
        private readonly string url = @"http://www.bing.com/";

        public BingMainPage2(IWebDriver browser)
        {
            this.browser = browser;
        }

        protected BingMainPageElementMap Map
        {
            get
            {
                return new BingMainPageElementMap(this.browser);
            }
        }

        public BingMainPageValidator Validate()
        {
            return new BingMainPageValidator(this.browser);
        }

        public void Navigate()
        {
            this.browser.Navigate().GoToUrl(this.url);
        }

        public void Search(string textToType)
        {
            this.Map.SearchBox.Clear();
            this.Map.SearchBox.SendKeys(textToType);
            this.Map.GoButton.Click();
        }
    }
}
