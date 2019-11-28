
namespace DEV_5.Locators.Mail
{
    /// <summary>
    /// Class with locators for Mail login page.
    /// </summary>
    public class MailLoginPageLocators
    {
        public string PageLocator { get; } = "https://mail.ru/";
        public string LoginLocator { get; } = "//input[@id = 'mailbox:login']";
        public string PasswordLocator { get; } = "//input[@id = 'mailbox:password']";
    }
}
