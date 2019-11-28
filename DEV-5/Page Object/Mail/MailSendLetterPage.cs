using DEV_5.Locators.Mail;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace DEV_5
{
    /// <summary>
    /// Class for Mail send letter page.
    /// </summary>
    public class MailSendLetterPage
    {
        IWebDriver Driver { get; }
        WebDriverWait Wait { get; }
        IWebElement SendLetterButton { get; set; }
        MailSendLetterPageLocators Locator { get; }

        /// <summary>
        /// Class constuctor initializes fields
        /// </summary>
        /// <param name="driver"></param>
        public MailSendLetterPage(IWebDriver driver)
        {
            this.Driver = driver;
            this.Wait = new WebDriverWait(Driver, TimeSpan.FromMinutes(1));
            this.Locator = new MailSendLetterPageLocators();
        }
        public MailMainPage SendLetter(string recipientLogin, string message)
        {
            WriteRecipientLogin(recipientLogin);
            WriteMessage(message);

            return ClickSendLetterButton();
        }
        public MailMainPage ClickSendLetterButton()
        {
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(Locator.SendLetterButton)));
            SendLetterButton = Driver.FindElement(By.XPath(Locator.SendLetterButton));
            SendLetterButton.Click();
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(Locator.ConfirmationOfEmptyLetter)));
            Driver.FindElement(By.XPath(Locator.ConfirmationOfEmptyLetter)).Click();
            return new MailMainPage(Driver);
        }
        
        public MailSendLetterPage WriteRecipientLogin(string recipientLogin)
        {
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(Locator.RecipientLetterLocator)));
            Driver.FindElement(By.XPath(Locator.RecipientLetterLocator)).SendKeys(recipientLogin + Keys.Enter);
            return this;
        }
        public MailSendLetterPage WriteMessage(string message)
        {
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(Locator.MessageLocator)));
            Thread.Sleep(100);
            Driver.FindElement(By.XPath(Locator.MessageLocator)).SendKeys(message);
            
            return this;
        }
    }
}
