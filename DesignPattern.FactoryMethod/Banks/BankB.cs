using DesignPattern.FactoryMethod.Interfaces;

namespace DesignPattern.FactoryMethod.Banks
{
    public class BankB : IBank
    {
        public string WithDrow()
        {
            return "Withdrowing from Bank B.";
        }
    }
}
