using DesignPattern.FactoryMethod.Interfaces;

namespace DesignPattern.FactoryMethod.Banks
{
    public class BankA : IBank
    {
        public string WithDrow()
        {
            return "Withdrowing from Bank A.";
        }
    }
}
