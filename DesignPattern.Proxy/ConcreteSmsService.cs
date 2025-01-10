namespace DesignPattern.Proxy
{
    public class ConcreteSmsService : SmsService
    {
        public override string SnedSMS(string customerId, string phoneNumber, string sms)
        {
            return $"Customer [{customerId}] send an SMS to {phoneNumber} with message: {sms}";
        }
    }
}
