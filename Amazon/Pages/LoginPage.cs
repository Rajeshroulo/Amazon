using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace Amazon.Pages
{
    public class LoginPage
    {
        public IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Hello, Sign in')]")]
        public IWebElement signin;

        [FindsBy(How = How.XPath, Using = "//input[@name='email']")]
        public IWebElement mail;

        [FindsBy(How = How.ClassName, Using = "a-button-input")]
        public IWebElement continueButton;

        [FindsBy(How = How.XPath, Using = "//input[@name='password']")]
        public IWebElement passWord;

        [FindsBy(How = How.Id, Using = "signInSubmit")]
        public IWebElement loginButton;

        [FindsBy(How = How.XPath, Using = "//div[@id='nav-xshop']//a[contains(text(),'Mobiles')]")]
        public IWebElement mobiles;

        public void AmazonLogin(string email, string password)
        {
            Thread.Sleep(5000);
            signin.Click();
            Thread.Sleep(3000);
            mail.SendKeys(email);
            continueButton.Click();
            Thread.Sleep(5000);
            passWord.SendKeys(password);
            loginButton.Click();
            Thread.Sleep(5000);
        }

        public string MobilePhones()
        {
            return mobiles.Text;
        }
    }
}
