using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class ParametrosNomeados
    {
        public static void Formatar(int dia, int mes, int ano)
        {
            Console.WriteLine("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);
        }
        public static void Executar()
        {
            //Este código é teste meu.
            Console.WriteLine("Insíra o dia:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Insíra o mês:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Insíra o ano:");
            int c = int.Parse(Console.ReadLine());
            //até aqui.



            Formatar(mes: 2, dia:1, ano: 2000);//nomeando os parâmetros para um código mais claro.
            Formatar(dia: a, mes: b, ano: c);
        }
    }
}
