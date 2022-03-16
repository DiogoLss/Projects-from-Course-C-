using System;
using Course10.Entities;
using System.Globalization;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace Course10
{
    class Program
    {
        static void Main(string[] agrs)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            Console.Write("Enter Salary: ");
            double salar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> employees = new List<Employee>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] vet = sr.ReadLine().Split(',');
                    string name = vet[0];
                    string email = vet[1];
                    double salary = double.Parse(vet[2], CultureInfo.InvariantCulture);
                    employees.Add(new Employee(name, email, salary));
                }
            }
            Console.WriteLine("Email of people whose salary is more than {0}: ", salar);
            var emails = employees.Where(e => e.Salary > salar).OrderBy(e => e.Email).Select(e => e.Email);
            foreach(var employee in emails)
            {
                Console.WriteLine(employee);
            }
            Console.Write("Sum of salary of people whose name starts with 'M': ");
            var m = employees.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);
            Console.WriteLine(m.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}