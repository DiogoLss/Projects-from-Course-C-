using System;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante[] quartos = new Estudante[10];
            Console.Write("Quantos quartos serão alugados? ");
            int N = int.Parse(Console.ReadLine());

            for(int i = 1; i <= N; i++)
            {
                Console.WriteLine("Aluguel # {0}:", i);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                quartos[quarto - 1] = new Estudante(nome, email);
            }
            Console.WriteLine("Quartos ocupados:");
            for(int i = 0; i < 10; i++)
            {
                if(quartos[i] != null)
                {
                    Console.WriteLine(i + 1 + ": " + quartos[i]);
                }
            }
        }
    }
}