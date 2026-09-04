public abstract class Transport
{
    public abstract double Speed { get; set; }
    public abstract double CarryingCapacity { get; set; }
    public abstract double Distance { get; set; }

    public abstract string GetInfo();
}

public abstract class Car : Transport
{
    public string Brand { get; set; }
}

public abstract class Airplane : Transport
{
    public string Model { get; set; }
}

public abstract class Ship : Transport
{
    public string Name { get; set; }
}

public class BMW :  Car
{
    public override double Speed { get; set; }
    public override double CarryingCapacity { get; set; }
    public override double Distance { get; set; }

    public override string GetInfo()
    {
        return $"{Brand} грузоподъемностью в {CarryingCapacity} кг может проехать {Distance} км со скоростью {Speed} км/ч";
    }
}

public class Mark2 : Airplane
{
    public override double Speed { get; set; }
    public override double CarryingCapacity { get; set; }
    public override double Distance { get; set; }

    public override string GetInfo()
    {
        return $"{Model} грузоподъемностью в {CarryingCapacity} кг может проехать {Distance} км со скоростью {Speed} км/ч";
    }
}

public class Sheper : Ship
{
    public override double Speed { get; set; }
    public override double CarryingCapacity { get; set; }
    public override double Distance { get; set; }

    public override string GetInfo()
    {
        return $"{Name} грузоподъемностью в {CarryingCapacity} кг может проехать {Distance} км со скоростью {Speed} км/ч";
    }
}

class Program
{
    static void Main(string[] args)
    {
        BMW bmw = new BMW
        {
            Brand = "M4 Cimpintay",
            Speed = 220,
            CarryingCapacity = 500,
            Distance = 800
        };
        Console.WriteLine(bmw.GetInfo());

        Mark2 plane = new Mark2
        {
            Model = "Mark2",
            Speed = 900,
            CarryingCapacity = 50000,
            Distance = 14000
        };
        Console.WriteLine(plane.GetInfo());

        Sheper ship = new Sheper
        {
            Name = "Титаник",
            Speed = 40,
            CarryingCapacity = 3000000,
            Distance = 5000
        };
        Console.WriteLine(ship.GetInfo());
    }
}
