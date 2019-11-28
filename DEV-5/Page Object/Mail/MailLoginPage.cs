using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using DEV_5.Locators.Mail;

namespace DEV_5
{
    /// <summary>
    /// Class for Mail login page
    /// </summary>
    public class MailLoginPage
    {
        IWebDriver Driver { get; }
        WebDriverWait Wait { get; }
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
            //Wait.Until(t => Driver.FindElements(By.XPath(Locator.LoginLocator)).Any());
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(Locator.LoginLocator)));
            Driver.FindElement(By.XPath(Locator.LoginLocator)).SendKeys(username+Keys.Enter);
            return this;
        }
        /// <summary>
        /// Fills password field on login page
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>

        public MailMainPage InputPassword(String password)
        {
            //Wait.Until(t => Driver.FindElements(By.XPath(Locator.PasswordLocator)).Any());
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(Locator.PasswordLocator)));
            Driver.FindElement(By.XPath(Locator.PasswordLocator)).SendKeys(password + Keys.Enter);

            return new MailMainPage(Driver);
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

            return InputPassword(password);
        }
    }
}
