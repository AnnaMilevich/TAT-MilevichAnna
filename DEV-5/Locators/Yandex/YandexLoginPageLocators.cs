
namespace DEV_5.Locators.Yandex
{
    /// <summary>
    /// Class with locators for Yandex login page.
    /// </summary>
    public class YandexLoginPageLocators
    {
        public string PageLocator { get; } = "https://yandex.by/";
        public string LoginButtonLocator { get; } = "//a[@class='button desk-notif-card__login-enter-expanded button_theme_gray i-bem button_js_inited']";
        public string LoginLocator { get; } = "//input[@id ='passp-field-login']";
        public string PasswordLocator { get; } = "//input[@id = 'passp-field-passwd']";
    }
}
