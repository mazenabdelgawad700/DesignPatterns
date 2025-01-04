using DesignPattern.AbstractFactory.Interfaces;

namespace DesignPattern.AbstractFactory.Abstracts
{
    public interface IBankFactory
    {
        public IBank GetBank(string bankCode);
        public IPaymentCard GetPaymentCard(string cardNumber);
    }
}
