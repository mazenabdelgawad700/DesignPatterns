using DesignPattern.FactoryMethod.Interfaces;

namespace DesignPattern.FactoryMethod.Abstracts
{
    public interface IBankFactory
    {
        public IBank GetBank(string bankCode);
    }
}
