using DEV_5.Locators.Yandex;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace DEV_5.Yandex
{
    /// <summary>
    /// Class for Yandex main page.
    /// </summary>
    public class YandexMainPage
    {
        IWebDriver Driver { get; }
        WebDriverWait Wait { get; }
        YandexMainPageLocators Locator { get; }

        /// <summary>
        /// Class constuctor initializes fields
        /// </summary>
        /// <param name="driver"></param>
        public YandexMainPage(IWebDriver driver)
        {
            this.Driver = driver;
            this.Wait = new WebDriverWait(Driver, TimeSpan.FromMinutes(1));
            this.Locator = new YandexMainPageLocators();
        }
        /// <summary>
        /// This method reads the message
        /// </summary>
        /// <returns></returns>
        public YandexSendLetterPage ReadLetter()
        {
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(Locator.ReadLetterButtonLocator)));
            Driver.FindElement(By.XPath(Locator.ReadLetterButtonLocator)).Click();

            return new YandexSendLetterPage(Driver);
        }

    }
}
