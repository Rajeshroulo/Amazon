using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Amazon.Pages
{
    public class HomePage
    {
        public IWebDriver driver;
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//input[@id='twotabsearchtextbox']")]
        public IWebElement searchBox;

        [FindsBy(How = How.XPath, Using = "//header/div[@id='navbar']/div[@id='nav-belt']/div[2]/div[1]/form[1]/div[3]/div[1]/span[1]/input[1]")]
        public IWebElement search;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Samsung Guru Music 2 (Gold)')]")]
        public IWebElement samsung;
        
        [FindsBy(How = How.XPath, Using = "//a[@id='buybox-see-all-buying-choices-announce']")]
        public IWebElement option;
        
        public void SearchMobile()
        {
            searchBox.SendKeys("samsung guru music 2");
            Thread.Sleep(2000);
            search.Click();
            Thread.Sleep(8000);
            samsung.Click();
            List<string> windows = driver.WindowHandles.ToList();
            foreach (var mobilewindow in windows)
            {
                driver.SwitchTo().Window(mobilewindow);
            }
            Thread.Sleep(6000);
            option.Click();
            Thread.Sleep(7000);
        }
    }
}
