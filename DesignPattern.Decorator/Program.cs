namespace DesignPattern.Decorator
{
    internal class Program
    {
        static void Main()
        {
            ConcreteSmsService concreteSmsService = new();
            NotificationEmailDecorator notificationEmailDecorator = new();

            notificationEmailDecorator.SetService(concreteSmsService);
            Console.WriteLine(notificationEmailDecorator.SnedSMS("1", "01158907731", "Hello World"));
        }
    }
}
