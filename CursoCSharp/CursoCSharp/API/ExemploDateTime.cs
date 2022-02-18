using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.API
{
    internal class ExemploDateTime
    {
        public static void Executar()
        {
            var dateTime = new DateTime(year : 2030, month : 2, day : 6);
            //var dateTime = new DateTime(2030, 2, 6);

            Console.WriteLine("Dia: " + dateTime.Day);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Year);

            //Sem horas.
            var hoje = DateTime.Today;
            Console.WriteLine(hoje);
            //Com horas.
            var agora = DateTime.Now;
            Console.WriteLine(agora);
            Console.WriteLine("Hora: " + agora.Hour);
            Console.WriteLine("Minutos: " + agora.Minute);

            var amanha = agora.AddDays(1);
            Console.WriteLine(amanha);
            var ontem = agora.AddDays(-1);
            Console.WriteLine(ontem);

            Console.WriteLine(agora.ToString("dd"));
            Console.WriteLine(agora.ToString("d"));
            Console.WriteLine(agora.ToString("D"));
            Console.WriteLine(agora.ToString("g"));
            Console.WriteLine(agora.ToString("G"));
            Console.WriteLine(agora.ToString("dd-MM-yyyy HH:mm"));

        }
    }
}
