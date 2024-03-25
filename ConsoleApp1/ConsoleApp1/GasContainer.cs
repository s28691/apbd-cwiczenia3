namespace ConsoleApp1;

public class GasContainer : Container, IHazardNotifier
{
    private double pressure;
    public GasContainer(double mass, double height, double contMass, double depth, double maxMass, double pressure)
        :base(mass, height, contMass, depth, maxMass)
    {
        this.pressure = pressure;
        string SN = GetSN() + "G-" + GetId();
        setSN(SN);
    }
    public void Unload()
    {
        double newMass = GetMass() * 0.05;
        ChangeMass(newMass);
    }
 
    public void Notify()
    {
        Console.WriteLine("Dangerous alert" + GetSN());
    }

}