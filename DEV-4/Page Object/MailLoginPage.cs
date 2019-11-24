using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;

namespace DEV_4
{
    /// <summary>
    /// Class for login page
    /// </summary>
    public class MailLoginPage
    {
        IWebDriver Driver { get; }
        WebDriverWait Wait { get; }
        IWebElement LoginButton { get; set; }
        IWebElement PassswordButton { get; set; }
        MailLoginPageLocators Locator { get; }

        /// <summary>
        /// Class constuctor initializes fields
        /// </summary>
        /// <param name="driver"></param>
        public MailLoginPage(IWebDriver driver)
        {
            this.Driver = driver;
            this.Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
            this.Locator = new MailLoginPageLocators();
        }
        /// <summary>
        /// Goes to login page
        /// </summary>
        public void GoToPage()
        {
            Driver.Navigate().GoToUrl(Locator.PageLocator);
        }
        /// <summary>
        /// Fills username field on login page
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>

        public MailLoginPage InputUsername(string username)
        {
            Wait.Until(t => Driver.FindElements(By.XPath(Locator.LoginLocator)).Any());
            Driver.FindElement(By.XPath(Locator.LoginLocator)).SendKeys(username);
            return this;
        }
        /// <summary>
        /// Fills password field on login page
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>

        public MailMainPage InputPassword(String password)
        {
            Wait.Until(t => Driver.FindElements(By.XPath(Locator.PasswordLocator)).Any());
            Driver.FindElement(By.Id("mailbox:password")).SendKeys(password+Keys.Enter);

            return new MailMainPage(Driver);
        }
        /// <summary>
        /// Clicks on submit button
        /// </summary>
        /// <returns></returns>
        public MailLoginPage SubmitLogin()
        {
            Wait.Until(t => Driver.FindElements(By.XPath(Locator.LoginButtonLocator)).Any());
            LoginButton = Driver.FindElement(By.XPath(Locator.LoginButtonLocator));
            LoginButton.Click();

            return this;
        }
        /// <summary>
        /// Logins into account
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public MailMainPage LoginToAccount(string username, string password)
        {
            InputUsername(username);
            SubmitLogin();

            return InputPassword(password);
        }
    }
}
