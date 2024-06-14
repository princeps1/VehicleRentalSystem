namespace VehicleRentalSystem;

public static class Invoice
{
    public static void PrintBill(string customerName, DateTime startDate, DateTime endDate, DateTime returnDate, Vehicle specVehicle)
    {
        if (specVehicle != null)
        {
            TimeSpan reservedRental = endDate - startDate;
            TimeSpan actuallyRental = returnDate - startDate;
            Console.WriteLine("XXXXXXXXXX");
            Console.WriteLine($"Date: {returnDate.ToString("yyyy-MM-dd")}");
            Console.WriteLine($"Customer Name: {customerName}");
            Console.WriteLine($"Rented Vehicle: {specVehicle.Brand} {specVehicle.Model}\n");

            Console.WriteLine($"Reservation start date: {startDate.ToString("yyyy-MM-dd")}");
            Console.WriteLine($"Reservation end date: {endDate.ToString("yyyy-MM-dd")}");
            Console.WriteLine($"Reserved rental days: {reservedRental.Days} days\n");

            Console.WriteLine($"Actual return date: {returnDate.ToString("yyyy-MM-dd")}");
            Console.WriteLine($"Actual rental days: {actuallyRental.Days} days \n");

            specVehicle.PrintVehicleInfo(reservedRental, actuallyRental);
            Console.WriteLine("XXXXXXXXXX");
            Console.WriteLine("\n\n\n");

        }
        else
        {
            throw new ArgumentException("Specified vehicle is null.", nameof(specVehicle));
        }
    }
}
