using DEV_5.Locators.Yandex;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace DEV_5.Yandex
{
    /// <summary>
    /// Class for Yandex login page
    /// </summary>
    public class YandexLoginPage
    {
        IWebDriver Driver { get; }
        WebDriverWait Wait { get; }
        YandexLoginPageLocators Locator { get; }

        /// <summary>
        /// Class constuctor initializes fields
        /// </summary>
        /// <param name="driver"></param>
        public YandexLoginPage(IWebDriver driver)
        {
            this.Driver = driver;
            this.Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
            this.Locator = new YandexLoginPageLocators();
        }
        /// <summary>
        /// Goes to login Yandex page
        /// </summary>
        public void GoToPage()
        {
            Driver.Navigate().GoToUrl(Locator.PageLocator);
        }

        /// <summary>
        /// Fills username field on login Yandex page
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public YandexLoginPage InputUsername(string username)
        {
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(Locator.LoginLocator)));
            Driver.FindElement(By.XPath(Locator.LoginLocator)).SendKeys(username + Keys.Enter);
            return this;
        }
        /// <summary>
        /// Fills password field on login Yandex page
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>

        public YandexMainPage InputPassword(String password)
        {
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(Locator.PasswordLocator)));
            Driver.FindElement(By.XPath(Locator.PasswordLocator)).SendKeys(password + Keys.Enter);

            return new YandexMainPage(Driver);
        }
        /// <summary>
        /// Logins into Yandex account
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public YandexMainPage LoginToAccount(string username, string password)
        {
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(Locator.LoginButtonLocator)));
            Driver.FindElement(By.XPath(Locator.LoginButtonLocator)).Click();

            InputUsername(username);

            return InputPassword(password);
        }
    }
}
