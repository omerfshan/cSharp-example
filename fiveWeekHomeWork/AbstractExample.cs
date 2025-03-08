using System;

abstract class Vehicle
{
    public string Brand { get; set; }
    public int Speed { get; set; }

    public Vehicle(string brand, int speed)
    {
        Brand = brand;
        Speed = speed;
    }

   
    public abstract void Move();

    
    public void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h");
    }
}


class Car : Vehicle
{
    public Car(string brand, int speed) : base(brand, speed) { }

    public override void Move()
    {
        Console.WriteLine($"{Brand} car is moving at {Speed} km/h.");
    }
}



abstract class Employee
{
    public string Name { get; set; }
    public int Salary { get; set; }

    public Employee(string name, int salary)
    {
        Name = name;
        Salary = salary;
    }

    public abstract void Work();
}

class Developer : Employee
{
    public Developer(string name, int salary) : base(name, salary) { }

    public override void Work()
    {
        Console.WriteLine($"{Name} is coding and earns {Salary}$ per month.");
    }
}


class Program
{
    static void Main()
    {
        Car myCar = new Car("Tesla", 120);
        myCar.DisplayInfo();
        myCar.Move();
         Developer dev = new Developer("Ali", 5000);
        dev.Work();
    }
}
