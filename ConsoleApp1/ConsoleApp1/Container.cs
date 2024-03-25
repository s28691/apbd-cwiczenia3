namespace ConsoleApp1;

public class Container : IContainer
{
    private static int num = 0;
    private int ContId;
    private double mass;
    private double height;
    private double contMass;
    private double depth;
    private string serialNumber;
    private double maxMass;

    public Container(double mass, double height, double contMass, double depth, double maxMass)
    {
        this.ContId = num;
        num++;
        this.mass = mass;
        this.height = height;
        this.contMass = contMass;
        this.depth = depth;
        this.maxMass = maxMass;
        this.serialNumber = "KON-";
    }
    public void Unload()
    {
        this.mass = 0;
    }

    public void Load(double mass)
    {
        double newMass = this.mass + mass;
        if (newMass > maxMass)
        {
            throw new OverfillException();
        }
        else
        {
            this.mass = newMass;
        }

    }
    public override string ToString()
    {
        return $"Container ID: {ContId}, Mass: {mass}, Height: {height}, ContMass: {contMass}, Depth: {depth}, Serial Number: {serialNumber}, Max Mass: {maxMass}";
    }
    public double GetMaxMass()
    {
        return this.maxMass;
    }
    
    public double GetMass()
    {
        return this.mass;
    }
    
    public int GetId()
    {
        return this.ContId;
    }

    public string GetSN()
    {
        return this.serialNumber;
    }

    public void setSN(string SN)
    {
        this.serialNumber = SN;
    }

    public void ChangeMass(double mass)
    {
        this.mass = mass;
    }
}
