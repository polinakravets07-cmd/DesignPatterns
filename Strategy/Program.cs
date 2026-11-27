namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PaymentContext payment = new PaymentContext(new CardPayment());
            payment.Pay(1500);
            Console.WriteLine();
            payment.SetPaymentStrategy(new CashPayment());
            payment.Pay(800);
        }
    }
}
