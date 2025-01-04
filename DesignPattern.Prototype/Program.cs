namespace DesignPattern.Prototype;

public class Program
{
    static void Main()
    {

        Employee emp1 = new()
        {
            EmployeeName = "Mazen",
            Department = "Google Infrastructure",
            CompanyName = "Google",
            EmployeeAddress = new Address
            {
                Country = "UK",
                City = "London"
            }
        };

        Employee emp2 = emp1.DeepCopy();

        Console.WriteLine("Employee_1 Original Values");
        Console.WriteLine(emp1);

        Console.WriteLine();

        Console.WriteLine("Employee_2 Shallow Copy Values");
        Console.WriteLine(emp2);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nChange the Name attripute for Employee 2");
        Console.ForegroundColor = ConsoleColor.Gray;

        // Change Values To Employee 2
        emp2.EmployeeName = "Doma";
        // Change Values To Employee 2

        Console.WriteLine();

        Console.WriteLine("Employee_1 After Changes");
        Console.WriteLine(emp1);

        Console.WriteLine();

        Console.WriteLine("Employee_2 After Changes");
        Console.WriteLine(emp2);


        Console.ReadKey();
    }
}
