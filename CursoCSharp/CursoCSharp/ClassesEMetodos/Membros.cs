using System;


namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Renato";
            sicrano.Idade = 21;

            //Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos.");

            sicrano.ApresentarNoConsole();//este executará no console.
            //sicrano.Zerar();
            
            var fulano = new Pessoa();
            fulano.Nome = "Beto";
            fulano.Idade = 22;

            var apresentacaoDoFulano = fulano.Apresentar();//este, dentro de situações parece ser mais útil.
            Console.WriteLine(apresentacaoDoFulano);       //terei uma variável (string) específica para usar como quiser, com a apresentação do fulano. E não um cw.

        }
    }
}
