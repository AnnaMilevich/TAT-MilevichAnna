namespace DEV_5.Locators.Mail
{
    /// <summary>
    /// Class with locators for Mail login page.
    /// </summary>
    public class MailSendLetterPageLocators
    {
        public string RecipientLetterLocator { get; } = "//label[@class='container--zU301']";
        public string MessageLocator { get; } = "//body[@class='page g-default-font theme-default']";
        public string ConfirmationOfEmptyLetter { get; } = "//span[@class='c3178 c3153 c3176 c3151']";
        public string SendLetterButton { get; } ="//span[@class='button2 button2_base button2_primary button2_compact button2_hover-support js-shortcut']";
    }
}
