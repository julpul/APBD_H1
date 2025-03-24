namespace ConsoleApp1;
/*
Kontener chłodniczy zawiera informacje na temat:
Rodzaj produktu, który może być przechowywany w danym kontenerze.
    Temperatura utrzymywana w kontenerze.
    Kontener może przechowywać wyłącznie produkty tego samego typu.
    Temperatury kontenera nie może być niższa niż temperatura wymagana przez dany rodzaj produktu.
    */
public enum Products
{
    Bananas,
    Chocolate,
    Fish,
    Meat,
    IceCream,
    FrozenPizza,
    Cheese,
    Sausages,
    Butter,
    Eggs
}
public class RefrigeratedContainer:Container, IHazardNotifier
{
    public double temperature { get; private set; }
    public Products product_type { get; set; }

    private Dictionary<string,double> temperatures= new Dictionary<string, double>
    {
        { "Bananas", 13.3 },
        { "Chocolate", 18 },
        { "Fish", 2 },
        { "Meat", -15 },
        { "Ice cream", -18 },
        { "Frozen pizza", -30 },
        { "Cheese", 7.2 },
        { "Sausages", 5 },
        { "Butter", 20.5 },
        { "Eggs", 19 }
    };

    public RefrigeratedContainer(double loadMass, double height, double containerMass, double depth, double maxLoad,Products product_type) : base(loadMass, height, containerMass, depth, maxLoad, ContainerType.RefrigeratedContainer)
    {
        this.product_type = product_type;
        temperature = get_temperature(product_type);
    }

    private double get_temperature(Products product_type)
    {
        return temperatures[product_type.ToString()];
    }
    

    public void Hazard_Notify(string msg)
    {
        throw new NotImplementedException();
    }
}