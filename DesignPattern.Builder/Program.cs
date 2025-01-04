namespace DesignPattern.Builder;

public class Program
{
    static void Main()
    {
        Director director = new();
        Car car = new("Toyota Suppra");
        director.Construct(car);
        Product procut = car.GetVehicle();

        Console.WriteLine(procut.Show());

        Console.ReadKey();
    }
}
