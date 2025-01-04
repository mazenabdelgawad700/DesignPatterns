using DesignPattern.AbstractFactory.Interfaces;

namespace DesignPattern.AbstractFactory.PaymentCards
{
    public class MasterCard : IPaymentCard
    {
        public string GetPaymentCardName()
        {
            return "Master Card";
        }
        public string GetProviderInfo()
        {
            return "Master";
        }
    }
}
