
public abstract class Device
{
    public abstract string Name { get; }
}
public class Laptop : Device
{
    public override string Name => "Laptop";
}

public class Netbook : Device
{
    public override string Name => "Netbook";
}

public class EBook : Device
{
    public override string Name => "EBook";
}

public class Smartphone : Device
{
    public override string Name => "Smartphone";
}
public abstract class DeviceFactory
{
    public abstract Laptop CreateLaptop();
    public abstract Netbook CreateNetbook();
    public abstract EBook CreateEBook();
    public abstract Smartphone CreateSmartphone();
}
public class IProneFactory : DeviceFactory
{
    public override Laptop CreateLaptop() => new Laptop();
    public override Netbook CreateNetbook() => new Netbook();
    public override EBook CreateEBook() => new EBook();
    public override Smartphone CreateSmartphone() => new Smartphone();
}

public class KiaomiFactory : DeviceFactory
{
    public override Laptop CreateLaptop() => new Laptop();
    public override Netbook CreateNetbook() => new Netbook();
    public override EBook CreateEBook() => new EBook();
    public override Smartphone CreateSmartphone() => new Smartphone();
}

public class BalaxyFactory : DeviceFactory
{
    public override Laptop CreateLaptop() => new Laptop();
    public override Netbook CreateNetbook() => new Netbook();
    public override EBook CreateEBook() => new EBook();
    public override Smartphone CreateSmartphone() => new Smartphone();
}

class Program
{
    static void Main(string[] args)
    {
        DeviceFactory factory = new IProneFactory();
        Device device = factory.CreateLaptop();
        Console.WriteLine($"Created {device.Name} using {factory.GetType().Name}");
    }
}
