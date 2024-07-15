using OpenQA.Selenium;

public class DashboardPage
{
    private IWebDriver _driver;

    public DashboardPage(IWebDriver driver)
    {
        _driver = driver;
    }

    private IWebElement AdminMenu => _driver.FindElement(By.XPath("//li[1]//a[1]//span[1]"));

    public void NavigateToAdmin()
    {
        AdminMenu.Click();
    }
}
