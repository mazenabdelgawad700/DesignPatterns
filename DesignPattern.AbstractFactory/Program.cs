using DesignPattern.AbstractFactory.Factories;
using DesignPattern.AbstractFactory.Interfaces;

namespace DesignPattern.AbstractFactory;

public class Program
{
    static void Main()
    {
        RunFactoryMethodPatternExample();
        Console.ReadKey();
    }
    private static void RunFactoryMethodPatternExample()
    {
        BankFactory bankFactory = new();
        string bankCode = GetBankCode();

        if (bankCode.Equals(""))
        {
            Console.WriteLine("Can Not Get Bank Code");
            return;
        }

        IBank bank = bankFactory.GetBank(bankCode);
        IPaymentCard paymentCard = bankFactory.GetPaymentCard(bankCode);

        if (bank is null)
            return;

        Console.WriteLine($"Payment Card Provider: {paymentCard.GetProviderInfo()}");
        Console.WriteLine($"Operation: {bank.WithDrow()}");
    }
    private static string GetCardNumber()
    {
        Console.WriteLine("Enter you card number: ");
        string cardNumber;
        //  1111 1111 1111 1111, 234 5678 9101 1123
        cardNumber = Console.ReadLine()!;
        if (cardNumber is null)
        {
            Console.WriteLine("Card number is required.");
            return "";
        }
        return cardNumber;
    }
    private static string GetBankCode()
    {
        string cardNumber = GetCardNumber();
        if (cardNumber.Length < 4)
        {
            Console.WriteLine("Invalid card number.");
            return "";
        }
        return cardNumber[..4];
    }
}
