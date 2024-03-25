// See https://aka.ms/new-console-template for more information

using ConsoleApp1;

List<ContainerShip> containerShips = new List<ContainerShip>();
while (true)
{
    Console.Clear();
    Console.WriteLine("Możliwe akcje:");
    Console.WriteLine("1. Dodaj kontenerowiec");
    Console.WriteLine("2. Usuń kontenerowiec");
    Console.WriteLine("3. Dodaj kontener");
    Console.WriteLine("4. Załaduj kontener na statek");
    string input = Console.ReadLine();
    switch (input)
    {
        case "1":
            Console.WriteLine(
                "Podaj parametry kontenerowca (prędkość, maksymalna liczba kontenerów, maksymalna masa):");
            double speed = double.Parse(Console.ReadLine());
            int maxContainerNum = int.Parse(Console.ReadLine());
            double maxWeight = double.Parse(Console.ReadLine());
            containerShips.Add(new ContainerShip(speed, maxContainerNum, maxWeight));
            break;
        case "2":
            Console.WriteLine("Wybierz kontenerowiec do usunięcia:");
            Console.WriteLine("Wybierz numer kontenerowca do usunięcia:");
            int shipNumber = int.Parse(Console.ReadLine());

            if (shipNumber >= 1 && shipNumber <= containerShips.Count)
            {
                containerShips.RemoveAt(shipNumber - 1);
                Console.WriteLine($"Kontenerowiec numer {shipNumber} został usunięty.");
            }
            else
            {
                Console.WriteLine("Nieprawidłowy numer kontenerowca. Wciśnij dowolny klawisz, aby kontynuować.");
                Console.ReadKey();
            }

            break;
            break;
        case "3":
            Console.WriteLine("Podaj parametry kontenera (masa, wysokość, itd.):");
            break;
        case "4":
            Console.WriteLine("Wybierz kontener do załadowania na statek:");
            break;
        default:
            Console.WriteLine("Nieprawidłowy wybór. Wciśnij dowolny klawisz, aby kontynuować.");
            Console.ReadKey();
            break;
    }
}

