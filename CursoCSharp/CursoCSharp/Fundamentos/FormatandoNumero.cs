using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    internal class FormatandoNumero
    {
        public static void Executar() {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); //Arredondando com uma única casa(para maior).
            Console.WriteLine(valor.ToString("C")); //Currency.
            Console.WriteLine(valor.ToString("P")); //Porcentagem X 100.
            Console.WriteLine(valor.ToString("#.##")); //Formatação específica, arredondando para maior.

            CultureInfo cultura = new CultureInfo("en-US"); //Estabelecendo "cultura" para inglês americano.
            Console.WriteLine(valor.ToString("C0", cultura)); //Usando "cultura" para o valor Currency ser dólar.

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); //Quantidade de casas do número.
        }
    }
}
