using System;
using System.Text;

namespace EditorHtml
{
    public static class Editor
    {
        public static void Mostrar()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("------------");
            Inicio();
        }

        public static void Inicio()
        {
            var file = new StringBuilder();
            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("------------");
            Console.WriteLine(" Deseja salvar o arquivo? (sim ou não)");
            string resposta = Console.ReadLine().ToLower();
            if (resposta == "sim")
            {
                //preparar parar salvar arquivo
                Console.Write("Digite nome do arquivo: ");
                var nome = Console.ReadLine();
                var caminho = "c:/dev/"+nome+".txt";

                using (var arquivo = new StreamWriter(caminho))
                {
                    arquivo.Write(file);
                }
                Console.Write($"Arquivo {0} salvo em {1}" ,nome,caminho);
            }
            else if (resposta == "não")
            {
                Console.WriteLine("Você não quis salvar o arquivo :/");
            }
            Visualizador.Mostrar(file.ToString());
        }
    }
}