using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{

    public enum Genero { Acao, Aventura, Terror, Animacao, Comedia};//sem assento para não gerar problemas, porém no cw também fica sem.(pode-se usar assento aqui).
    public class Filme
    {
        public string Titulo;
        public Genero GeneroDoFilme;
    }
    internal class ExemploEnum
    {
        public static void Executar()
        {
            int exanima = (int)Genero.Animacao;
            Console.WriteLine(exanima);

            var filmeParaFamilia = new Filme();
            filmeParaFamilia.Titulo = "Sharknardo";
            filmeParaFamilia.GeneroDoFilme = Genero.Comedia;

            Console.WriteLine("{0} é {1}", filmeParaFamilia.Titulo, filmeParaFamilia.GeneroDoFilme);
        }
    }
}
