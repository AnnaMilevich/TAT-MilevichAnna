using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DEV_4
{
    /// <summary>
    /// Class for main page.
    /// </summary>
    public class MailMainPage
    {

        IWebDriver Driver { get; }
        WebDriverWait Wait { get; }
        IWebElement ReadLetterButton { get; set; }
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
        /// Counts the number of unread letters
        /// </summary>
        public void  MailNumberOfUnreadLetters()
        {
            Wait.Until(t => Driver.FindElements(By.XPath(Locator.NumberOfUnreadLettersLocator)).Any());
            var numberOfUnreadLetters = Driver.FindElement(By.XPath(Locator.NumberOfUnreadLettersLocator)).Text;
            Console.WriteLine("Number of unread letters: "+numberOfUnreadLetters);
        }

        /// <summary>
        /// reads one letters
        /// </summary>
        /// <returns></returns>
        public MailMainPage ClickReadLetterButton()
        {
            Wait.Until(t => Driver.FindElements(By.CssSelector("#app-canvas > div > div.application-mail > div.application-mail__overlay > div > div.layout.layout_size_s.layout_type_2pane.layout_left-size_16.layout_left-shortcut.layout_right-size_40.layout_bordered > div.layout__main-frame > div > div > div > div > div > div.dataset-letters > div > div > div > a:nth-child(2) > div.llc__read-status > span")).Any());
            
            ReadLetterButton = Driver.FindElement(By.CssSelector("#app-canvas > div > div.application-mail > div.application-mail__overlay > div > div.layout.layout_size_s.layout_type_2pane.layout_left-size_16.layout_left-shortcut.layout_right-size_40.layout_bordered > div.layout__main-frame > div > div > div > div > div > div.dataset-letters > div > div > div > a:nth-child(2) > div.llc__read-status > span"));
            ReadLetterButton.Click();

            return this;
        }
    }
}
