using System;

namespace OOPs.Inheritance
{
    public class Vehicle
    {
        protected string _make;
        protected string _model;
        protected int _year;

        public Vehicle(string make, string model, int year)
        {
            _make = make;
            _model = model;
            _year = year;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Vehicle: {_make} {_model} ({_year})");
        }
    }

    public class Car : Vehicle
    {
        private int _speed;

        public Car(string make, string model, int year, int speed) : base(make, model, year)
        {
            _speed = speed;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Speed: {_speed} km/h");
        }
    }

    public class Truck : Vehicle
    {
        private int _cargoCapacity;

        public Truck(string make, string model, int year, int cargoCapacity) : base(make, model, year)
        {
            _cargoCapacity = cargoCapacity;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Cargo Capacity: {_cargoCapacity} kg");
        }
    }

    public class InheritanceExample
    {
        public static void RunExample()
        {
            Console.WriteLine("\n--- Inheritance Example ---");

            Car myCar = new Car("Toyota", "Camry", 2020, 120);
            myCar.DisplayInfo();

            Console.WriteLine();

            Truck myTruck = new Truck("Volvo", "VNR", 2018, 4000);
            myTruck.DisplayInfo();
        }
    }
}
namespace Inheritance.Example
{
    // Base class: Employee
    public class Employee
    {
        // Protected fields
        protected string firstName;
        protected string lastName;

        // Constructor to initialize fields
        public Employee(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        // Method to display employee information
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Employee: {firstName} {lastName}");
        }
    }

    // Derived class: Manager (inherits from Employee)
    public class Manager : Employee
    {
        // Private field specific to Manager
        private int directReportsCount;

        // Constructor to initialize base and derived fields
        public Manager(string firstName, string lastName, int directReportsCount) : base(firstName, lastName)
        {
            this.directReportsCount = directReportsCount;
        }

        // Override DisplayInfo to include manager-specific information
        public override void DisplayInfo()
        {
            base.DisplayInfo(); // Call base class method
            Console.WriteLine($"Direct Reports Count: {directReportsCount}");
        }
    }

    // Class to run the example
    public class InheritanceExample
    {
        public static void RunExample()
        {
            Console.WriteLine("\n--- Inheritance Example ---");

            // Create an Employee object
            Employee myEmployee = new Employee("Bob", "Smith");
            myEmployee.DisplayInfo();

            Console.WriteLine();

            // Create a Manager object
            Manager myManager = new Manager("Charlie", "White", 10);
            myManager.DisplayInfo();
        }
    }
}