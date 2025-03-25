using System.Runtime.InteropServices.ComTypes;
using ConsoleApp1;
using Container = System.ComponentModel.Container;

/*Stworzenie kontenera danego typu
Załadowanie ładunku do danego kontenera
Załadowanie kontenera na statek
Załadowanie listy kontenerów na statek
    Usunięcie kontenera ze statku
    Rozładowanie kontenera
    Zastąpienie kontenera na statku o danym numerze innym kontenerem
Możliwość przeniesienie kontenera między dwoma statkami
Wypisanie informacji o danym kontenerze
    Wypisanie informacji o danym statku i jego ładunku*/


LiquidContainer CocaColaContainer = new LiquidContainer(100, 250, 20, 500, 1000);
GasContainer OxygenContainer = new GasContainer(100, 250, 20, 500, 1000,10);
GasContainer carbonContainer = new GasContainer(100, 250, 20, 500, 1000,10);
GasContainer hytrogenContainer = new GasContainer(100, 250, 20, 500, 1000,10);
List<GasContainer> containers = new List<GasContainer>() { OxygenContainer, carbonContainer, hytrogenContainer };


ContainerShip ship1 = new ContainerShip(10, 10, 200);
ship1.addContainer(CocaColaContainer);
ship1.addContainers(containers);
Console.WriteLine(ship1);
ship1.removeContainer(CocaColaContainer);
Console.WriteLine(ship1);
ship1.removeAllContainers();
Console.WriteLine(ship1);
ship1.addContainer(CocaColaContainer);
ContainerShip ship2 = new ContainerShip(10, 10, 300);
ship2.addContainer(OxygenContainer);

Console.WriteLine("---------------------------------------------------------------------------");
Console.WriteLine(ship1);
Console.WriteLine(ship2);

ContainerShip.swapContainers(ship1.ShipLoad[0],ship2.ShipLoad[0],ship1,ship2);

Console.WriteLine("-------------------------after swap containers ----------------------------");
Console.WriteLine(ship1);
Console.WriteLine(ship2);

ship2.switchContainer("KON-L-0",new LiquidContainer(10, 10, 200,200,100));
Console.WriteLine(ship2);

Console.WriteLine(carbonContainer);