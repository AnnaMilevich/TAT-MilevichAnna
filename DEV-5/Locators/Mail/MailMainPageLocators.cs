
namespace DEV_5.Locators.Mail
{
    /// <summary>
    ///  Class with locators Mail main page.
    /// </summary>
    public class MailMainPageLocators
    {
        public string NumberOfUnreadLettersLocator { get; } = "//span[@class='badge__text']";
        public string ReadLetterButtonLocator { get; } = "//spam[@class= 'll-rs ll-rs_is-active']";
        public string CheckingResponseToLetter { get; } = "//span[text()='Anna Milevich']";
        public string SendLetterButtonLocator { get; } = "//span[@class='compose-button compose-button_white compose-button_short js-shortcut']";
    }
}
