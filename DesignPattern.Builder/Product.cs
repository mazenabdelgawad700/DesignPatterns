using System.Text;

namespace DesignPattern.Builder
{
    public class Product
    {
        private LinkedList<string> _parts;
        public Product()
        {
            _parts = new LinkedList<string>();
        }
        public void Add(string part)
        {
            _parts.AddLast(part);
        }
        public string Show()
        {
            StringBuilder result = new();
            result.AppendLine("Product Components are: \n");
            foreach (var part in _parts)
            {
                result.AppendLine(part);
            }
            return result.ToString();
        }
    }
}
