using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class CalculadoraComum
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }
        public int Subtrair(int a, int b)
        {
            return a - b;
        }
        public int Multiplicar(int a, int b)
        {
            return a * b;
        }
        public int Dividir(int a, int b) 
        {
            return a * b; 
        }
        //Poderia ter feito cada um em uma única linha.
    }
     class CalculadoraCadeia
    {
        int memoria;

        public CalculadoraCadeia Somar(int a) { memoria += a; return this; }
        public CalculadoraCadeia Subtrair(int a) { memoria -= a; return this; }
        public CalculadoraCadeia Multiplicar(int a) { memoria *= a; return this; }
        public CalculadoraCadeia Limpar() { memoria = 0; return this; }
        public CalculadoraCadeia Imprimir() { Console.WriteLine(memoria); return this; }
        public int Resultado() { return memoria; }
    }
    class MetodosComRetorno
    {
        public static void Executar()
        {
            var calculadoraComum = new CalculadoraComum();
            var calculadoraCadeia = new CalculadoraCadeia();
            //a variante calculadoraComum, tem métodos dentro dos parenteses, somando, subtraindo, etc.
            //logo, aqui, quando chamar um deles, dentro do parenteses se tem os números separados pelas virgulas igual aos métodos.
            Console.WriteLine(calculadoraComum.Somar(4,5));
            Console.WriteLine(calculadoraComum.Subtrair(5,8));
            /*a variante calculadoraCadeia, armazena todos os resultados no int memoria da classe.
             e todos os chamados de Somar, Multiplicar, etc. Podem ser usados um atrás do outro, com os valores entre parenteses, igual aos métodos.*/
            calculadoraCadeia.Somar(5).Multiplicar(8).Subtrair(8).Imprimir().Limpar().Imprimir();



        }
    }
}
