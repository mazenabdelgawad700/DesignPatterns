namespace DesignPattern.Decorator
{
    public class AbstractDecorator : SmsService
    {

        protected SmsService? _notificationService;
        public void SetService(SmsService notificationService)
        {
            _notificationService = notificationService;
        }

        public override string SnedSMS(string customerId, string phoneNumber, string sms)
        {
            if (_notificationService is null)
                return "Notification service is not initialized";
            else
                return _notificationService.SnedSMS(customerId, phoneNumber, sms);
        }
    }
}
