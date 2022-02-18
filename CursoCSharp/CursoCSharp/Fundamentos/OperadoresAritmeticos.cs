using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresAritmeticos
    {
        public static void Executar() {
            //preço com desconto.
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto; //soma.
            var totalComDesconto = total - (total * desconto);//multiplicação subtração.
            Console.WriteLine("O preço final é {0}", totalComDesconto);

            // IMC.

            double peso = 91.2;
            double altura = 1.82;
            double imc = peso / Math.Pow(altura, 2);//divisão e potencia.
            Console.WriteLine($"IMC é {imc}.");

            // Número par ou impar.

            int par = 24;
            int impar = 55;

            Console.WriteLine("{0} tem resto {1}.", par, par % 2);
            Console.WriteLine("{0} tem resto{1}.", impar, impar % 2);
            // a % b, operador módulo, resto da divisão, o que sobra da divisão.
        }
    }
}
