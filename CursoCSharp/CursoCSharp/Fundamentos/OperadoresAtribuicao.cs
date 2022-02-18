using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresAtribuicao
    {
        public static void Executar() {
            var num1 = 3;
            num1 = 7;
            num1 += 10; //num1 = num1 + 10;
            Console.WriteLine(num1);
            num1 -= 3; //num1 = num1 - 3;
            Console.WriteLine(num1);
            num1 *= 5; //num1 = num1 * 5;
            Console.WriteLine(num1);
            num1 /= 2; //num1 = num1 / 2:
            Console.WriteLine(num1);

            int a = 1;
            int b = a;

            a++;//a + 1
            b--;//b - 1

            Console.WriteLine($"{a} {b}");

            //Não se preocupar com o código seguinte.

            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "João";

            dynamic d = c; //essa atribuição faz com que compartilhem o mesmo espaço de memória. ou algo do tipo.
            d.nome = "Maria";

            Console.WriteLine(c.nome);
        }
    }
}
