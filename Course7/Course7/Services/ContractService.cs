using System;
using Course7.Entities;

namespace Course7.Services
{
    internal class ContractService
    {
        public int Months { get; set; }
        private IOnlinePaymentService _paymentService;

        public ContractService(int months, IOnlinePaymentService paymentService)
        {
            Months = months;
            _paymentService = paymentService;
        }

        public void ProcessContract(Contract contract)
        {
            double each = contract.TotalValue / Months;
            for (int i = 1; i <= Months; i++)
            {
                double amount1 = _paymentService.Interest(each, i);
                double amount = _paymentService.PaymentFee(amount1);
                DateTime month = contract.Date.AddMonths(i);
                Installment installment = new Installment(month, amount);
                contract.AddInstallments(installment);
            }
        }
    }
}
