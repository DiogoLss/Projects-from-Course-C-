using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Conversoes
    {
        public static void Executar() {
            int inteiro = 10;
            double quebrado = inteiro; //conversão sem perca de informação.
            Console.WriteLine("Nota: {0}", quebrado);

            double nota = 8.9;
            int notaTruncada = (int) nota; //Quando há possíbilidade de perda de informação. (int).
            Console.WriteLine("Nota truncada: {0}", notaTruncada);

            Console.WriteLine("Digite sua idade:");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);
            //Conversão com Parse de string para inteiro.

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado: {0}", idadeInteiro);
            //Outra conversão.

            Console.WriteLine("Digite o primeiro número!");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1);
            Console.WriteLine("Resultado 1: {0}", numero1);
            //Digita o número na string e tenta uma conversão da string para o inteiro.
            

            Console.WriteLine("Digite o segundo número!");
            int.TryParse(Console.ReadLine(), out int numero2);//Se tenta uma conversão no que for digitado para o inteiro estabelecido aqui, sem usar o string.
            Console.WriteLine("Resultado 2: {0}", numero2);
            //Mesma coisa da passada, só que mais compacto.


        }
    }
}
