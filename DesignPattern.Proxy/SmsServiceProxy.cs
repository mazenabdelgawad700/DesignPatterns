namespace DesignPattern.Proxy
{
    public class SmsServiceProxy
    {
        private SmsService? _smsService;

        private Dictionary<string, int> _sentCount = new Dictionary<string, int>();


        public string sendSMS(string customerId, string phoneNumber, string sms)
        {
            _smsService ??= new ConcreteSmsService();

            if (!_sentCount.ContainsKey(customerId))
                _sentCount.Add(customerId, 1);

            else if (_sentCount[customerId] < 100)
                _sentCount[customerId]++;

            else if (_sentCount[customerId] == 100)
                return "You have reached the limit of sending SMS";


            Console.WriteLine($"Count: {_sentCount[customerId]}");

            return _smsService.SnedSMS(customerId, phoneNumber, sms);
        }
    }
}
