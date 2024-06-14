namespace VehicleRentalSystem;

public class Car : Vehicle
{
    public int Rating { get; private set; }

    public Car(string brand, string model, int value, int rating)
        : base(brand, model, value)
    {
        if (rating >= 0 && rating <= 5)
        {
            Rating = rating;
        }
        else
        {
            throw new ArgumentOutOfRangeException("Rating must be between 0 and 5.");
        }
    }

    protected override decimal GetRentalCostLess() => 20m;
    protected override decimal GetRentalCostGreater() => 15m;
    protected override decimal GetInsurancePercentage() => 0.01m;

    public override void PriceAdjustment(ref decimal initialInsurence)
    {
        if (Rating == 5 || Rating == 4)
        {
            Console.WriteLine($"Initial insurance per day: ${initialInsurence:F2}");
            decimal adjustment = initialInsurence * 0.1m;
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