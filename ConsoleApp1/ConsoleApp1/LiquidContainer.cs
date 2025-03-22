using System.ComponentModel;

namespace ConsoleApp1;

public class LiquidContainer : Container, IHazardNotifier
{
    public LiquidContainer(double loadMass, double height, double containerMass, double depth, double maxLoad) : base(loadMass, height, containerMass, depth, maxLoad, ContainerType.LiquidContainer){}


    public void Hazard_Notify(string msg)
    {
        Console.WriteLine(msg + " "+ this.serial_number);
    }

    public override void addLoad(double load, bool dengerusLoad = false)
    {
        base.addLoad(load, dengerusLoad);
        if (dengerusLoad && load >= this.max_load*0.5 ){
            Console.WriteLine("dengerus load exceeded maximum load. max 0.5 max load");
        }else if (!dengerusLoad && load >= this.max_load * 0.9)
        {
            Console.WriteLine("not dengerus load exceeded maximum load. max 0.9 max load");
        }
        
    }
}