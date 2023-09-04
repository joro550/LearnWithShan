
// A delegate is just a "contract" for a method we fulfil that contract with the StartEngine and EngageClutch methods

// manual car?
var car = new Car();
car.AddOnStartAction(StartEngine);
car.AddOnStartAction(EngageClutch);
car.TurnKey();

// automatic car?
var car2 = new Car();
car2.AddOnStartAction(StartEngine);
car2.TurnKey();

void StartEngine()
{
    Console.WriteLine("Starting engine");    
}

void EngageClutch()
{
    Console.WriteLine("Engaging clutch");    
}

public class Car
{
    private AutomotiveVehicle.EngineStart OnStart;

    public void AddOnStartAction(AutomotiveVehicle.EngineStart onStartAction)
    {
        OnStart += onStartAction;
    }

    public void TurnKey()
    {
        OnStart.Invoke();
    }
}

public class AutomotiveVehicle
{
    public delegate void EngineStart();
}
