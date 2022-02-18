using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    internal class EstruturaFor
    {
        public static void Executar()
        {
            int i = 1;

            while (i <= 3)
            { Console.WriteLine($"o valor de i é {i}"); i++; }

            for (int o = 1; o <= 3; o++)
            { Console.WriteLine($"o valor de o é {o}"); }

            double somatorio = 0;
            string entrada;

            Console.Write("Informe o tamanho da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for (int a = 1; a <= tamanhoTurma; a++)
            {
                Console.Write("Informe a nota do aluno: {0}", a);
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);

                somatorio += notaAtual;
            }
            double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
            Console.WriteLine("A média da turma é {0}", media);

        }
    }
}
