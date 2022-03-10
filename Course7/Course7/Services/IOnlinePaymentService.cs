using Course7.Entities;

namespace Course7.Services
{
    interface IOnlinePaymentService
    {
        public double PaymentFee(double amount/*Interest*/);
        public double Interest(double amount, int month);
    }
}
