using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    internal class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativaRestantes = 5;
            int tentativas = 0;

            while (tentativaRestantes > 0 && !numeroEncontrado)
            {
                Console.WriteLine("Insira seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativaRestantes--;
                tentativas++;

                if (numeroSecreto == palpite)
                {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;                 
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Write("Numero encontrado em {0} tentativas.", tentativas);
                    Console.BackgroundColor = corAnterior;
                } else if (palpite > numeroSecreto)
                { Console.WriteLine("Tente um número menor!!");
                  Console.WriteLine("Tentativas restantes: {0}", tentativaRestantes);}
                else
                { Console.WriteLine("Tente um número maior!!");
                  Console.WriteLine("Tentativas restantes: {0}", tentativaRestantes);}

            }
        }
    }
}
