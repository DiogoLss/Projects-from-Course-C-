using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    internal class UsandoContinue
    {
        public static void Executar()
        {
            int intervalo = 50;
            Console.WriteLine("Números pares entre 1 e {0}", intervalo);

            for (int i = 1; i <= intervalo; i++)
            {
                if (i %/*% sobra da divisão.*/  2 == 1) 
                    continue;//"Continue" faz com que se seja o caso do "if", a repetição continua.
                Console.Write("{0} ", i);
            }

            for (int i = 2; i <= 50; i += 2 ) { Console.Write(" {0}", i); };//Acrescentando de 2 em 2, mostrando os pares.
        }
    }
}
