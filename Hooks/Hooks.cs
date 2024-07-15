using TechTalk.SpecFlow;

[Binding]
public class Hooks
{
    private readonly BaseClass _baseClass;

    public Hooks(BaseClass baseClass)
    {
        _baseClass = baseClass;
    }

    [BeforeScenario]
    public void BeforeScenario()
    {
        _baseClass.Initialize();
    }

    [AfterScenario]
    public void AfterScenario()
    {
        _baseClass.CleanUp();
    }
}
