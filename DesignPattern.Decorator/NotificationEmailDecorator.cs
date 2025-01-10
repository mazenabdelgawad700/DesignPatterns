using System.Text;

namespace DesignPattern.Decorator
{
    public class NotificationEmailDecorator : AbstractDecorator
    {
        public string SmsSentNotification(string customerId, string sms)
        {
            return $"SMS: \"{sms}\", sent by customer[{customerId}], at {DateTime.Now.ToLongDateString()}";
        }

        public override string SnedSMS(string customerId, string phoneNumber, string sms)
        {
            StringBuilder result = new();
            result.AppendLine(base.SnedSMS(customerId, phoneNumber, sms));
            result.AppendLine(SmsSentNotification(customerId, sms));

            return result.ToString();
        }

    }
}
