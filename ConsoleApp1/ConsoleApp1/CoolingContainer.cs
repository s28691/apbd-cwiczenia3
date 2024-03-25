namespace ConsoleApp1;

public class CoolingContainer : Container, IHazardNotifier
{
    private string product;
    private double temp;
    public CoolingContainer(double mass, double height, double contMass, double depth, string serialNumber, double maxMass, string product, double temp)
        :base(mass, height, contMass, depth, maxMass)
    {
        this.product = product;
        this.temp = temp;
        string SN = GetSN() + "C-" + GetId();
        setSN(SN);
    }
    
    public void Notify()
    {
        Console.WriteLine("Dangerous alert, too low temperature for product!");
    }
    public void checkTemp()
    {
        switch (product)
        {
            case "Bananas":
                if (temp < 13.3)
                    Notify();
                break;
            case "Chocolate":
                if (temp < 18)
                    Notify();
                break;
            case "Fish":
                if (temp < 2)
                    Notify();
                break;
            default:
                break;
        }
    }
}