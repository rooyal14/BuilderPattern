using System;

// Car class to be built
class Car
{
    public string Model { get; set; }
    public string Color { get; set; }
    public int NumDoors { get; set; }
    public bool HasSunroof { get; set; }
}

// Abstract Builder class
abstract class CarBuilder
{
    protected Car car = new Car();
    public abstract void SetModel();
    public abstract void SetColor();
    public abstract void SetNumDoors();
    public abstract void SetSunroof();
    public Car GetResult()
    {
        return car;
    }
}

// Concrete Builder class
class SportsCarBuilder : CarBuilder
{
    public override void SetModel()
    {
        car.Model = "Sports Car";
    }
    public override void SetColor()
    {
        car.Color = "Red";
    }
    public override void SetNumDoors()
    {
        car.NumDoors = 2;
    }
    public override void SetSunroof()
    {
        car.HasSunroof = true;
    }
}

// Director class
class CarBuildDirector
{
    public void Construct(CarBuilder builder)
    {
        builder.SetModel();
        builder.SetColor();
        builder.SetNumDoors();
        builder.SetSunroof();
    }
}

// Client code
class Program
{
    static void Main(string[] args)
    {
        CarBuilder builder = new SportsCarBuilder();
        CarBuildDirector director = new CarBuildDirector();

        director.Construct(builder);

        Car car = builder.GetResult();
        Console.WriteLine("Model: " + car.Model);
        Console.WriteLine("Color: " + car.Color);
        Console.WriteLine("Number of doors: " + car.NumDoors);
        Console.WriteLine("Has sunroof: " + car.HasSunroof);
    }
}
