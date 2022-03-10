using System.Collections.Generic;

namespace Course7.Entities
{
    internal class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Instalments = new List<Installment>();

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
        }
        public void AddInstallments(Installment installment)
        {
            Instalments.Add(installment);
        }
        public void ShowInstallments()
        {
            foreach(var installment in Instalments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}
