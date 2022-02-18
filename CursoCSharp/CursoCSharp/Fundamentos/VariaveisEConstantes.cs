using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class VariaveisEConstantes
    {
        public static void Executar()
        {
            //Área da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            // PI = 3.1415, 3.14 é a constante, não mudará.

            double area = PI * raio * raio; 
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);

            //Tipos internos.

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);
            // bool = true/false.

            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário " + salario);

            int menorValorInt = int.MinValue; //Mais usado dos inteiros!
            Console.WriteLine("Menor int " + menorValorInt);

            uint populaçãoBrasileira = 207_600_000;
            Console.WriteLine("População Brasileira " + populaçãoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor valor long " + menorValorLong);

            ulong populaçãoMundial = 7_600_000_000;
            Console.WriteLine("População mundial " + populaçãoMundial);

            //Agora os valores Reais.

            float precoComputador = 1299.99f; //precisa do f quando usado no float!
            Console.WriteLine("Preço computador " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00; // mais usado dos Reais.
            Console.WriteLine("Valor de Mercado da Apple " + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distancia entre algumas estrelinhas lindas " + distanciaEntreEstrelas); //valor absurdamente grande.

            //Letras e Textos.

            char letra = 'b';
            Console.WriteLine("Letra " + letra);

            string texto = "Opa! Estuda tudo certinho aí, amigão!";
            Console.WriteLine(texto);

            /*Estuda tudo com atenção, variáveis e constantes.
             * temos vários valores para números, letras e textos.*/           

        }
        

        
    }
}
