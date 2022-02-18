using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class Array
    {
        public static void Executar()
        {
            string[] alunos = new string[5];
            alunos[0] = "Anderson";
            alunos[1] = "Bia";
            alunos[2] = "Carlos";
            alunos[3] = "Daniela";
            alunos[4] = "Emanuel";

            foreach (var aluno in alunos) { Console.WriteLine(aluno); }

            double somatorio = 0;
            double[] notas = {5.6, 6.8, 8.7, 7.8, 9.8};

            foreach (var nota in notas) { somatorio += nota; }
            double media = somatorio/ notas.Length;
            Console.WriteLine(media);

            char[] letras = { 'A', 'b', 'u', 'c', 'e', 't', 'a' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);

        }
    }
}
