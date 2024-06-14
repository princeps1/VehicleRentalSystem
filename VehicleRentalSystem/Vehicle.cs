namespace VehicleRentalSystem;

public abstract class Vehicle
{
    public string Brand { get; protected set; }
    public string Model { get; protected set; }
    public int Value { get; protected set; }

    public Vehicle(string brand, string model, int value)
    {
        Brand = brand;
        Model = model;
        Value = value;
    }

    protected abstract decimal GetRentalCostLess();
    protected abstract decimal GetRentalCostGreater();
    protected abstract decimal GetInsurancePercentage();

    public virtual void PrintVehicleInfo(TimeSpan reservedRental, TimeSpan actuallyRental)
    {
        decimal rentalCost = reservedRental.Days < 7 ? GetRentalCostLess() : GetRentalCostGreater();
        decimal insurancePercentage = GetInsurancePercentage();

        Console.WriteLine($"Rental cost per day: ${rentalCost:F2}");
        decimal initialInsurence = Value * (insurancePercentage / 100);
        PriceAdjustment(ref initialInsurence);
        Console.WriteLine();


        //total rent and insurence
        decimal totalRent;
        decimal totalInsurence;
        if (reservedRental == actuallyRental)
        {
            totalRent = reservedRental.Days * rentalCost;
            totalInsurence = reservedRental.Days * initialInsurence;
        }
        else
        {
            decimal rentDiscount = (reservedRental.Days - actuallyRental.Days) * rentalCost / 2;
            decimal insurenceDiscount = (reservedRental.Days - actuallyRental.Days) * initialInsurence;
            totalRent = actuallyRental.Days * rentalCost + rentDiscount;
            totalInsurence = actuallyRental.Days * initialInsurence;
            PrintDiscounts(rentDiscount, insurenceDiscount);
        }
        PrintTotals(totalRent, totalInsurence);
    }

    public abstract void PriceAdjustment(ref decimal initialInsurence);

    private void PrintDiscounts(decimal rentDiscount, decimal insuranceDiscount)
    {
        Console.WriteLine($"Early return discount for rent: ${rentDiscount:F2}");
        Console.WriteLine($"Early return discount for insurance: ${insuranceDiscount:F2}");
        Console.WriteLine();
    }

    private void PrintTotals(decimal totalRent, decimal totalInsurance)
    {
        Console.WriteLine($"Total rent: ${totalRent:F2}");
        Console.WriteLine($"Total insurance: ${totalInsurance:F2}");
        Console.WriteLine($"Total: ${totalRent + totalInsurance:F2}");
    }

}
