
namespace Course7.Services
{
    internal class PayPalService : IOnlinePaymentService
    {
        public double PaymentFee(double amount /*Interest*/)
        {
            return amount + (amount * 0.02);
        }
        public double Interest(double amount, int month)
        {
            return amount + (month * (amount * 0.01));
        }
    }
}
