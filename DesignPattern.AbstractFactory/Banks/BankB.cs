using DesignPattern.AbstractFactory.Interfaces;

namespace DesignPattern.AbstractFactory.Banks
{
    public class BankB : IBank
    {
        public string WithDrow()
        {
            return "Withdrowing from Bank B.";
        }
    }
}
