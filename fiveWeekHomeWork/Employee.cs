using System;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Salary { get; set; }
    public string Department { get; set; }

    public Employee(int id, string name, double salary, string department)
    {
        Id = id;
        Name = name;
        Salary = salary;
        Department = department;
    }

  
    public virtual double CalculateBonus()
    {
        return 0;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}, Salary: {Salary:C}, Department: {Department}");
    }
}


class Manager : Employee
{
    public int TeamSize { get; set; }

    public Manager(int id, string name, double salary, string department, int teamSize)
        : base(id, name, salary, department)
    {
        TeamSize = teamSize;
    }

   
    public override double CalculateBonus()
    {
        return Salary * 0.20;
    }

    public void DisplayManagerInfo()
    {
        DisplayInfo();
        Console.WriteLine($"Team Size: {TeamSize}, Bonus: {CalculateBonus():C}");
    }
}


class Developer : Employee
{
    public string About { get; set; }

    public Developer(int id, string name, double salary, string department, string about)
        : base(id, name, salary, department)
    {
        About = about;
    }

    public override double CalculateBonus()
    {
        return Salary * 0.10;
    }

    public void DisplayDeveloperInfo()
    {
        DisplayInfo();
        Console.WriteLine($"About: {About}, Bonus: {CalculateBonus():C}");
    }
}
class Program
{
    static void Main()
    {
        Manager manager = new Manager(1, "Ahmet Yılmaz", 8000, "IT", 5);
        Developer developer = new Developer(2, "Mehmet Kaya", 6000, "Software", "C# and .NET developer");
        manager.DisplayManagerInfo();
        developer.DisplayDeveloperInfo();
    }
}
