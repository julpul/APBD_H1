using System.Security.AccessControl;

namespace ConsoleApp1;

public class OverfillException : Exception
{
    public OverfillException(string message) : base(message) {}
}



public enum ContainerType
{
    LiquidContainer = 'L',
    GasContainer = 'G',
    RefrigeratedContainer = 'R'
}

public class Container {
    public double load_mass { get; set; }
    public double height { get; set; }
    public double container_mass { get; set; }
    public double depth { get; set; }
    public static int num_for_serial = 0;
    public string serial_number { get; private set;}
    public ContainerType containerType { get; private set; }
    public double max_load { get; set; }


    public Container(double loadMass, double height, double containerMass, double depth,  double maxLoad, ContainerType containerType)
    {
        load_mass = loadMass;
        this.height = height;
        container_mass = containerMass;
        this.depth = depth;
        max_load = maxLoad;
        this.containerType = containerType;
        serial_number = computeSerialNumber();
    }


    public string computeSerialNumber()
    {
        return "KON-" + containerType.ToString()[0].ToString() + "-" + num_for_serial++;
    }

    public virtual void removeLoad()
    {
        load_mass = 0;
    }

    public virtual void addLoad(double load, bool dangerusLoad = false)
    {
        if (load <= max_load)
        {
            load_mass = load;
        }
        else
        {
            throw new OverfillException("The load is too big");
        }
    }
    public override string ToString()
    {
        return $"Container [" +
               $"SerialNumber={serial_number}, " +
               $"Type={containerType}, " +
               $"LoadMass={load_mass}, " +
               $"ContainerMass={container_mass}, " +
               $"Height={height}, " +
               $"Depth={depth}, " +
               $"MaxLoad={max_load}" +
               $"]";
    }

}