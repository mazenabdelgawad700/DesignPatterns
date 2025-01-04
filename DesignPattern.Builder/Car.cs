namespace DesignPattern.Builder
{
    public class Car : IBuilder
    {
        private string _brandName;
        private Product _product;
        public Car(string brandName)
        {
            _brandName = brandName;
            _product = new Product();
        }
        public void StartUpOperations()
        {
            _product.Add($"Car Model Name: {_brandName}");
        }
        public void BuildBody()
        {
            _product.Add("Body of Car Was Added");
        }
        public void AddHeadlights()
        {
            _product.Add("Head lights of Car Were Added");
        }
        public void InsertWheels()
        {
            _product.Add("Wheels of Car Were Added");
        }
        public void EndOperations()
        {
            _product.Add("\nCar has been built successfully");
        }
        public Product GetVehicle()
        {
            return _product;
        }
    }
}
