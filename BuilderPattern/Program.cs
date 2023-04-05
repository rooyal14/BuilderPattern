using System;

// Car class to be built
class Vehicle
{
    public string Model { get; set; }
    public string Color { get; set; }
    public int NumDoors { get; set; }
    public bool HasSunroof { get; set; }

}

// Abstract Builder class
public interface IVehicleBuilder
{
    void SetModel(String model);
    void SetColor(String color);
    void SetNumDoors(int numDoors);
    void SetSunroof(Boolean sunroof);

}

// Concrete Builder class
class VehicleBuilder : IVehicleBuilder
{
    private Vehicle vehicle = new Vehicle();
    public void SetModel(String model)
    {
        this.vehicle.Model = model;
    }
    public void SetColor(String color)
    {
        this.vehicle.Color = color;
    }
    public void SetNumDoors(int numDoors)
    {
        this.vehicle.NumDoors = numDoors;
    }
    public void SetSunroof(Boolean sunroof)
    {
        this.vehicle.HasSunroof = sunroof;
    }
    public Vehicle GetResult()
    {
        return this.vehicle;
    }
}

// Director class
class VehicleBuildDirector
{
    public void ConstructBicycle(VehicleBuilder builder)
    {
        builder.SetModel("Bicycle");
        builder.SetNumDoors(0);
        Console.WriteLine("Cor da bicicleta? ");
        String cor = Console.ReadLine();
        builder.SetColor(cor);
    }

    public void ConstructSedan(VehicleBuilder builder)
    {
        builder.SetModel("Sedan");
        builder.SetNumDoors(4);
        Console.WriteLine("Cor do carro? ");
        String input = Console.ReadLine();
        builder.SetColor(input);
        Console.WriteLine("O carro terá teto solar? ");
        input = Console.ReadLine();
        if (input == "Sim")
            builder.SetSunroof(true);
        else
            builder.SetSunroof(false);

    }
}

// Client code
class Program
{
    static void Main(string[] args)
    {
        VehicleBuilder builder = new VehicleBuilder();
        VehicleBuildDirector director = new VehicleBuildDirector();

        director.ConstructBicycle(builder);

        

        Vehicle vehicle = builder.GetResult();


        Console.WriteLine("Model: " + vehicle.Model);
        Console.WriteLine("Color: " + vehicle.Color);
        Console.WriteLine("Number of doors: " + vehicle.NumDoors);
        Console.ReadLine();

        builder = new VehicleBuilder();

        director.ConstructSedan(builder);
        vehicle = builder.GetResult();

        Console.WriteLine("Model: " + vehicle.Model);
        Console.WriteLine("Color: " + vehicle.Color);
        Console.WriteLine("Number of doors: " + vehicle.NumDoors);
        Console.WriteLine("Has sunroof: " + vehicle.HasSunroof);
        Console.ReadLine();


    }
}
