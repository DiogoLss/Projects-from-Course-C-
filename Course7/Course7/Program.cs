using System;
using System.Globalization;
using Course7.Entities;
using Course7.Services;

namespace course7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Contract Data:");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract Value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, contractValue);
            ContractService contractService = new ContractService(months, new PayPalService());
            contractService.ProcessContract(contract);

            Console.WriteLine();
            contract.ShowInstallments();
        }
    }
}