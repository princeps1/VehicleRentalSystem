namespace VehicleRentalSystem;

public class Motorcycle : Vehicle
{
    public int RiderAge { get; private set; }

    public Motorcycle(string brand, string model, int value, int rider)
        : base(brand, model, value)
    {
        RiderAge = rider;
    }

    protected override decimal GetRentalCostLess() => 15m;
    protected override decimal GetRentalCostGreater() => 10m;
    protected override decimal GetInsurancePercentage() => 0.02m;

    public override void PriceAdjustment(ref decimal initialInsurence)
    {
        if (RiderAge < 25)
        {
            Console.WriteLine($"Initial insurance per day: ${initialInsurence:F2}");
            decimal adjustment = initialInsurence * 0.2m;
            Console.WriteLine($"Insurence addition per day: ${adjustment:F2}");
            initialInsurence = initialInsurence + adjustment;
            Console.WriteLine($"Insurence per day: ${initialInsurence:F2}");
        }
        else
        {
            Console.WriteLine($"Insurance per day: ${initialInsurence:F2}");
        }
    }
}
