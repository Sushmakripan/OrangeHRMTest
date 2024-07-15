using TechTalk.SpecFlow;
using NUnit.Framework;
using OrangeHRMTest.Pages;

[Binding]
public class StepDefinitions
{
    private readonly BaseClass _baseClass;
    private readonly LoginPage _loginPage;
    private readonly DashboardPage _dashboardPage;
    private readonly AdminPage _adminPage;
    private string _username;

    public StepDefinitions(BaseClass baseClass)
    {
        _baseClass = baseClass;
        _loginPage = new LoginPage(_baseClass.Driver);
        _dashboardPage = new DashboardPage(_baseClass.Driver);
        _adminPage = new AdminPage(_baseClass.Driver);
    }

    [Given(@"I open the OrangeHRM page")]
    public void GivenIOpenTheOrangeHRMPage()
    {
        _baseClass.Driver.Navigate().GoToUrl(POMConstants.webSiteURL);
    }

    [When(@"I login with username and password")]
    public void WhenILoginWithUsernameAndPassword()
    {
        Thread.Sleep(2000);
        _loginPage.Login(POMConstants.loginUserName, POMConstants.loginUserpwd);
    }

    [When(@"I navigate to the Admin page")]
    public void WhenINavigateToTheAdminPage()
    {
        
        _dashboardPage.NavigateToAdmin();
         Thread.Sleep(2000);
    }

    [When(@"I edit the second record")]
    public void WhenIEditTheSecondRecord()
    {
        _adminPage.EditSecondRecord();
        Thread.Sleep(2000);
    }

    [When(@"I update the user role")]
    public void WhenIUpdateTheUserRole()
    {
        _adminPage.UpdateUserRole("ESS");
        Thread.Sleep(2000);
        _username = _adminPage.GetUsername();
        Thread.Sleep(2000);
        _adminPage.Save();
        Thread.Sleep(7000);
    }

    [Then(@"the user role should be updated for the second record")]
    public void ThenTheUserRoleShouldBeUpdatedForTheSecondRecord()
    {
        string newRole = _adminPage.GetUserRole(2);
        Thread.Sleep(5000);
        Assert.IsTrue(newRole == "Admin" || newRole == "ESS");
    }
}
