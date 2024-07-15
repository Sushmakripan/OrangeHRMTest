using OpenQA.Selenium;

public class LoginPage
{
    private IWebDriver _driver;

    public LoginPage(IWebDriver driver)
    {
        _driver = driver;
    }

    private IWebElement Username => _driver.FindElement(By.XPath("//input[@placeholder='Username']"));
    private IWebElement Password => _driver.FindElement(By.XPath("//input[@placeholder='Password']"));
    private IWebElement LoginButton => _driver.FindElement(By.XPath("//button[@type='submit']"));

    public void Login(string username, string password)
    {
        Username.SendKeys(username);
        Password.SendKeys(password);
        LoginButton.Click();
        Thread.Sleep(2000);
    }
}
