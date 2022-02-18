using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class DesafioAtributo
    {
        int a = 10;

        public static void Executar()
        {
            //desafio era acessar o int a por este método.
            DesafioAtributo acc = new DesafioAtributo();   
            Console.WriteLine(acc.a);
            

        }
    }
}
