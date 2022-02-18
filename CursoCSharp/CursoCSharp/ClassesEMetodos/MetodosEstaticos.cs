using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class CalculadoraEstatica
    {
        //Método de instância!!!
        public int Somar(int a, int b) { return a + b;}
        //Método de Classe ou estático!!!
        public static int Multiplicar(int a, int b) { return a * b;}
    }
    internal class MetodosEstaticos
    {
        public static void Executar()
        {
            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(2,6));//Tive de criar calc para usar o somar, que não é estático.
            Console.WriteLine(CalculadoraEstatica.Multiplicar(9,5));//Acessando o Multiplicar atráves da classe, pois é estático.
        }
    }
}
