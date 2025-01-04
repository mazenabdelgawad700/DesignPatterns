namespace DesignPattern.Sigleton
{
    public class Counter
    {

        #region Fields
        public int Count { get; private set; }
        private static readonly object _lock = new();
        private static Counter _instance = null!;
        #endregion

        #region Constructors
        private Counter() { }
        #endregion

        #region Handlers
        public static Counter GetInstance()
        {
            lock (_lock)
            {
                _instance ??= new Counter();
            }
            return _instance;
        }

        public void AddOne()
        {
            _instance.Count++;
        }
        #endregion
    }
}