namespace DesignPattern.Builder
{
    public class Director
    {
        private IBuilder? _builder;
        public void Construct(IBuilder builder)
        {
            _builder = builder;
            if (_builder is not null)
            {
                builder.StartUpOperations();
                builder.BuildBody();
                builder.InsertWheels();
                builder.AddHeadlights();
                builder.EndOperations();
            }
            else
                Console.WriteLine("Error while building object");
        }
    }
}
