using Newtonsoft.Json;
using System.Xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;

namespace popytka6
{
    public class desir
    {
        static imen na = new imen();
        static imen ag = new imen();
        static imen col = new imen();
        public string name;
        public int Age;
        public string Myfavoritcolor;
        public string gas;
        private static string pyti;
        static void t()
        {
            string txt = File.ReadAllText(pyti);
            Console.WriteLine(txt);
        }
        static void desxml()
        {
            na.name = "Софи";
            ag.Age = 12;
            col.Myfavoritcolor = "Зелёный";
            na.name = "Лиза";
            ag.Age = 21;
            col.Myfavoritcolor = "Фиолетовый";

            XmlSerializer xml = new XmlSerializer(typeof(List<Human>));
            using (FileStream fs = new FileStream(pyti, FileMode.Open))
            {
                var imlis = (List<Human>)xml.Deserialize(fs);
                foreach (var imen in imlis)
                {
                    Console.WriteLine($"{imen.Name}\n{imen.Myfavoritcolor}\n{imen.Age}\n");
                }
            }
        }
        static void on()
        {
            string txtt = File.ReadAllText(pyti);
            List<desir> txt = JsonConvert.DeserializeObject<List<desir>>(txtt);
            foreach (var Human in txt)
            {
                Console.WriteLine($"{Human.name}{Human.Myfavoritcolor}{Human.Age}");
            }
        }
        public void des()
        {
            Console.WriteLine("Введите путь до файла, чтобы прочесть его!");
            pyti = Console.ReadLine();
            if (pyti.Contains(".txt"))
            {
                t();
            }
            else
            if (pyti.Contains(".json"))
            {
                on();
            }
            else
            if (pyti.Contains(".xml"))
            {
                desxml();
            }
        }
    }
}
