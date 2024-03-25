namespace ConsoleApp1;

public class ContainerShip
{
    private Container[] containers;
    private double maxSpeed;
    private int maxContainerCount;
    private double maxCargoWeight;
    public ContainerShip(Container[] containers, double maxSpeed, int maxContainerCount, double maxCargoWeight)
    {
        this.containers = containers;
        this.maxSpeed = maxSpeed;
        this.maxContainerCount = maxContainerCount;
        this.maxCargoWeight = maxCargoWeight;
    }
    public void LoadSingle(Container cont)
    {
        int newSize = containers.Length + 1;
            Container[] temp = new Container[newSize];
            for (int i = 0; i < newSize; i++)
            {
                if (i < containers.Length)
                {
                    temp[i] = containers[i];
                }
                else
                {
                    temp[i] = cont;
                }
            }
            this.containers = temp;
        }
    public void LoadList(Container[] list)
    {
        for (int i = 0; i < list.Length; i++)
        {
            LoadSingle(list[i]);
        }
        
    }
    public void RemoveContainer(string SN)
    {
        for (int i = 0; i < containers.Length; i++)
        {
            if (SN.Equals(containers[i].GetSN()))
            {
                containers[i] = null;
            }
        }
    }
    public void MoveContainer(string SN, ContainerShip ship)
    {
        for (int i = 0; i < containers.Length; i++)
        {
            if (SN.Equals(containers[i].GetSN()))
            {
                ship.LoadSingle(containers[i]);
                containers[i] = null;
            }
        }
    }
    public void PrintShipInfo()
    {
        Console.WriteLine("Container Ship Information:");
        Console.WriteLine("Max Speed: " + maxSpeed);
        Console.WriteLine("Max Container Count: " + maxContainerCount);
        Console.WriteLine("Max Cargo Weight: " + maxCargoWeight);

        Console.WriteLine("Containers:");
        if (containers != null)
        {
            foreach (Container container in containers)
            {
                Console.WriteLine(container);
            }
        }
        else
        {
            Console.WriteLine("No containers loaded.");
        }
    }
    
    }
