using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace popytka6
{
    public class Human
    {
        private static string pyti;
        public string Name;
        public int Age;
        public string Myfavoritcolor;
        public string gas;

        static void Perecis()
        {
            Human sofi = new Human();
            sofi.Name = "Софи";
            sofi.Age = 12;
            sofi.Myfavoritcolor = "Зелёный";
            Human Lisa = new Human();
            Lisa.Name = "Лиза";
            Lisa.Age = 21;
            Lisa.Myfavoritcolor = "Фиолетовый";
            List<Human> humans = new List<Human>();
            humans.Add(sofi);
            humans.Add(Lisa);
            string json = JsonConvert.SerializeObject(humans);
            File.WriteAllText(pyti + "", json);
        }
        static void textov()
        {
            string txt = "Имя: Софи; Возраст: 12; Цвет: Зелёный\nИмя: Лиза; Возраст: 21; Цвет: Фиолетовый";
            File.AppendAllTextAsync(pyti + "", txt);
        }
        static void xmlov()
        {
            Human sofi = new Human();
            sofi.Name = "Софи";
            sofi.Age = 12;
            sofi.Myfavoritcolor = "Зелёный";
            Human Lisa = new Human();
            Lisa.Name = "Лиза";
            Lisa.Age = 21;
            Lisa.Myfavoritcolor = "Фиолетовый";
            List<Human> humans = new List<Human>();
            humans.Add(sofi);
            humans.Add(Lisa);

            Human human;
            XmlSerializer xml = new XmlSerializer(typeof(List<Human>));
            using (FileStream fs = new FileStream(pyti, FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, humans);
            }
        }
        public void seril()
        {
            Console.WriteLine("Напишите сюда путь до файла, что бы сохранить его!");
            pyti = Console.ReadLine();
            if (pyti.Contains(".txt"))
            {
                textov();
            }
            else
            if (pyti.Contains(".json"))
            {
                Perecis();
            }
            else
            if (pyti.Contains(".xml"))
            {
                xmlov();
            }
        }
    
    }
}


