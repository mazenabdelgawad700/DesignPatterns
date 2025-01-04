using DesignPattern.AbstractFactory.Interfaces;

namespace DesignPattern.AbstractFactory.PaymentCards
{
    public class VisaCard : IPaymentCard
    {
        public string GetPaymentCardName()
        {
            return "Visa Card";
        }
        public string GetProviderInfo()
        {
            return "Visa";
        }
    }
}
