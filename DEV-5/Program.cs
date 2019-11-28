using DEV_5.Yandex;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace DEV_5
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driverMail = new ChromeDriver();
            MailLoginPage mailLoginPage = new MailLoginPage(driverMail);

            mailLoginPage.GoToPage();

            MailMainPage mailMainPage = mailLoginPage.LoginToAccount("anna.milevich27", "tat2019.2");
            MailSendLetterPage mailSendLetterPage = mailMainPage.ClickSendLetterButton();
            mailSendLetterPage.SendLetter("anna.milevich27@yandex.ru", "Hey");

            IWebDriver driverYandex = new ChromeDriver();
            YandexLoginPage yandexLoginPage = new YandexLoginPage(driverYandex);
            yandexLoginPage.GoToPage();
            YandexMainPage yandexMainPage = yandexLoginPage.LoginToAccount("anna.milevich27", "tat2019.2");
            YandexSendLetterPage yandexSendLetterPage= yandexMainPage.ReadLetter();
            yandexSendLetterPage.SendToLetter("hey");

            bool answer=mailMainPage.CheckingResponseToLetter();

        }
    }
}
