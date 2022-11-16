using Newtonsoft.Json;
using System.Drawing;
using System.IO;
using System.Xml;

namespace popytka6
{
    internal class Program
    {
        static void Main()
        {
            ConsoleKeyInfo clavisha;
            do
            {
                Console.WriteLine("Чтобы сохранить текст нажмите F1, что бы вывести текст из файла сюда нажмите F2");
                clavisha = Console.ReadKey();
                if (clavisha.Key == ConsoleKey.F1)
                {
                    Human human = new Human();
                    human.seril();
                    Console.Clear();
                }
                else
                if (clavisha.Key == ConsoleKey.F2)
                {
                    desir desir = new desir();
                    desir.des();
                    Console.ReadKey();
                }
                Console.WriteLine("Чтобы сохранить текст нажмите F1, что бы вывести текст из файла сюда нажмите F2");
                Console.Clear();
            } while (clavisha.Key != ConsoleKey.Escape);
        }
    }

}