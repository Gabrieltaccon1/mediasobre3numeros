using System;
using System.Globalization;

namespace media_sobre_3_notas
{
    class Program
    {
        static void Main(string[] args)
        {
            double notaA, notaB, notaC, media;

            Console.WriteLine("DIGITE A PRIMEIRA NOTA");
            notaA = double.Parse(Console.ReadLine());


            Console.WriteLine("DIGITE A segunda NOTA");
            notaB = double.Parse(Console.ReadLine());

            Console.WriteLine("DIGITE A terceira NOTA");
            notaC = double.Parse(Console.ReadLine());




            media = ((notaA * 2.0 + notaB * 3.0 + notaC * 5.0) / 10.0);

            Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));
            // ToString("F1",CultureInfo.InvariantCulture));  pode ser utilizado somente na //impressão do resultado ao inves de usar em todos as variaveis

        }
    }
}
