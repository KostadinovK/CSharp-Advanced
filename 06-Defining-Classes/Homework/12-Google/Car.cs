
public class Car
{
    public string Model { get; set; }

    public int Power { get; set; }

    public Car(string model, int power)
    {
        Model = model;
        Power = power;
    }

    public override string ToString()
    {
        return Model + " " + Power;
    }
}

