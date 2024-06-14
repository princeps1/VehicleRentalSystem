namespace VehicleRentalSystem;

public class CargoVan : Vehicle
{
    public int DriverExperience { get; private set; }

    public CargoVan(string brand, string model, int value, int experience)
        : base(brand, model, value)
    {
        DriverExperience = experience;
    }

    protected override decimal GetRentalCostLess() => 50m;
    protected override decimal GetRentalCostGreater() => 40m;
    protected override decimal GetInsurancePercentage() => 0.03m;

    public override void PriceAdjustment(ref decimal initialInsurence)
    {
        if (DriverExperience > 5)
        {
            Console.WriteLine($"Initial insurance per day: ${initialInsurence:F2}");
            decimal adjustment = initialInsurence * 0.15m;
            Console.WriteLine($"Insurence discount per day: ${adjustment:F2}");
            initialInsurence = initialInsurence - adjustment;
            Console.WriteLine($"Insurence per day: ${initialInsurence:F2}");
        }
        else
        {
            Console.WriteLine($"Insurance per day: ${initialInsurence:F2}");
        }
    }

}