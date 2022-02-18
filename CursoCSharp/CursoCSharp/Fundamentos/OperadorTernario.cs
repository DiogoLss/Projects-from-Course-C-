using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadorTernario
    {
        public static void Executar() {
            var nota = 7.0;
            bool bomComportamento = false;
            string resultado = nota >= 7.0 ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);
            string resultado2 = nota >= 7.0 && bomComportamento ? "Aprovado" : "Reprovado";
            //Se os dois forem verdadeiros, aprovado, se um for falso, reprovado.
            Console.WriteLine(resultado2);

            //Expressão ? Operando1 (true): Operando2(false);
                                    
        }
    }
}
