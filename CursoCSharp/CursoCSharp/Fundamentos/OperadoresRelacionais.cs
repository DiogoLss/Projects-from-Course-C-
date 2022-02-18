using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresRelacionais
    {
        public static void Executar() {
            //double nota = 6.0;
            Console.Write("Digite sua nota: ");
            double.TryParse(Console.ReadLine(), out double nota);//aprender! TryParse.
            double notaDeCorte = 7.0;

            Console.WriteLine("Nota inválida? {0}", nota > 10.0);//maior.
            Console.WriteLine("Nota inválida? {0}", nota < 0.0);//menor.
            Console.WriteLine("Perfeito? {0}", nota == 10.0);//igual.
            Console.WriteLine("Tem como melhorar? {0}", nota != 10.0);//diferente.
            Console.WriteLine("Passou por média? {0}", nota >= notaDeCorte);//maior ou igual.
            Console.WriteLine("Recuperação? {0}", nota < notaDeCorte);//menor.
            Console.WriteLine("Reprovado? {0}", nota <= 3.0);//menor ou igual.
        }
    }
}
