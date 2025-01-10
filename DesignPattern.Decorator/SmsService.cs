namespace DesignPattern.Decorator
{
    public abstract class SmsService
    {
        public abstract string SnedSMS(string customerId, string phoneNumber, string sms);
    }
}
