using System;
namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Menu();
        }
        static void Menu()
        {
            Console.WriteLine("Escolha uma opção:\n" +
            "1 - Soma \n" +
            "2 - Subtração \n" +
            "3 - Multiplicação \n" +
            "4 - Divisão \n"+
            "5 - Sair");
            short opc = short.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1: Soma();
                    break;
                case 2: Subtracao();
                    break;
                case 3: Multiplicacao();
                    break;
                case 4: Divisao();
                    break;
                case 5: System.Environment.Exit(0);
                    break;   
                default: Console.WriteLine("Opção inválida");
                        Menu();
                    break;
            }
        }
        static void Soma()
        {
            Console.WriteLine("Primeiro valor");
            int v1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor");
            int v2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Resultado da Soma: " + (v1 + v2));
            Console.ReadKey();
            Menu();
        }
        static void Subtracao()
        {
            Console.WriteLine("Primeiro valor");
            int v1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor");
            int v2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Resultado da subtração: {v1 - v2}");
            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao()
        {
            Console.WriteLine("Primeiro valor");
            int v1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor");
            int v2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Resultado da multiplicação: {v1 * v2}");
            Console.ReadKey();
            Menu();
        }
        static void Divisao()
        {
            Console.WriteLine("Primeiro valor");
            int v1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor");
            int v2 = int.Parse(Console.ReadLine());
            if (v2 == 0)
            {
                Console.WriteLine("Não pode dividir por zero");
            }
            else
            {
                Console.WriteLine($"Resultado da subtração: {v1 / v2}");
            }
            Console.ReadKey();
            Menu();
        }
    }

}