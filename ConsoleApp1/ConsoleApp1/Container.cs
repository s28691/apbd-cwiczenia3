namespace ConsoleApp1;

public class Container : IContainer
{
    public double Height { get; set; }
    
    private double _cargoWeight;

    public Container(double cargoWeight, double height)
    {
        this._cargoWeight = cargoWeight;
        this.Height = height;
    }

    public double GetCargoWeight()
    {
        return this._cargoWeight;
    }

    public void SetCargoWeight(double NewCargoWeight)
    {
        this._cargoWeight = NewCargoWeight;
    }

    public void Unload()
    {
        throw new NotImplementedException();
    }

    public virtual void Load(double cargoWeight)
    {
        throw new OverfillException();
    }
}
