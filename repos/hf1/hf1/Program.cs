using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace hf1
{
    public delegate void AgeChangingDelegate(int oldAge, int newAge);
    class Program
    {
        static void PersonAgeChanging(int oldAge, int newAge)
        {
            Console.WriteLine(oldAge + " => " + newAge);
        }
        static void Main(string[] args)
        {
            Person p = new Person();
            p.AgeChanging += PersonAgeChanging;
            p.AgeChanging += PersonAgeChanging;
            p.AgeChanging -= PersonAgeChanging;
            p.Age = 2;
            p.Name = "Luke";
            p.Age++;
            Console.WriteLine(p.Age);
            Console.WriteLine(p.Name);
            XmlSerializer serializer = new XmlSerializer(typeof(Person));
            FileStream stream = new FileStream("person.txt", FileMode.Create);
            serializer.Serialize(stream, p);
            stream.Close();
            Process.Start("person.txt");
        }
    }
}
