using System;
using System.Threading;
using DEV_5.Locators.Mail;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DEV_5
{
    /// <summary>
    /// Class for Mail main page.
    /// </summary>
    public class MailMainPage
    {
        IWebDriver Driver { get; }
        WebDriverWait Wait { get; }
        MailMainPageLocators Locator { get; }

        /// <summary>
        /// Class constuctor initializes fields
        /// </summary>
        /// <param name="driver"></param>
        public MailMainPage(IWebDriver driver)
        {
            this.Driver = driver;
            this.Wait = new WebDriverWait(Driver, TimeSpan.FromMinutes(1));
            this.Locator = new MailMainPageLocators();
        }

        /// <summary>
        /// reads one letters
        /// </summary>
        /// <returns></returns>
        public MailSendLetterPage ClickSendLetterButton()
        {
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(Locator.SendLetterButtonLocator)));
            Thread.Sleep(1000);
            Driver.FindElement(By.XPath(Locator.SendLetterButtonLocator)).Click();

            return new MailSendLetterPage(Driver);
        }
        /// <summary>
        /// This method checks if there is a respose to the message
        /// </summary>
        /// <returns></returns>
        public bool CheckingResponseToLetter()
        {
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(Locator.CheckingResponseToLetter)));
            return true;
        }
    }
}
