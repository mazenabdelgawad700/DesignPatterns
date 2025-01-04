using DesignPattern.FactoryMethod.Interfaces;

namespace DesignPattern.FactoryMethod.Banks
{
    public class BankC : IBank
    {
        public string WithDrow()
        {
            return "Withdrowing from Bank C.";
        }
    }
}
