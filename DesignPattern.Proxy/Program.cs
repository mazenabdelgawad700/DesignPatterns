using DesignPattern.Proxy;


SmsServiceProxy proxy = new();
while (true)
{
    string result = proxy.sendSMS("1", "01158907731", "Hello World");
    Console.WriteLine(result);
    if (result == "You have reached the limit of sending SMS")
    {
        Console.ReadKey();
        break;
    }
}