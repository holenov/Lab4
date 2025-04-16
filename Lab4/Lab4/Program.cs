using System;
using System.Text;

class City
{
    public string Name { get; set; }
    public string Country { get; set; }
    public string Region { get; set; }
    public int Population { get; set; }
    public double AnnualIncome { get; set; }
    public double Area { get; set; }
    public bool HasPort { get; set; }
    public bool HasAirport { get; set; }

    public City(string name, string country, string region, int population, double annualIncome, double area, bool hasPort, bool hasAirport)
    {
        Name = name;
        Country = country;
        Region = region;
        Population = population;
        AnnualIncome = annualIncome;
        Area = area;
        HasPort = hasPort;
        HasAirport = hasAirport;
    }

    public double CalculateAverageIncomePerResident()
    {
        return Population > 0 ? AnnualIncome / Population : 0;
    }

    public void DisplayInfo()
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;
        Console.WriteLine($"Місто: {Name}");
        Console.WriteLine($"Країна: {Country}");
        Console.WriteLine($"Регіон: {Region}");
        Console.WriteLine($"Населення: {Population}");
        Console.WriteLine($"Річний дохід: {AnnualIncome}");
        Console.WriteLine($"Площа: {Area}");
        Console.WriteLine($"Порт: {(HasPort ? "Так" : "Ні")}");
        Console.WriteLine($"Аеропорт: {(HasAirport ? "Так" : "Ні")}");
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;
        Console.WriteLine("Введіть дані про місто:");

        Console.Write("Назва: ");
        string name = Console.ReadLine();

        Console.WriteLine("Країна: ");
        string country = Console.ReadLine();

        Console.WriteLine("Регіон: ");
        string region = Console.ReadLine();

        Console.WriteLine("Населення: ");
        int population = int.Parse(Console.ReadLine());

        Console.WriteLine("Річний дохід: ");
        double annualIncome = double.Parse(Console.ReadLine());

        Console.WriteLine("Площа: ");
        double area = double.Parse(Console.ReadLine());

        Console.WriteLine("Порт (так/ні): ");
        bool hasPort = Console.ReadLine().ToLower() == "так";

        Console.WriteLine("Аеропорт (так/ні): ");
        bool hasAirport = Console.ReadLine().ToLower() == "так";


        City city = new City(name, country, region, population, annualIncome, area, hasPort, hasAirport);
        Console.OutputEncoding = UTF8Encoding.UTF8;
        Console.WriteLine("\nДані про місто:");

        city.DisplayInfo();

    }
}