﻿using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace Amazon.Pages
{
    public class AddressPage
    {
        public IWebDriver driver;
        public AddressPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[3]/div/div[1]/div/div/div/div[2]/div[5]/div/form/span/span/span/input")]
        public IWebElement cart;

        [FindsBy(How = How.XPath, Using = "//a[@id='hlb-ptc-btn-native']")]
        public IWebElement proceed;

        [FindsBy(How = How.XPath, Using = "/html/body/div[5]/div[2]/div/div[1]/form[1]/div/div[1]/div[2]")]
        public IWebElement address;

        public void EnterAddress()
        {
            cart.Click();
            Thread.Sleep(6000);
            proceed.Click();
            Thread.Sleep(10000);
            address.Click();
            Thread.Sleep(7000);
        }        
    }
}
