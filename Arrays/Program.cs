using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array1 = new int[5];
            int valor = 12;
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = valor * i;
                Console.WriteLine(array1[i]);
            }
            Console.WriteLine("--------------");
            foreach (var item in array1)
            {
                Console.WriteLine("foreach: " + item);
            }
            Console.WriteLine("--------------");
            var array2 = new Teste[2];
            array2[0] = new Teste();
            array2[1] = new Teste();
            array2[0].Id = valor * 2;
            array2[1].Id = valor * 4;
            Console.WriteLine(array2[0] + "\n" + array2[1]);
            Console.WriteLine(array2[0].Id + "\n" + array2[1].Id);
            Console.WriteLine("--------------");
            var funcionarios = new Funcionario[3];
            funcionarios[0] = new Funcionario() { Id = 123 };
            funcionarios[1] = new Funcionario() { Id = 456 };
            funcionarios[2] = new Funcionario() { Id = 789 };
            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine(funcionario.Id);
            }
            Console.WriteLine("--------------");
            var segundo = array1; //terão a mesma referencia
            Console.WriteLine(segundo[0]+" -- "+array1[1]);
            var terceiro = new int[5];
            terceiro[0] = array1[1]; // copia apenas o valor
            array1[1]=18;
            Console.WriteLine(terceiro[0]+" -- "+array1[1]);
        }
        struct Teste
        {
            public int Id { get; set; }
        }

        struct Funcionario
        {
            public int Id { get; set; }
        }
    }
}