using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresUnarios
    {
        public static void Executar() {
            var valorNegativo = -5;
            var num1 = 2;
            var num2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo);//Valor negativo se torna positivo e vise-versa. (usando o menos).
            Console.WriteLine(!booleano); //Inverte o bool.

            num1++;
            Console.WriteLine(num1);
            --num1;//Toma prioridade.
            Console.WriteLine(num1);

            Console.WriteLine(num1++ == --num2);//Os sinais antes da var são contados primeiros. Tornando este verdadeiro, já que ele compara depois de diminuir e antes de somar.
            Console.WriteLine($"{num1}, {num2}");


        }
    }
}
