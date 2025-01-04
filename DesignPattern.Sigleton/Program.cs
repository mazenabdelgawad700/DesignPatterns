namespace DesignPattern.Sigleton;

public class Program
{
    static async Task Main()
    {
        await Task.Run(() =>
        {
            Counter counter1 = Counter.GetInstance();
            counter1.AddOne();
            Console.WriteLine($"Counter 1 = {counter1.Count}"); // 1
        });

        await Task.Run(() =>
        {
            Counter counter2 = Counter.GetInstance();
            counter2.AddOne();
            Console.WriteLine($"Counter 2 = {counter2.Count}"); // 2
        });

        Console.ReadKey();
    }
}