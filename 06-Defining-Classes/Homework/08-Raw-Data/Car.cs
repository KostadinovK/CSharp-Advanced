

public class Car
{
    public string Model { get; set; }
    public Engine Engine { get; set; }
    public Cargo Cargo { get; set; }
    public Tire[] Tires { get; set; } = new Tire[4];

    public Car(string model, double speed, double power, double weight, string type, 
        double tire1Pressure, int tire1Age, double tire2Pressure, int tire2Age, double tire3Pressure, int tire3Age,
        double tire4Pressure, int tire4Age)
    {
        Model = model;
        Engine = new Engine(speed, power);
        Cargo = new Cargo(weight, type);
        Tires[0] = new Tire(tire1Pressure, tire1Age);
        Tires[1] = new Tire(tire2Pressure, tire2Age);
        Tires[2] = new Tire(tire3Pressure, tire3Age);
        Tires[3] = new Tire(tire4Pressure, tire4Age);
    }

    public override string ToString()
    {
        return Model;
    }
}

