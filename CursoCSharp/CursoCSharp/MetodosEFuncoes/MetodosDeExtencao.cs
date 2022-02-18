using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    public static class ExtencoesInteiro
    {
        public static int Soma(this int num, int outroNumero) { return num + outroNumero; }
        public static int Sub(this int num, int outroNumero) { return num - outroNumero; }
    }
    internal class MetodosDeExtencao
    {
        public static void Executar()
        {
            int numero = 5;

            Console.WriteLine(numero.Soma(5));
            Console.WriteLine(numero.Sub(3));

            Console.WriteLine(2.Soma(3));
            Console.WriteLine(1.Sub(3));
        }
    }
}
