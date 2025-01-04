using DesignPattern.AbstractFactory.Abstracts;
using DesignPattern.AbstractFactory.Banks;
using DesignPattern.AbstractFactory.Interfaces;
using DesignPattern.AbstractFactory.PaymentCards;

namespace DesignPattern.AbstractFactory.Factories
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
        public IPaymentCard GetPaymentCard(string cardNumber)
        {
            switch (cardNumber)
            {
                case "1234":
                    return new VisaCard();
                case "1111":
                    return new MasterCard();
                default:
                    Console.WriteLine("Card not found.");
                    return null!;
            }
        }
    }
}
