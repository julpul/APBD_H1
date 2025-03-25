namespace ConsoleApp1;


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