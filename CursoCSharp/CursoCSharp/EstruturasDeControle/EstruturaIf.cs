using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    internal class EstruturaIf
    {
        public static void Executar() {
            bool bomComportamento = false;
            string entrada;

            Console.WriteLine("Digite a nota do Aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom comportamente? (Sim/Não):");
            entrada = Console.ReadLine();

            //Abaixo comentado caso digete "s" ou "n".
            //if (entrada == "S" || entrada == "s")
            //bomComportamento true

            // bomComportamento = entrada == "S" || entrada || "s")
            

            bomComportamento = entrada.ToLower() == "sim";
            if (nota >= 9.0 && bomComportamento)
            { Console.WriteLine("Quadro de Honra!"); ;}


        }
    }
}
