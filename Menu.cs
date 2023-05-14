using System;

namespace EditorHtml
{
    public static class Menu 
    {

        public static void Show()
        {
            Console.Clear();
            //Escolhe a cor de fundo
            Console.BackgroundColor = ConsoleColor.Black;
            //Escolhe a cor da letra
            Console.ForegroundColor = ConsoleColor.Blue;

            DrawScreen();
            WriteOptions();

            var Opcao = short.Parse(Console.ReadLine());
            HandleMenuOption(Opcao);
        }

        //Desenha na tela
        public static void DrawScreen()
        {
            Console.Clear();
            Console.Write("+");
            for (int i = 0; i <= 35; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");

            for (int linhas = 0; linhas <= 10; linhas++)
            {
                Console.Write("|");
                for (int i = 0; i <= 35; i++)
                    Console.Write(" ");
                Console.Write("|");
                Console.Write("\n");
            }

            Console.Write("+");
            for (int i = 0; i <= 35; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");


        }

        public static void WriteOptions()
        {
            //Escreve na posição da tela desejada
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("--------------------------");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selcione uma opção abaixo:");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1- Criar novo arquivo.");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2- Abrir arquivo.");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0- Sair.");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção desejada: ");




        }

        public static void HandleMenuOption(short Opcao)
        {
            switch (Opcao)
            {
                case 1: Editor.Show(); break;
                case 2: Console.WriteLine("Abrir"); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                    }
                    break;
                default: Show(); break;
            }

        }
    }
}
