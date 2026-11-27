namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotificationCreator emailCreator = new EmailNotificationCreator();
            Notification email = emailCreator.CreateNotification();
            email.Send("Вітаємо! Це тестове Email-повідомлення.");
            Console.WriteLine();
            NotificationCreator smsCreator = new SmsNotificationCreator();
            Notification sms = smsCreator.CreateNotification();
            sms.Send("Вітаємо! Це тестове SMS-повідомлення.");
        }
    }
}
