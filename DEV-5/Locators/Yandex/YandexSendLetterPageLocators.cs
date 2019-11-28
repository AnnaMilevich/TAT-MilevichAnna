
namespace DEV_5.Locators.Yandex
{
    /// <summary>
    /// Class with locators for Yandex send letter page.
    /// </summary>
    public class YandexSendLetterPageLocators
    {
        public string ResponseToLetterLocator { get; } = "//div[@class='mail-QuickReply-Placeholder_text']";
        public string MessageLocator { get; } = "//div[@id='cke_31_contents']";
        public string SendLetterButton { get; } = "//span[@class='ui-button-text']";
    }
}
