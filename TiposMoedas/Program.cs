using System;
using System.Globalization;

namespace TiposMoedas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            decimal valor = 10.24m;
            //formatador numerico padrão
            //C formata no padrão moeda
            //P porcentagem
            Console.WriteLine(valor.ToString(
                "C",
                CultureInfo.CreateSpecificCulture("pt-BR")
                )
            );

            Console.WriteLine(Math.Round(valor));
            Console.WriteLine(Math.Ceiling(valor));
            Console.WriteLine(Math.Floor(valor));
        }
    }
}