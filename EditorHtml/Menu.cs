using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Mostrar()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            DesenhaTela();
            EscreveOpcoes();
            var opcao = short.Parse(Console.ReadLine());
            OpcoesMenu(opcao);
        }

        public static void DesenhaTela()
        {
            DesenhaBorda();
            Console.Write("\n");

            for (int linhas = 0; linhas <= 10; linhas++)
            {
                Console.Write("|");
                for (int i = 0; i <= 30; i++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");
            }

            DesenhaBorda();
        }

        static void DesenhaBorda()
        {
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
                Console.Write("-");

            Console.Write("+");
        }

        public static void EscreveOpcoes()
        {
            Console.SetCursorPosition(3, 2);//coluna,linha
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.Write("================");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir arquivo");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 9);
            Console.Write("Opção: ");
        }

        public static void OpcoesMenu(short opcao)
        {
            switch (opcao)
            {
                case 0 : {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
                case 1 : Editor.Mostrar(); break;
                case 2 : Console.WriteLine("Visualizar"); break;
                default: Mostrar(); break;
            }
        }
    }
}