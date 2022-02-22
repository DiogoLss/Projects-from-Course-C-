using System.Globalization;
using System.Collections.Generic;
using Course5.Entities;
namespace Course5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> taxPayers = new List<TaxPayer>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char h =  char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(h == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Individual individual = new Individual(name, anualIncome, healthExpenditures);
                    taxPayers.Add(individual);
                }
                else if (h == 'c')
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    Company company = new Company(name, anualIncome, employees);
                    taxPayers.Add(company);
                }
            }
            Console.WriteLine();
            double sum = 0;
            Console.WriteLine("Taxes paid:");
            foreach(TaxPayer taxPayer in taxPayers)
            {
                Console.WriteLine(taxPayer);
                sum += taxPayer.Tax();
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: ${0}", sum.ToString("F2")) ;
        }
    }
}