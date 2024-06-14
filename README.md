# VehicleRentalSystem

The program is designed to manage a vehicle rental system.
It consists of several classes organized in the VehicleRentalSystem namespace. The main components include:
-Program: The entry point of the application.
-Invoice: A static class responsible for printing rental bills.
-Vehicle: An abstract base class representing a generic vehicle.
-Car, Motorcycle, and CargoVan: Derived classes from Vehicle, each representing a specific type of vehicle with its own characteristics and rental cost calculations.

The code uses inheritance to define common behaviors and properties for all vehicles, and specialization for each vehicle type.
It follows a modular approach, encapsulating different functionalities within appropriate classes and methods.
The PrintBill method in the Invoice class demonstrates polymorphism by calling PrintVehicleInfo on a Vehicle reference, which at runtime is an instance of a derived class.
The approach ensures that the rental and insurance calculations are clear and specific to each vehicle type while reusing common logic from the base class.
