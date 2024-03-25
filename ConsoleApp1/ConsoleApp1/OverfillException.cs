namespace ConsoleApp1;

public class OverfillException : Exception
{
    public void Overfill()
    {
        Console.WriteLine("Not enough space!");
    }
}