using DesignPattern.AbstractFactory.Interfaces;

namespace DesignPattern.AbstractFactory.Banks
{
    public class BankC : IBank
    {
        public string WithDrow()
        {
            return "Withdrowing from Bank C.";
        }
    }
}
