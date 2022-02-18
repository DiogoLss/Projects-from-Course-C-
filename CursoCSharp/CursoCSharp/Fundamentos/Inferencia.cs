using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Inferencia
    {
        public static void Executar () {
            var nome = "Dioguinho";
            Console.WriteLine(nome);
            //nome = abc. usando "var" se define na mesma linha.
            //int idade;

            var idade = 32;
            Console.WriteLine(idade);

            int a;
            a = 3;

            int b = 2;

            Console.WriteLine(a + b);           
            
        }
    }
}
