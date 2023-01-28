using System;
using System.IO;
using System.Text;

namespace EditorHtml 
{
    public static class Editor 
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Modo Editor");
            Console.WriteLine("____________________");
            Start();


        }
        public static void Start()
        {
            var file = new StringBuilder();

            do {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);

            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("____________________");
            Console.WriteLine("Deseja salvar o arquivo?");
        }
    }
    
    
}