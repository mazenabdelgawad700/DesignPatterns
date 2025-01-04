namespace DesignPattern.Builder
{
    public interface IBuilder
    {
        public void StartUpOperations();
        public void BuildBody();
        public void InsertWheels();
        public void AddHeadlights();
        public void EndOperations();
        public Product GetVehicle();
    }
}
