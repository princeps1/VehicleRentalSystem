using VehicleRentalSystem;

public class Program
{
    public static void Main()
    {


        Car car = new Car("Mitsubishi", "Mirage", 15000, 3);
        Invoice.PrintBill("John Doe", new DateTime(2024, 6, 3), new DateTime(2024, 6, 13), new DateTime(2024, 6, 13), car);

        Motorcycle motorcycle = new Motorcycle("Triumph", "Tiger Sport 660", 10000, 20);
        Invoice.PrintBill("Mary Johnson", new DateTime(2024, 6, 3), new DateTime(2024, 6, 13), new DateTime(2024, 6, 13), motorcycle);

        CargoVan cargo = new CargoVan("Citroen", "Jumper", 20000, 8);
        Invoice.PrintBill("John Markson", new DateTime(2024, 6, 3), new DateTime(2024, 6, 18), new DateTime(2024, 6, 13), cargo);
    }
}
