
namespace ConsoleApp1;

public class ContainerShip
{
    public List<Container> ShipLoad = new List<Container>();
    public double maxSpeed { get; set;}
    public int maxAmoutOfContainers { get; set;}
    public double maxWeight { get; set;}

    public ContainerShip(double maxSpeed, int maxAmoutOfContainers, double maxWeight)
    {
        this.maxSpeed = maxSpeed;
        this.maxAmoutOfContainers = maxAmoutOfContainers;
        this.maxWeight = maxWeight;
    }

    public void addContainer(Container container)
    {
        ShipLoad.Add(container);
    }

    public void removeContainer(Container container)
    {
        ShipLoad.Remove(container);
    }

    public void removeAllContainers()
    {
        ShipLoad.Clear();
    }

    public void addContainers<T>(List<T> containers) where T: Container
    {
        ShipLoad.AddRange(containers);
    }
    

    public void switchContainer(string serial_number_remove, Container container_new)
    {
        this.ShipLoad = ShipLoad.Select(container => container.serial_number == serial_number_remove ? container_new : container).ToList();
    }

    public static void swapContainers(Container container1, Container container2, ContainerShip ship1,
        ContainerShip ship2)
    {
        ship1.removeContainer(container1);
        ship1.addContainer(container2);
        
        ship2.removeContainer(container2);
        ship2.addContainer(container1);
    }
    
    public override string ToString()
    {
        string info = $"Container Ship:\n" +
                      $"- Max Speed: {maxSpeed} knots\n" +
                      $"- Max Amount of Containers: {maxAmoutOfContainers}\n" +
                      $"- Max Weight: {maxWeight} tons\n" +
                      $"- Current Load ({ShipLoad.Count} containers):\n";

        foreach (Container container in ShipLoad)
        {
            info += $"  - {container}\n";
        }

        return info;
    }
    
}