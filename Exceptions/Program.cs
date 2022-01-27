using System;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = new int[3];
            //Testar("");
            try
            {
                for (var i = 0; i < 5; i++)
                {
                    //IndexOutOfRangeException
                    Console.WriteLine(array[i] = i);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("indice não encontrado");
            }
            catch (Exception ex)
            {
                Console.WriteLine("ocorreu um erro: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("sempre ocorre");
            }
        }

        static void Testar(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                throw new Exception("O texto não pode ser nulo ou vazio");
        }
    }
}