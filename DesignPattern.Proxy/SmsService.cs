namespace DesignPattern.Proxy
{
    public abstract class SmsService
    {
        public abstract string SnedSMS(string customerId, string phoneNumber, string sms);
    }
}
