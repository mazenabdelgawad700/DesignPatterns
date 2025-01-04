using DesignPattern.AbstractFactory.Interfaces;

namespace DesignPattern.AbstractFactory.Banks
{
    public class BankA : IBank
    {
        public string WithDrow()
        {
            return "Withdrowing from Bank A.";
        }
    }
}
