using DesignPattern.FactoryMethod.Abstracts;
using DesignPattern.FactoryMethod.Banks;
using DesignPattern.FactoryMethod.Interfaces;

namespace DesignPattern.FactoryMethod.Factories
{
    public class BankFactory : IBankFactory
    {
        public IBank GetBank(string bankCode)
        {
            switch (bankCode)
            {
                case "1234":
                    return new BankA();
                case "1111":
                    return new BankB();
                case "2222":
                    return new BankC();
                default:
                    Console.WriteLine("Bank not found.");
                    return null!;
            }
        }
    }
}
