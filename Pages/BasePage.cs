using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

public class BaseClass
{
    public IWebDriver Driver { get; private set; }

    public void Initialize()
    {
        new DriverManager().SetUpDriver(new ChromeConfig());
        Driver = new ChromeDriver();
        Driver.Manage().Window.Maximize();
    }

    public void CleanUp()
    {
        Driver.Quit();
    }
}
