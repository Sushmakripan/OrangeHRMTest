using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

public class AdminPage
{
    private IWebDriver _driver;

    public AdminPage(IWebDriver driver)
    {
        _driver = driver;
    }

    private IWebElement SecondRecordEditIcon => _driver.FindElement(By.XPath("//div[@class='orangehrm-container']//div[3]//div[1]//div[6]//div[1]//button[2]//i[1]"));
    private IWebElement UserRoleDropdown => _driver.FindElement(By.XPath("//div[@class = \"oxd-select-text oxd-select-text--active\"]"));
    private IWebElement UsernameField => _driver.FindElement(By.XPath("//input[@class='oxd-input oxd-input--active']"));
    private IWebElement SaveButton => _driver.FindElement(By.XPath("//button[@type='submit']"));

    public void EditSecondRecord()
    {
        SecondRecordEditIcon.Click();
    }

    public void UpdateUserRole(string role)
    {
        //var selectedRole = new SelectElement(UserRoleDropdown).SelectedOption.Text;

        IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
        js.ExecuteScript("arguments[0].value = arguments[1]", UserRoleDropdown, role);
    }

    public string GetUsername()
    {
        return UsernameField.GetAttribute("value");
    }

    public void Save()
    {
        SaveButton.Click();
    }

    public string GetUserRole(int rowIndex)
    {
        return _driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[2]/div[3]/div/div[2]/div[2]/div/div[3]")).Text;
    }
}
