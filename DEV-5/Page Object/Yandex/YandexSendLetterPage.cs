using System;
using DEV_5.Locators.Yandex;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DEV_5.Yandex
{
    /// <summary>
    /// Class for Yandex send letter page.
    /// </summary>
    public class YandexSendLetterPage
    {
        IWebDriver Driver { get; }
        WebDriverWait Wait { get; }
        YandexSendLetterPageLocators Locator { get; }

        /// <summary>
        /// Class constuctor initializes fields
        /// </summary>
        /// <param name="driver"></param>
        public YandexSendLetterPage(IWebDriver driver)
        {
            this.Driver = driver;
            this.Wait = new WebDriverWait(Driver, TimeSpan.FromMinutes(1));
            this.Locator = new YandexSendLetterPageLocators();
        }
        /// <summary>
        /// This method answer the letter
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public YandexMainPage SendToLetter(string message)
        {
            WriteMessage(message);

            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(Locator.SendLetterButton)));
            Driver.FindElement(By.XPath(Locator.SendLetterButton)).Click();

            return new YandexMainPage(Driver);
        }
        /// <summary>
        /// This method is typing a message
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public YandexSendLetterPage WriteMessage(string message)
        {
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(Locator.ResponseToLetterLocator)));
            Driver.FindElement(By.XPath(Locator.ResponseToLetterLocator)).Click();

            //Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(Locator.MessageLocator)));
            //Driver.FindElement(By.XPath(Locator.MessageLocator)).SendKeys(message);

            return this;
        }
    }
}
