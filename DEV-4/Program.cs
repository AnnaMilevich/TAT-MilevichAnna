using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DEV_4
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            MailLoginPage mailLoginPage = new MailLoginPage(driver);

            mailLoginPage.GoToPage();

            MailMainPage mailMainPage = mailLoginPage.LoginToAccount("anna.milevich27", "tat2019.2");
            mailMainPage.MailNumberOfUnreadLetters();
            mailMainPage.ClickReadLetterButton().MailNumberOfUnreadLetters();

            driver.Close();
        }
    }
}
