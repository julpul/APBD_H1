namespace ConsoleApp1;

/*
Kontenery na gaz (G)
Kontenery przechowujące gaz przechowują dodatkową informacje na temat ciśnienia (w atmosferach).
    W momencie kiedy opróżniamy kontener na gaz - pozostawiamy 5% jego ładunku wewnątrz kontenera.
    Powinien zaimplementować interfejs IHazardNotifier. Metoda powinna pozwolić na informowanie o zajściu niebezpiecznego
zdarzenia wraz z numerem seryjnym danego kontenera.
    Jeśli masa ładunku przekroczy dopuszczalną ładowność - chcemy zwrócić błąd.
    */


public class GasContainer:Container, IHazardNotifier
{
    public double pressure { get; set; }
    public GasContainer(double loadMass, double height, double containerMass, double depth, double maxLoad,double pressure) : base(loadMass, height, containerMass, depth, maxLoad, ContainerType.GasContainer) {
        this.pressure = pressure;}

    public override void removeLoad()
    {
        load_mass = load_mass * 0.05;
    }

    public void Hazard_Notify(string msg)
    {
        Console.WriteLine(msg + " "+ this.serial_number);
    }
}