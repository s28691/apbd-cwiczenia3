﻿namespace ConsoleApp1;

public class LiquidContainer : Container
{
    public LiquidContainer(double cargoWeight, double height) : base(cargoWeight, height)
    {
    }
    public override void Load(double cargoWeight)
    {
        base.Load(cargoWeight); 
    }
}