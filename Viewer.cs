using System;
using System.Text.RegularExpressions;

namespace   EditorHtml
{
    public class Viewer
    {
        public static void Show(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Modo de Visualização");
            Console.WriteLine("____________________");
            Replace(text);
            Console.WriteLine("____________________");
            Console.ReadKey();
            Menu.Show();

        }

        public static void Replace(string text)
        {
            var strong = new Regex("<\s*strong[^>]*>(.*?)<\s*/\s*stong>");     // "<\s*strong[^>]*>(.*?)<\s*/\s*stong>" isso é uma expressão regular, ela pega parte do texto e tranforma em outro texto.
        }
    }
}
