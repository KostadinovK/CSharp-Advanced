
public class Car
{
    public string Model { get; private set; }

    public double FuelAmount { get; private set; }

    public double FuelConsumption { get; private set; }

    public int DistanceTraveled { get; private set; }

    public Car(string model, double fuelAmount, double fuelConsumption)
    {
        Model = model;
        FuelAmount = fuelAmount;
        FuelConsumption = fuelConsumption;
        DistanceTraveled = 0;
    }

    public bool Travel(int distance)
    {
        if (FuelAmount >= distance * FuelConsumption)
        {
            FuelAmount -= distance * FuelConsumption;
            DistanceTraveled += distance;
            return true;
        }

        return false;
    }

    public override string ToString()
    {
        return Model + " " + $"{FuelAmount:f2}" + " " + DistanceTraveled;
    }
}

